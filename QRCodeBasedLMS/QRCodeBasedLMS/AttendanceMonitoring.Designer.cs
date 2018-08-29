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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_SchoolID = new System.Windows.Forms.TextBox();
            this.link_Back = new System.Windows.Forms.LinkLabel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pb_ScanQR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.link_ScanQR = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScanQR)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Student ID Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name :";
            // 
            // txt_Name
            // 
            this.txt_Name.Enabled = false;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(84, 247);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(194, 22);
            this.txt_Name.TabIndex = 25;
            // 
            // txt_SchoolID
            // 
            this.txt_SchoolID.Location = new System.Drawing.Point(157, 216);
            this.txt_SchoolID.Name = "txt_SchoolID";
            this.txt_SchoolID.Size = new System.Drawing.Size(121, 20);
            this.txt_SchoolID.TabIndex = 32;
            this.txt_SchoolID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // link_Back
            // 
            this.link_Back.AutoSize = true;
            this.link_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Back.Location = new System.Drawing.Point(245, 9);
            this.link_Back.Name = "link_Back";
            this.link_Back.Size = new System.Drawing.Size(60, 16);
            this.link_Back.TabIndex = 33;
            this.link_Back.TabStop = true;
            this.link_Back.Text = "Go Back";
            this.link_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Back_LinkClicked);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(188, 275);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 40);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pb_ScanQR
            // 
            this.pb_ScanQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_ScanQR.Location = new System.Drawing.Point(84, 51);
            this.pb_ScanQR.Name = "pb_ScanQR";
            this.pb_ScanQR.Size = new System.Drawing.Size(130, 130);
            this.pb_ScanQR.TabIndex = 36;
            this.pb_ScanQR.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "OR";
            // 
            // link_ScanQR
            // 
            this.link_ScanQR.AutoSize = true;
            this.link_ScanQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_ScanQR.Location = new System.Drawing.Point(81, 371);
            this.link_ScanQR.Name = "link_ScanQR";
            this.link_ScanQR.Size = new System.Drawing.Size(115, 16);
            this.link_ScanQR.TabIndex = 38;
            this.link_ScanQR.TabStop = true;
            this.link_ScanQR.Text = "Scan Library Card";
            this.link_ScanQR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_ScanQR_LinkClicked);
            // 
            // AttendanceMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 407);
            this.Controls.Add(this.link_ScanQR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pb_ScanQR);
            this.Controls.Add(this.link_Back);
            this.Controls.Add(this.txt_SchoolID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Name = "AttendanceMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceMonitoring";
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
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pb_ScanQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_ScanQR;
    }
}