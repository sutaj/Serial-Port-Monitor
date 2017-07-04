namespace Serial_Monitor
{
    partial class frmMONITOR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._cSTRIP = new System.Windows.Forms.StatusStrip();
            this._cCMD = new System.Windows.Forms.TextBox();
            this._cEventView = new System.Windows.Forms.ListView();
            this._headICON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._headCOMMAND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._cSEND = new System.Windows.Forms.Button();
            this._ctoppanel = new System.Windows.Forms.Panel();
            this._cW = new System.Windows.Forms.ToolStripStatusLabel();
            this._cSTRIP.SuspendLayout();
            this._ctoppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cSTRIP
            // 
            this._cSTRIP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cW});
            this._cSTRIP.Location = new System.Drawing.Point(0, 486);
            this._cSTRIP.Name = "_cSTRIP";
            this._cSTRIP.Size = new System.Drawing.Size(821, 22);
            this._cSTRIP.TabIndex = 0;
            this._cSTRIP.Text = "statusStrip1";
            // 
            // _cCMD
            // 
            this._cCMD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cCMD.CausesValidation = false;
            this._cCMD.Location = new System.Drawing.Point(3, 5);
            this._cCMD.Name = "_cCMD";
            this._cCMD.Size = new System.Drawing.Size(734, 20);
            this._cCMD.TabIndex = 1;
            this._cCMD.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this._cCMD_PreviewKeyDown);
            // 
            // _cEventView
            // 
            this._cEventView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._headICON,
            this._headCOMMAND});
            this._cEventView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cEventView.FullRowSelect = true;
            this._cEventView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this._cEventView.Location = new System.Drawing.Point(0, 33);
            this._cEventView.MultiSelect = false;
            this._cEventView.Name = "_cEventView";
            this._cEventView.Size = new System.Drawing.Size(821, 453);
            this._cEventView.TabIndex = 2;
            this._cEventView.UseCompatibleStateImageBehavior = false;
            this._cEventView.View = System.Windows.Forms.View.Details;
            // 
            // _headICON
            // 
            this._headICON.Text = "";
            this._headICON.Width = 30;
            // 
            // _headCOMMAND
            // 
            this._headCOMMAND.Text = "Command";
            this._headCOMMAND.Width = 633;
            // 
            // _cSEND
            // 
            this._cSEND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cSEND.Location = new System.Drawing.Point(743, 3);
            this._cSEND.Name = "_cSEND";
            this._cSEND.Size = new System.Drawing.Size(75, 23);
            this._cSEND.TabIndex = 3;
            this._cSEND.Text = "Send";
            this._cSEND.UseVisualStyleBackColor = true;
            // 
            // _ctoppanel
            // 
            this._ctoppanel.Controls.Add(this._cCMD);
            this._ctoppanel.Controls.Add(this._cSEND);
            this._ctoppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._ctoppanel.Location = new System.Drawing.Point(0, 0);
            this._ctoppanel.Name = "_ctoppanel";
            this._ctoppanel.Size = new System.Drawing.Size(821, 33);
            this._ctoppanel.TabIndex = 4;
            // 
            // _cW
            // 
            this._cW.Name = "_cW";
            this._cW.Size = new System.Drawing.Size(21, 17);
            this._cW.Text = " ⏺ ";
            // 
            // frmMONITOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 508);
            this.Controls.Add(this._cEventView);
            this.Controls.Add(this._cSTRIP);
            this.Controls.Add(this._ctoppanel);
            this.Name = "frmMONITOR";
            this.Text = "Serial Port Monitor";
            this.Load += new System.EventHandler(this.frmMONITOR_Load);
            this._cSTRIP.ResumeLayout(false);
            this._cSTRIP.PerformLayout();
            this._ctoppanel.ResumeLayout(false);
            this._ctoppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip _cSTRIP;
        private System.Windows.Forms.TextBox _cCMD;
        private System.Windows.Forms.ListView _cEventView;
        private System.Windows.Forms.Button _cSEND;
        private System.Windows.Forms.Panel _ctoppanel;
        private System.Windows.Forms.ColumnHeader _headICON;
        private System.Windows.Forms.ColumnHeader _headCOMMAND;
        private System.Windows.Forms.ToolStripStatusLabel _cW;
    }
}

