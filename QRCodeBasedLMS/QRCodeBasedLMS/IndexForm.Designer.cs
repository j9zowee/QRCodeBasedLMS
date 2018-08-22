namespace QRCodeBasedLMS
{
    partial class IndexForm
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
            this.link_SignIn = new System.Windows.Forms.LinkLabel();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btn_Inquiry = new System.Windows.Forms.Button();
            this.link_Attendance = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // link_SignIn
            // 
            this.link_SignIn.AutoSize = true;
            this.link_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_SignIn.Location = new System.Drawing.Point(374, 9);
            this.link_SignIn.Name = "link_SignIn";
            this.link_SignIn.Size = new System.Drawing.Size(48, 16);
            this.link_SignIn.TabIndex = 0;
            this.link_SignIn.TabStop = true;
            this.link_SignIn.Text = "Sign In";
            this.link_SignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_SignIn_LinkClicked);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Location = new System.Drawing.Point(39, 65);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(162, 65);
            this.btnBorrow.TabIndex = 1;
            this.btnBorrow.Text = "BORROW";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btn_Inquiry
            // 
            this.btn_Inquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inquiry.Location = new System.Drawing.Point(232, 65);
            this.btn_Inquiry.Name = "btn_Inquiry";
            this.btn_Inquiry.Size = new System.Drawing.Size(162, 65);
            this.btn_Inquiry.TabIndex = 2;
            this.btn_Inquiry.Text = "INQUIRY";
            this.btn_Inquiry.UseVisualStyleBackColor = true;
            // 
            // link_Attendance
            // 
            this.link_Attendance.AutoSize = true;
            this.link_Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Attendance.Location = new System.Drawing.Point(292, 9);
            this.link_Attendance.Name = "link_Attendance";
            this.link_Attendance.Size = new System.Drawing.Size(76, 16);
            this.link_Attendance.TabIndex = 3;
            this.link_Attendance.TabStop = true;
            this.link_Attendance.Text = "Attendance";
            this.link_Attendance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Attendance_LinkClicked);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 184);
            this.Controls.Add(this.link_Attendance);
            this.Controls.Add(this.btn_Inquiry);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.link_SignIn);
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_SignIn;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btn_Inquiry;
        private System.Windows.Forms.LinkLabel link_Attendance;
    }
}