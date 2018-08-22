namespace QRCodeBasedLMS
{
    partial class AttendanceMonitoring
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_SchoolID = new System.Windows.Forms.TextBox();
            this.link_Back = new System.Windows.Forms.LinkLabel();
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.pb_ScanQR = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Student ID Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name :";
            // 
            // txt_Name
            // 
            this.txt_Name.Enabled = false;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(78, 435);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(194, 22);
            this.txt_Name.TabIndex = 25;
            // 
            // txt_SchoolID
            // 
            this.txt_SchoolID.Location = new System.Drawing.Point(151, 404);
            this.txt_SchoolID.Name = "txt_SchoolID";
            this.txt_SchoolID.Size = new System.Drawing.Size(121, 20);
            this.txt_SchoolID.TabIndex = 32;
            this.txt_SchoolID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // link_Back
            // 
            this.link_Back.AutoSize = true;
            this.link_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Back.Location = new System.Drawing.Point(397, 9);
            this.link_Back.Name = "link_Back";
            this.link_Back.Size = new System.Drawing.Size(60, 16);
            this.link_Back.TabIndex = 33;
            this.link_Back.TabStop = true;
            this.link_Back.Text = "Go Back";
            this.link_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Back_LinkClicked);
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(330, 33);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(90, 29);
            this.btnCamera.TabIndex = 37;
            this.btnCamera.Text = "Start Camera";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Visible = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(299, 409);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(90, 40);
            this.btnScan.TabIndex = 35;
            this.btnScan.Text = "SCAN";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cmbDevice
            // 
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(13, 38);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(298, 21);
            this.cmbDevice.TabIndex = 34;
            this.cmbDevice.SelectedIndexChanged += new System.EventHandler(this.cmbDevice_SelectedIndexChanged);
            this.cmbDevice.TextChanged += new System.EventHandler(this.cmbDevice_TextChanged);
            // 
            // pb_ScanQR
            // 
            this.pb_ScanQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_ScanQR.Location = new System.Drawing.Point(13, 75);
            this.pb_ScanQR.Name = "pb_ScanQR";
            this.pb_ScanQR.Size = new System.Drawing.Size(442, 323);
            this.pb_ScanQR.TabIndex = 36;
            this.pb_ScanQR.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AttendanceMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 476);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.pb_ScanQR);
            this.Controls.Add(this.link_Back);
            this.Controls.Add(this.txt_SchoolID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Name = "AttendanceMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceMonitoring";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AttendanceMonitoring_FormClosing);
            this.Load += new System.EventHandler(this.AttendanceMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_SchoolID;
        private System.Windows.Forms.LinkLabel link_Back;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.PictureBox pb_ScanQR;
        private System.Windows.Forms.Timer timer;
    }
}