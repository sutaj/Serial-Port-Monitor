using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;

namespace Serial_Monitor
{
    public partial class frmMONITOR : Form
    {
        #region VARS and others
        ImageList _imgLIST = new ImageList();
        Image _imgON, _imgOFF;
        CORE core = new CORE();
        Timer TIK = new Timer();
        SerialPort sPORT = new SerialPort();
        string port = null, device = null;
        #endregion


        public frmMONITOR()
        {
            InitializeComponent();

            // SET YOUR DEVICE NAME !
            device = "Arduino Leonardo";

            TIK.Tick += TIKTAK;
            TIK.Interval = 500;
            TIK.Start();
            sPORT.DataReceived += SPORT_DataReceived;
            //sPORT.DataReceived += MonitorSerial;
            sPORT.DtrEnable = true;
            sPORT.BaudRate = 9600;
            sPORT.PortName = core.getPorts(device);
            _imgLIST.Images.Add("send", new Bitmap(Properties.Resources.Send));
            _imgLIST.Images.Add("receive", new Bitmap(Properties.Resources.receive, 16, 16));
            _imgON = new Bitmap(Properties.Resources.green_circle_th, 12, 12);
            _imgOFF = new Bitmap(Properties.Resources.red_circle_th, 12, 12);
            _cEventView.SmallImageList = _imgLIST;
        }

        private void TIKTAK(object sender, EventArgs e)
        {
            if(port != core.getPorts(device))
            {
                port = core.getPorts(device);
            }
            
            if (port == null)
            {
                this.Text = "DEVICE DISCONNECTED";
            }
            else
            {
                this.Text = string.Format("Connected on port {0}.", port);
                if (!sPORT.IsOpen)
                {
                    sPORT.PortName = port;
                    sPORT.Open();
                }
            }
            _cW.Visible = false;
        }

        private void frmMONITOR_Load(object sender, EventArgs e)
        {
            sPORT.Open();
        }

        #region Monitor device port

        private void SPORT_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.BeginInvoke(
                (Action)delegate
                {
                    _cW.Visible = true;
                }
                );
            
            if (sPORT.IsOpen)
            {
                string line = sPORT.ReadLine().TrimEnd('\n').TrimEnd('\r');
                this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
            }
        }

        private delegate void LineReceivedEvent(string line);

        private void LineReceived(string line)
        {
            MakeItem("receive", string.Format("↧   {0}", line) );
        }
        #endregion



        private void _cCMD_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (sPORT.IsOpen)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        MakeItem("send", string.Format("↥   {0}", _cCMD.Text));
                    }
                    sPORT.WriteLine(_cCMD.Text);
                }
                _cCMD.Text = null;
            }
            catch
            {
            }

        }

        void MakeItem(string mode, string text)
        {
                ListViewItem itm = new ListViewItem("", mode);
                ListViewItem.ListViewSubItem sub = new ListViewItem.ListViewSubItem(itm, text);
                _cEventView.Items.Add(itm).SubItems.Add(sub);
                _cEventView.EnsureVisible(_cEventView.Items.Count - 1);
        }
    }
}
