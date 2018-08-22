namespace QRCodeBasedLMS
{
    partial class BookCopy
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
            this.txt_BookIDNum = new System.Windows.Forms.TextBox();
            this.txt_AccessionNumber = new System.Windows.Forms.TextBox();
            this.dtp_DateReceived = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_QRBook
            // 
            this.pb_QRBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_QRBook.Location = new System.Drawing.Point(17, 12);
            this.pb_QRBook.Name = "pb_QRBook";
            this.pb_QRBook.Size = new System.Drawing.Size(130, 130);
            this.pb_QRBook.TabIndex = 55;
            this.pb_QRBook.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Book ID Number :";
            // 
            // txt_BookIDNum
            // 
            this.txt_BookIDNum.Enabled = false;
            this.txt_BookIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookIDNum.Location = new System.Drawing.Point(271, 15);
            this.txt_BookIDNum.Name = "txt_BookIDNum";
            this.txt_BookIDNum.Size = new System.Drawing.Size(119, 22);
            this.txt_BookIDNum.TabIndex = 1;
            this.txt_BookIDNum.TextChanged += new System.EventHandler(this.txt_BookIDNum_TextChanged);
            // 
            // txt_AccessionNumber
            // 
            this.txt_AccessionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccessionNumber.Location = new System.Drawing.Point(262, 43);
            this.txt_AccessionNumber.Name = "txt_AccessionNumber";
            this.txt_AccessionNumber.Size = new System.Drawing.Size(128, 22);
            this.txt_AccessionNumber.TabIndex = 2;
            this.txt_AccessionNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AccessionNumber_KeyPress);
            // 
            // dtp_DateReceived
            // 
            this.dtp_DateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateReceived.Location = new System.Drawing.Point(259, 74);
            this.dtp_DateReceived.Name = "dtp_DateReceived";
            this.dtp_DateReceived.Size = new System.Drawing.Size(131, 20);
            this.dtp_DateReceived.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "*Accession Num:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(153, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 16);
            this.label15.TabIndex = 58;
            this.label15.Text = "Date Received :";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBook.Location = new System.Drawing.Point(12, 199);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(377, 222);
            this.dgvBook.TabIndex = 60;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Location = new System.Drawing.Point(194, 154);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(93, 41);
            this.btnAddOrUpdate.TabIndex = 5;
            this.btnAddOrUpdate.Text = "ADD";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(295, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(153, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 64;
            this.label11.Text = "*Status :";
            // 
            // cmb_Status
            // 
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "On Shelf",
            "Borrowed"});
            this.cmb_Status.Location = new System.Drawing.Point(211, 101);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(178, 24);
            this.cmb_Status.TabIndex = 4;
            // 
            // BookCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 433);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.pb_QRBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_BookIDNum);
            this.Controls.Add(this.txt_AccessionNumber);
            this.Controls.Add(this.dtp_DateReceived);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Name = "BookCopy";
            this.Text = "BookCopy";
            this.Load += new System.EventHandler(this.BookCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_QRBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BookIDNum;
        private System.Windows.Forms.TextBox txt_AccessionNumber;
        private System.Windows.Forms.DateTimePicker dtp_DateReceived;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_Status;
    }
}