namespace QRCodeBasedLMS
{
    partial class Book
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
            this.pb_QRBook = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BookIDNum = new System.Windows.Forms.TextBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AccessionNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CallNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Edition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Volume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Pages = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Publisher = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_CopyrightYear = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_SearchCategory = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.Link_Scan = new System.Windows.Forms.LinkLabel();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp_DateReceived = new System.Windows.Forms.DateTimePicker();
            this.gb_Copy = new System.Windows.Forms.GroupBox();
            this.lbl_NumCopies = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbBookType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.gb_Copy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_QRBook
            // 
            this.pb_QRBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_QRBook.Location = new System.Drawing.Point(12, 12);
            this.pb_QRBook.Name = "pb_QRBook";
            this.pb_QRBook.Size = new System.Drawing.Size(130, 130);
            this.pb_QRBook.TabIndex = 11;
            this.pb_QRBook.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Book ID Number :";
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(218, 115);
            this.txt_Title.Multiline = true;
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(189, 50);
            this.txt_Title.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "*Title :";
            // 
            // txt_BookIDNum
            // 
            this.txt_BookIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookIDNum.Location = new System.Drawing.Point(287, 9);
            this.txt_BookIDNum.Name = "txt_BookIDNum";
            this.txt_BookIDNum.Size = new System.Drawing.Size(119, 22);
            this.txt_BookIDNum.TabIndex = 1;
            this.txt_BookIDNum.TextChanged += new System.EventHandler(this.txt_BookIDNum_TextChanged);
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBook.Location = new System.Drawing.Point(12, 249);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(884, 269);
            this.dgvBook.TabIndex = 22;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(604, 202);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(93, 41);
            this.btn_Clear.TabIndex = 17;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "*Accession Num:";
            // 
            // txt_AccessionNumber
            // 
            this.txt_AccessionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccessionNumber.Location = new System.Drawing.Point(116, 20);
            this.txt_AccessionNumber.Name = "txt_AccessionNumber";
            this.txt_AccessionNumber.Size = new System.Drawing.Size(77, 22);
            this.txt_AccessionNumber.TabIndex = 13;
            this.txt_AccessionNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AccessionNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Call Number : ";
            // 
            // txt_CallNumber
            // 
            this.txt_CallNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CallNumber.Location = new System.Drawing.Point(265, 87);
            this.txt_CallNumber.Name = "txt_CallNumber";
            this.txt_CallNumber.Size = new System.Drawing.Size(141, 22);
            this.txt_CallNumber.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Author :";
            // 
            // txt_Author
            // 
            this.txt_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Author.Location = new System.Drawing.Point(227, 172);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(180, 22);
            this.txt_Author.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Edition : ";
            // 
            // txt_Edition
            // 
            this.txt_Edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Edition.Location = new System.Drawing.Point(479, 60);
            this.txt_Edition.Name = "txt_Edition";
            this.txt_Edition.Size = new System.Drawing.Size(179, 22);
            this.txt_Edition.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(421, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Volume :";
            // 
            // txt_Volume
            // 
            this.txt_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Volume.Location = new System.Drawing.Point(479, 91);
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(179, 22);
            this.txt_Volume.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(421, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "*Pages :";
            // 
            // txt_Pages
            // 
            this.txt_Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pages.Location = new System.Drawing.Point(479, 119);
            this.txt_Pages.Name = "txt_Pages";
            this.txt_Pages.Size = new System.Drawing.Size(179, 22);
            this.txt_Pages.TabIndex = 11;
            this.txt_Pages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pages_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "*Publisher :";
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Publisher.Location = new System.Drawing.Point(496, 6);
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.Size = new System.Drawing.Size(162, 22);
            this.txt_Publisher.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(420, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "*Copyright Year :";
            // 
            // txt_CopyrightYear
            // 
            this.txt_CopyrightYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CopyrightYear.Location = new System.Drawing.Point(529, 34);
            this.txt_CopyrightYear.MaxLength = 4;
            this.txt_CopyrightYear.Name = "txt_CopyrightYear";
            this.txt_CopyrightYear.Size = new System.Drawing.Size(128, 22);
            this.txt_CopyrightYear.TabIndex = 8;
            this.txt_CopyrightYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CopyrightYear_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "*Status :";
            // 
            // cmb_Status
            // 
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.ItemHeight = 16;
            this.cmb_Status.Items.AddRange(new object[] {
            "On Shelf",
            "Damaged"});
            this.cmb_Status.Location = new System.Drawing.Point(65, 80);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(128, 24);
            this.cmb_Status.TabIndex = 11;
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.Location = new System.Drawing.Point(488, 147);
            this.txt_Remarks.Multiline = true;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(170, 47);
            this.txt_Remarks.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(422, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Remarks : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Search by: ";
            // 
            // cmb_SearchCategory
            // 
            this.cmb_SearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchCategory.FormattingEnabled = true;
            this.cmb_SearchCategory.ItemHeight = 13;
            this.cmb_SearchCategory.Items.AddRange(new object[] {
            "QR Code",
            "Title"});
            this.cmb_SearchCategory.Location = new System.Drawing.Point(75, 222);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmb_SearchCategory.TabIndex = 15;
            this.cmb_SearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchCategory_SelectedIndexChanged);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(202, 220);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(119, 22);
            this.txt_Search.TabIndex = 21;
            this.txt_Search.Visible = false;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // Link_Scan
            // 
            this.Link_Scan.AutoSize = true;
            this.Link_Scan.Location = new System.Drawing.Point(202, 227);
            this.Link_Scan.Name = "Link_Scan";
            this.Link_Scan.Size = new System.Drawing.Size(79, 13);
            this.Link_Scan.TabIndex = 20;
            this.Link_Scan.TabStop = true;
            this.Link_Scan.Text = "Scan QR Code";
            this.Link_Scan.Visible = false;
            this.Link_Scan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Scan_LinkClicked);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Location = new System.Drawing.Point(505, 202);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(93, 41);
            this.btnAddOrUpdate.TabIndex = 16;
            this.btnAddOrUpdate.Text = "ADD";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(703, 202);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 41);
            this.btn_Exit.TabIndex = 18;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(168, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 50;
            this.label13.Text = "*ISBN :";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ISBN.Location = new System.Drawing.Point(217, 60);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(189, 22);
            this.txt_ISBN.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "Date Received :";
            // 
            // dtp_DateReceived
            // 
            this.dtp_DateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateReceived.Location = new System.Drawing.Point(113, 51);
            this.dtp_DateReceived.Name = "dtp_DateReceived";
            this.dtp_DateReceived.Size = new System.Drawing.Size(80, 20);
            this.dtp_DateReceived.TabIndex = 14;
            // 
            // gb_Copy
            // 
            this.gb_Copy.Controls.Add(this.txt_AccessionNumber);
            this.gb_Copy.Controls.Add(this.dtp_DateReceived);
            this.gb_Copy.Controls.Add(this.label1);
            this.gb_Copy.Controls.Add(this.label15);
            this.gb_Copy.Controls.Add(this.label11);
            this.gb_Copy.Controls.Add(this.cmb_Status);
            this.gb_Copy.Location = new System.Drawing.Point(670, 12);
            this.gb_Copy.Name = "gb_Copy";
            this.gb_Copy.Size = new System.Drawing.Size(207, 110);
            this.gb_Copy.TabIndex = 53;
            this.gb_Copy.TabStop = false;
            this.gb_Copy.Text = "1st Book Copy";
            // 
            // lbl_NumCopies
            // 
            this.lbl_NumCopies.AutoSize = true;
            this.lbl_NumCopies.Location = new System.Drawing.Point(13, 147);
            this.lbl_NumCopies.Name = "lbl_NumCopies";
            this.lbl_NumCopies.Size = new System.Drawing.Size(0, 13);
            this.lbl_NumCopies.TabIndex = 55;
            this.lbl_NumCopies.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(169, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 16);
            this.label16.TabIndex = 57;
            this.label16.Text = "*Book Type :";
            // 
            // cmbBookType
            // 
            this.cmbBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBookType.FormattingEnabled = true;
            this.cmbBookType.Items.AddRange(new object[] {
            "References",
            "Filipiniana",
            "General Reference",
            "Fiction"});
            this.cmbBookType.Location = new System.Drawing.Point(261, 33);
            this.cmbBookType.Name = "cmbBookType";
            this.cmbBookType.Size = new System.Drawing.Size(145, 24);
            this.cmbBookType.TabIndex = 2;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(908, 530);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbBookType);
            this.Controls.Add(this.lbl_NumCopies);
            this.Controls.Add(this.gb_Copy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.Link_Scan);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Remarks);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_CopyrightYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Publisher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Pages);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Volume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Edition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CallNumber);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.pb_QRBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_BookIDNum);
            this.MaximumSize = new System.Drawing.Size(924, 568);
            this.Name = "Book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.gb_Copy.ResumeLayout(false);
            this.gb_Copy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_QRBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BookIDNum;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AccessionNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CallNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Edition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Volume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Pages;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Publisher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_CopyrightYear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_SearchCategory;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.LinkLabel Link_Scan;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp_DateReceived;
        private System.Windows.Forms.GroupBox gb_Copy;
        private System.Windows.Forms.Label lbl_NumCopies;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbBookType;
    }
}