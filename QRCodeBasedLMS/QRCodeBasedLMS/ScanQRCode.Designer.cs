namespace QRCodeBasedLMS
{
    partial class ScanQRCode
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
            this.components = new System.ComponentModel.Container();
            this.btnScan = new System.Windows.Forms.Button();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pb_ScanQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(116, 389);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(90, 29);
            this.btnScan.TabIndex = 37;
            this.btnScan.Text = "SCAN";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cmbDevice
            // 
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(12, 12);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(298, 21);
            this.cmbDevice.TabIndex = 36;
            this.cmbDevice.TextChanged += new System.EventHandler(this.cmbDevice_TextChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(329, 7);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(90, 29);
            this.btnCamera.TabIndex = 40;
            this.btnCamera.Text = "Start Camera";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Visible = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 29);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pb_ScanQR
            // 
            this.pb_ScanQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_ScanQR.Location = new System.Drawing.Point(12, 49);
            this.pb_ScanQR.Name = "pb_ScanQR";
            this.pb_ScanQR.Size = new System.Drawing.Size(442, 323);
            this.pb_ScanQR.TabIndex = 38;
            this.pb_ScanQR.TabStop = false;
            // 
            // ScanQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 433);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pb_ScanQR);
            this.Name = "ScanQRCode";
            this.Text = "ScanQRCode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanQRCode_FormClosing);
            this.Load += new System.EventHandler(this.ScanQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pb_ScanQR;
    }
}