namespace QRCodeBasedLMS
{
    partial class UnapprovedAccounts
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
            this.label9 = new System.Windows.Forms.Label();
            this.txt_UserIDNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.pbUserQR = new System.Windows.Forms.PictureBox();
            this.Link_ScanQR = new System.Windows.Forms.LinkLabel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cmb_SearchCategory = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.brnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 117;
            this.label9.Text = "User ID Number :";
            // 
            // txt_UserIDNum
            // 
            this.txt_UserIDNum.Enabled = false;
            this.txt_UserIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserIDNum.Location = new System.Drawing.Point(126, 163);
            this.txt_UserIDNum.Name = "txt_UserIDNum";
            this.txt_UserIDNum.Size = new System.Drawing.Size(106, 22);
            this.txt_UserIDNum.TabIndex = 106;
            this.txt_UserIDNum.TextChanged += new System.EventHandler(this.txt_UserIDNum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "Lastname :";
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Enabled = false;
            this.txt_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lastname.Location = new System.Drawing.Point(93, 219);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(140, 22);
            this.txt_Lastname.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 115;
            this.label1.Text = "Firstname :";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Enabled = false;
            this.txt_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Firstname.Location = new System.Drawing.Point(93, 191);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(140, 22);
            this.txt_Firstname.TabIndex = 107;
            // 
            // pbUserQR
            // 
            this.pbUserQR.Location = new System.Drawing.Point(61, 17);
            this.pbUserQR.Name = "pbUserQR";
            this.pbUserQR.Size = new System.Drawing.Size(130, 130);
            this.pbUserQR.TabIndex = 114;
            this.pbUserQR.TabStop = false;
            // 
            // Link_ScanQR
            // 
            this.Link_ScanQR.AutoSize = true;
            this.Link_ScanQR.Location = new System.Drawing.Point(466, 15);
            this.Link_ScanQR.Name = "Link_ScanQR";
            this.Link_ScanQR.Size = new System.Drawing.Size(79, 13);
            this.Link_ScanQR.TabIndex = 110;
            this.Link_ScanQR.TabStop = true;
            this.Link_ScanQR.Text = "Scan QR Code";
            this.Link_ScanQR.Visible = false;
            this.Link_ScanQR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_ScanQR_LinkClicked);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(466, 8);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(136, 22);
            this.txt_Search.TabIndex = 111;
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
            this.cmb_SearchCategory.Location = new System.Drawing.Point(339, 8);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmb_SearchCategory.TabIndex = 109;
            this.cmb_SearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchCategory_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 113;
            this.label15.Text = "Search by :";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccount.Location = new System.Drawing.Point(255, 35);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(404, 299);
            this.dgvAccount.TabIndex = 112;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 118;
            this.label2.Text = "Status :";
            // 
            // cmb_Status
            // 
            this.cmb_Status.Enabled = false;
            this.cmb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Deactivate"});
            this.cmb_Status.Location = new System.Drawing.Point(71, 247);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(162, 24);
            this.cmb_Status.TabIndex = 119;
            // 
            // brnClear
            // 
            this.brnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnClear.Location = new System.Drawing.Point(93, 292);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(75, 40);
            this.brnClear.TabIndex = 121;
            this.brnClear.Text = "CLEAR";
            this.brnClear.UseVisualStyleBackColor = true;
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(174, 291);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 122;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(9, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 120;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UnapprovedAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 346);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_UserIDNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.pbUserQR);
            this.Controls.Add(this.Link_ScanQR);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvAccount);
            this.Name = "UnapprovedAccounts";
            this.Text = "UnapprovedAccounts";
            this.Load += new System.EventHandler(this.UnapprovedAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_UserIDNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.PictureBox pbUserQR;
        private System.Windows.Forms.LinkLabel Link_ScanQR;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cmb_SearchCategory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Button brnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
    }
}