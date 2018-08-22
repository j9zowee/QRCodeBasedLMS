namespace QRCodeBasedLMS
{
    partial class LibraryUserMasterlist
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
            this.txtEndYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStartYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLibraryUser = new System.Windows.Forms.ComboBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnChoose = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEndYear
            // 
            this.txtEndYear.Enabled = false;
            this.txtEndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndYear.Location = new System.Drawing.Point(225, 47);
            this.txtEndYear.Name = "txtEndYear";
            this.txtEndYear.Size = new System.Drawing.Size(55, 22);
            this.txtEndYear.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "__";
            // 
            // cmbStartYear
            // 
            this.cmbStartYear.FormattingEnabled = true;
            this.cmbStartYear.ItemHeight = 13;
            this.cmbStartYear.Location = new System.Drawing.Point(136, 47);
            this.cmbStartYear.Name = "cmbStartYear";
            this.cmbStartYear.Size = new System.Drawing.Size(55, 21);
            this.cmbStartYear.TabIndex = 28;
            this.cmbStartYear.Leave += new System.EventHandler(this.cmbStartYear_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enter School Year :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Library User :";
            // 
            // cmbLibraryUser
            // 
            this.cmbLibraryUser.FormattingEnabled = true;
            this.cmbLibraryUser.ItemHeight = 13;
            this.cmbLibraryUser.Location = new System.Drawing.Point(136, 10);
            this.cmbLibraryUser.Name = "cmbLibraryUser";
            this.cmbLibraryUser.Size = new System.Drawing.Size(144, 21);
            this.cmbLibraryUser.TabIndex = 32;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 135);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(716, 349);
            this.dgvList.TabIndex = 33;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(11, 92);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(93, 34);
            this.btnChoose.TabIndex = 34;
            this.btnChoose.Text = "CHOOSE FILE";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(110, 98);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(310, 22);
            this.txtFilePath.TabIndex = 35;
            // 
            // LibraryUserMasterlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 496);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.cmbLibraryUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStartYear);
            this.Controls.Add(this.label2);
            this.Name = "LibraryUserMasterlist";
            this.Text = "LibraryUserMasterlist";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEndYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStartYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLibraryUser;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtFilePath;
    }
}