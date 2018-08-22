namespace QRCodeBasedLMS
{
    partial class NonReadingMaterials
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
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cmb_SearchCategory = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_CopyrightYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Volume = new System.Windows.Forms.TextBox();
            this.txt_Page = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pbBorrowerQR = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Issue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaterialIDNumber = new System.Windows.Forms.TextBox();
            this.txt_Publisher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_MatType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowerQR)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(490, 11);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(119, 22);
            this.txt_Search.TabIndex = 50;
            this.txt_Search.Visible = false;
            // 
            // cmb_SearchCategory
            // 
            this.cmb_SearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchCategory.FormattingEnabled = true;
            this.cmb_SearchCategory.Items.AddRange(new object[] {
            "QR Code",
            "Accession Number",
            "Call Number",
            "Title",
            "Author",
            "Copyright Year",
            "Status"});
            this.cmb_SearchCategory.Location = new System.Drawing.Point(363, 13);
            this.cmb_SearchCategory.Name = "cmb_SearchCategory";
            this.cmb_SearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmb_SearchCategory.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(305, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Search by: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 478);
            this.dataGridView1.TabIndex = 52;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(202, 454);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 41);
            this.btn_Exit.TabIndex = 63;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 71;
            this.label10.Text = "Copyright Year :";
            // 
            // txt_CopyrightYear
            // 
            this.txt_CopyrightYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CopyrightYear.Location = new System.Drawing.Point(135, 338);
            this.txt_CopyrightYear.Name = "txt_CopyrightYear";
            this.txt_CopyrightYear.Size = new System.Drawing.Size(142, 22);
            this.txt_CopyrightYear.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 70;
            this.label9.Text = "Volume :";
            // 
            // txt_Volume
            // 
            this.txt_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Volume.Location = new System.Drawing.Point(88, 282);
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(190, 22);
            this.txt_Volume.TabIndex = 54;
            // 
            // txt_Page
            // 
            this.txt_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Page.Location = new System.Drawing.Point(79, 426);
            this.txt_Page.Name = "txt_Page";
            this.txt_Page.Size = new System.Drawing.Size(199, 22);
            this.txt_Page.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Page :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Publisher :";
            // 
            // txt_Author
            // 
            this.txt_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Author.Location = new System.Drawing.Point(84, 366);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(193, 22);
            this.txt_Author.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Author :";
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Location = new System.Drawing.Point(7, 454);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(93, 41);
            this.btnAddOrUpdate.TabIndex = 60;
            this.btnAddOrUpdate.Text = "ADD";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(103, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 41);
            this.btnClear.TabIndex = 62;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pbBorrowerQR
            // 
            this.pbBorrowerQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBorrowerQR.Location = new System.Drawing.Point(111, 30);
            this.pbBorrowerQR.Name = "pbBorrowerQR";
            this.pbBorrowerQR.Size = new System.Drawing.Size(130, 130);
            this.pbBorrowerQR.TabIndex = 61;
            this.pbBorrowerQR.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Material ID Number :";
            // 
            // txt_Issue
            // 
            this.txt_Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Issue.Location = new System.Drawing.Point(88, 310);
            this.txt_Issue.Name = "txt_Issue";
            this.txt_Issue.Size = new System.Drawing.Size(190, 22);
            this.txt_Issue.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Issue :";
            // 
            // txt_MaterialIDNumber
            // 
            this.txt_MaterialIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaterialIDNumber.Location = new System.Drawing.Point(156, 172);
            this.txt_MaterialIDNumber.Name = "txt_MaterialIDNumber";
            this.txt_MaterialIDNumber.Size = new System.Drawing.Size(122, 22);
            this.txt_MaterialIDNumber.TabIndex = 53;
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Publisher.Location = new System.Drawing.Point(100, 396);
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.Size = new System.Drawing.Size(176, 22);
            this.txt_Publisher.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Title :";
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(72, 228);
            this.txt_Title.Multiline = true;
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(205, 45);
            this.txt_Title.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "Type :";
            // 
            // cmb_MatType
            // 
            this.cmb_MatType.FormattingEnabled = true;
            this.cmb_MatType.Items.AddRange(new object[] {
            "Journal",
            "Magazine"});
            this.cmb_MatType.Location = new System.Drawing.Point(72, 200);
            this.cmb_MatType.Name = "cmb_MatType";
            this.cmb_MatType.Size = new System.Drawing.Size(205, 21);
            this.cmb_MatType.TabIndex = 75;
            // 
            // NonReadingMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 530);
            this.Controls.Add(this.cmb_MatType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_CopyrightYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Volume);
            this.Controls.Add(this.txt_Publisher);
            this.Controls.Add(this.txt_Page);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Author);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pbBorrowerQR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Issue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MaterialIDNumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cmb_SearchCategory);
            this.Controls.Add(this.label14);
            this.Name = "NonReadingMaterials";
            this.Text = "NonReadingMaterials";
            this.Load += new System.EventHandler(this.NonReadingMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrowerQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cmb_SearchCategory;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_CopyrightYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Volume;
        private System.Windows.Forms.TextBox txt_Page;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pbBorrowerQR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Issue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaterialIDNumber;
        private System.Windows.Forms.TextBox txt_Publisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_MatType;
    }
}