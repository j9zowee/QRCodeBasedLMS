namespace QRCodeBasedLMS
{
    partial class Borrow
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BorrowerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BookIDNum = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pb_ScanQR = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(346, 404);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(90, 29);
            this.btnScan.TabIndex = 28;
            this.btnScan.Text = "SCAN";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cmbDevice
            // 
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(12, 23);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(298, 21);
            this.cmbDevice.TabIndex = 27;
            this.cmbDevice.TextChanged += new System.EventHandler(this.cmbDevice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Borrower ID Number :";
            // 
            // txt_BorrowerID
            // 
            this.txt_BorrowerID.Enabled = false;
            this.txt_BorrowerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BorrowerID.Location = new System.Drawing.Point(169, 407);
            this.txt_BorrowerID.Name = "txt_BorrowerID";
            this.txt_BorrowerID.Size = new System.Drawing.Size(155, 22);
            this.txt_BorrowerID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Book ID Number :";
            // 
            // txt_BookIDNum
            // 
            this.txt_BookIDNum.Enabled = false;
            this.txt_BookIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookIDNum.Location = new System.Drawing.Point(156, 439);
            this.txt_BookIDNum.Name = "txt_BookIDNum";
            this.txt_BookIDNum.Size = new System.Drawing.Size(168, 22);
            this.txt_BookIDNum.TabIndex = 23;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pb_ScanQR
            // 
            this.pb_ScanQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_ScanQR.Location = new System.Drawing.Point(12, 60);
            this.pb_ScanQR.Name = "pb_ScanQR";
            this.pb_ScanQR.Size = new System.Drawing.Size(442, 323);
            this.pb_ScanQR.TabIndex = 29;
            this.pb_ScanQR.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(346, 436);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 29);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(329, 18);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(90, 29);
            this.btnCamera.TabIndex = 31;
            this.btnCamera.Text = "Start Camera";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Visible = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 480);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BorrowerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_BookIDNum);
            this.Controls.Add(this.pb_ScanQR);
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Borrow_FormClosing);
            this.Load += new System.EventHandler(this.Borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BorrowerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BookIDNum;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pb_ScanQR;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCamera;
    }
}