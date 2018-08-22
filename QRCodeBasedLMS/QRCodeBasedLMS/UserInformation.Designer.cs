namespace QRCodeBasedLMS
{
    partial class UserInformation
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.Link_ScanQR = new System.Windows.Forms.LinkLabel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cmb_SearchCategory = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.brnClear = new System.Windows.Forms.Button();
            this.pbUserQR = new System.Windows.Forms.PictureBox();
            this.cmb_SecretQuestion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_UserIDNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SecretAnswer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Staff = new System.Windows.Forms.RadioButton();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.link_deactivate = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserQR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(181, 459);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrUpdate.Location = new System.Drawing.Point(16, 460);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnAddOrUpdate.TabIndex = 13;
            this.btnAddOrUpdate.Text = "ADD";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccount.Location = new System.Drawing.Point(281, 39);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(563, 460);
            this.dgvAccount.TabIndex = 84;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // Link_ScanQR
            // 
            this.Link_ScanQR.AutoSize = true;
            this.Link_ScanQR.Location = new System.Drawing.Point(464, 19);
            this.Link_ScanQR.Name = "Link_ScanQR";
            this.Link_ScanQR.Size = new System.Drawing.Size(79, 13);
            this.Link_ScanQR.TabIndex = 23;
            this.Link_ScanQR.TabStop = true;
            this.Link_ScanQR.Text = "Scan QR Code";
            this.Link_ScanQR.Visible = false;
            this.Link_ScanQR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_ScanQR_LinkClicked);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(464, 12);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(136, 22);
            this.txt_Search.TabIndex = 24;
            this.txt_Search.Visible = false;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // cmb_SearchCategory
            // 
            this.cmb_SearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchCategory.FormattingEnabled = true;
            this.cmb_SearchCategory.Items.AddRange(new object[] {
            "QR Code",
            "Lastname",
            "Firstname"});
            this.cmb_SearchCategory.Location = new System.Drawing.Point(337, 12);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmb_SearchCategory.TabIndex = 22;
            this.cmb_SearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchCategory_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 88;
            this.label15.Text = "Search by :";
            // 
            // brnClear
            // 
            this.brnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnClear.Location = new System.Drawing.Point(100, 460);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(75, 40);
            this.brnClear.TabIndex = 14;
            this.brnClear.Text = "CLEAR";
            this.brnClear.UseVisualStyleBackColor = true;
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
            // 
            // pbUserQR
            // 
            this.pbUserQR.Location = new System.Drawing.Point(59, 21);
            this.pbUserQR.Name = "pbUserQR";
            this.pbUserQR.Size = new System.Drawing.Size(130, 130);
            this.pbUserQR.TabIndex = 89;
            this.pbUserQR.TabStop = false;
            // 
            // cmb_SecretQuestion
            // 
            this.cmb_SecretQuestion.FormattingEnabled = true;
            this.cmb_SecretQuestion.Items.AddRange(new object[] {
            "Favorite food",
            "favorite pet"});
            this.cmb_SecretQuestion.Location = new System.Drawing.Point(125, 337);
            this.cmb_SecretQuestion.Name = "cmb_SecretQuestion";
            this.cmb_SecretQuestion.Size = new System.Drawing.Size(136, 21);
            this.cmb_SecretQuestion.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 105;
            this.label9.Text = "User ID Number :";
            // 
            // txt_UserIDNum
            // 
            this.txt_UserIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserIDNum.Location = new System.Drawing.Point(124, 167);
            this.txt_UserIDNum.Name = "txt_UserIDNum";
            this.txt_UserIDNum.Size = new System.Drawing.Size(137, 22);
            this.txt_UserIDNum.TabIndex = 1;
            this.txt_UserIDNum.TextChanged += new System.EventHandler(this.txt_UserIDNum_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 104;
            this.label8.Text = "Secret Answer :";
            // 
            // txt_SecretAnswer
            // 
            this.txt_SecretAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SecretAnswer.Location = new System.Drawing.Point(125, 363);
            this.txt_SecretAnswer.Name = "txt_SecretAnswer";
            this.txt_SecretAnswer.Size = new System.Drawing.Size(137, 22);
            this.txt_SecretAnswer.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 103;
            this.label7.Text = "Secret Question :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 102;
            this.label6.Text = "Confirm Password :";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(140, 307);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(122, 22);
            this.txt_ConfirmPassword.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 101;
            this.label5.Text = "Password :";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(91, 279);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(171, 22);
            this.txt_Password.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 100;
            this.label4.Text = "Username :";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(91, 251);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(171, 22);
            this.txt_Username.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 99;
            this.label3.Text = "Lastname :";
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lastname.Location = new System.Drawing.Point(91, 223);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(171, 22);
            this.txt_Lastname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Firstname :";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Firstname.Location = new System.Drawing.Point(91, 195);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(171, 22);
            this.txt_Firstname.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Staff);
            this.groupBox1.Controls.Add(this.rb_Admin);
            this.groupBox1.Location = new System.Drawing.Point(91, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 33);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            // 
            // rb_Staff
            // 
            this.rb_Staff.AutoSize = true;
            this.rb_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Staff.Location = new System.Drawing.Point(18, 10);
            this.rb_Staff.Name = "rb_Staff";
            this.rb_Staff.Size = new System.Drawing.Size(52, 20);
            this.rb_Staff.TabIndex = 10;
            this.rb_Staff.TabStop = true;
            this.rb_Staff.Text = "Staff";
            this.rb_Staff.UseVisualStyleBackColor = true;
            // 
            // rb_Admin
            // 
            this.rb_Admin.AutoSize = true;
            this.rb_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Admin.Location = new System.Drawing.Point(90, 10);
            this.rb_Admin.Name = "rb_Admin";
            this.rb_Admin.Size = new System.Drawing.Size(64, 20);
            this.rb_Admin.TabIndex = 9;
            this.rb_Admin.TabStop = true;
            this.rb_Admin.Text = "Admin";
            this.rb_Admin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "User Type :";
            // 
            // link_deactivate
            // 
            this.link_deactivate.AutoSize = true;
            this.link_deactivate.Location = new System.Drawing.Point(15, 425);
            this.link_deactivate.Name = "link_deactivate";
            this.link_deactivate.Size = new System.Drawing.Size(102, 13);
            this.link_deactivate.TabIndex = 108;
            this.link_deactivate.TabStop = true;
            this.link_deactivate.Text = "Deactivate Account";
            this.link_deactivate.Visible = false;
            this.link_deactivate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_deactivate_LinkClicked);
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 512);
            this.Controls.Add(this.link_deactivate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_SecretQuestion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_UserIDNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_SecretAnswer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.pbUserQR);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.Link_ScanQR);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Name = "UserInformation";
            this.Text = "UserInformation";
            this.Load += new System.EventHandler(this.UserInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserQR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.LinkLabel Link_ScanQR;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cmb_SearchCategory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button brnClear;
        private System.Windows.Forms.PictureBox pbUserQR;
        private System.Windows.Forms.ComboBox cmb_SecretQuestion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_UserIDNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SecretAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Staff;
        private System.Windows.Forms.RadioButton rb_Admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_deactivate;
    }
}