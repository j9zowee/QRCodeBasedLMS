namespace QRCodeBasedLMS
{
    partial class Borrower
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
            this.pbBorrowerQR = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_BorrowerIDNum = new System.Windows.Forms.TextBox();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvBorrower = new System.Windows.Forms.DataGridView();
            this.txt_Section = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ContactNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_SearchCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SchoolIDNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.Link_Scan = new System.Windows.Forms.LinkLabel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowerQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrower)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBorrowerQR
            // 
            this.pbBorrowerQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBorrowerQR.Location = new System.Drawing.Point(95, 30);
            this.pbBorrowerQR.Name = "pbBorrowerQR";
            this.pbBorrowerQR.Size = new System.Drawing.Size(130, 130);
            this.pbBorrowerQR.TabIndex = 11;
            this.pbBorrowerQR.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Borrower ID Number :";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Firstname.Location = new System.Drawing.Point(110, 229);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(190, 22);
            this.txt_Firstname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Firstname :";
            // 
            // txt_BorrowerIDNum
            // 
            this.txt_BorrowerIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BorrowerIDNum.Location = new System.Drawing.Point(178, 172);
            this.txt_BorrowerIDNum.Name = "txt_BorrowerIDNum";
            this.txt_BorrowerIDNum.Size = new System.Drawing.Size(122, 22);
            this.txt_BorrowerIDNum.TabIndex = 1;
            this.txt_BorrowerIDNum.TextChanged += new System.EventHandler(this.txtBorrowerID_TextChanged);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Location = new System.Drawing.Point(12, 454);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(93, 41);
            this.btnAddOrUpdate.TabIndex = 10;
            this.btnAddOrUpdate.Text = "ADD";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(108, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 41);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvBorrower
            // 
            this.dgvBorrower.AllowUserToAddRows = false;
            this.dgvBorrower.AllowUserToDeleteRows = false;
            this.dgvBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrower.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBorrower.Location = new System.Drawing.Point(312, 51);
            this.dgvBorrower.MultiSelect = false;
            this.dgvBorrower.Name = "dgvBorrower";
            this.dgvBorrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrower.Size = new System.Drawing.Size(584, 467);
            this.dgvBorrower.TabIndex = 25;
            this.dgvBorrower.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrower_CellClick);
            // 
            // txt_Section
            // 
            this.txt_Section.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Section.Location = new System.Drawing.Point(95, 285);
            this.txt_Section.Name = "txt_Section";
            this.txt_Section.Size = new System.Drawing.Size(205, 22);
            this.txt_Section.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Section : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Gender :";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(108, 350);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(192, 59);
            this.txt_Address.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Address :";
            // 
            // txt_ContactNum
            // 
            this.txt_ContactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContactNum.Location = new System.Drawing.Point(153, 415);
            this.txt_ContactNum.Name = "txt_ContactNum";
            this.txt_ContactNum.Size = new System.Drawing.Size(147, 22);
            this.txt_ContactNum.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Contact Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Search by :";
            // 
            // cmb_SearchCategory
            // 
            this.cmb_SearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchCategory.FormattingEnabled = true;
            this.cmb_SearchCategory.Items.AddRange(new object[] {
            "QR Code",
            "Firstname",
            "Lastname"});
            this.cmb_SearchCategory.Location = new System.Drawing.Point(371, 23);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmb_SearchCategory.TabIndex = 13;
            this.cmb_SearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchCategory_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "School ID :";
            // 
            // txt_SchoolIDNumber
            // 
            this.txt_SchoolIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SchoolIDNumber.Location = new System.Drawing.Point(110, 201);
            this.txt_SchoolIDNumber.Name = "txt_SchoolIDNumber";
            this.txt_SchoolIDNumber.Size = new System.Drawing.Size(190, 22);
            this.txt_SchoolIDNumber.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Lastname :";
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lastname.Location = new System.Drawing.Point(110, 257);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(190, 22);
            this.txt_Lastname.TabIndex = 4;
            // 
            // Link_Scan
            // 
            this.Link_Scan.AutoSize = true;
            this.Link_Scan.Location = new System.Drawing.Point(498, 30);
            this.Link_Scan.Name = "Link_Scan";
            this.Link_Scan.Size = new System.Drawing.Size(79, 13);
            this.Link_Scan.TabIndex = 14;
            this.Link_Scan.TabStop = true;
            this.Link_Scan.Text = "Scan QR Code";
            this.Link_Scan.Visible = false;
            this.Link_Scan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Scan_LinkClicked);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(498, 23);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(136, 22);
            this.txt_Search.TabIndex = 15;
            this.txt_Search.Visible = false;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(207, 454);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 41);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Female);
            this.groupBox2.Controls.Add(this.rb_Male);
            this.groupBox2.Location = new System.Drawing.Point(108, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 36);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(90, 12);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(72, 20);
            this.rb_Female.TabIndex = 7;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(17, 12);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(56, 20);
            this.rb_Male.TabIndex = 6;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.Link_Scan);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_SchoolIDNumber);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ContactNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Section);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvBorrower);
            this.Controls.Add(this.pbBorrowerQR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_BorrowerIDNum);
            this.Name = "Borrower";
            this.Text = "Borrower";
            this.Load += new System.EventHandler(this.Borrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowerQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrower)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBorrowerQR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_BorrowerIDNum;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvBorrower;
        private System.Windows.Forms.TextBox txt_Section;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ContactNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_SearchCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SchoolIDNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.LinkLabel Link_Scan;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
    }
}