namespace QRCodeBasedLMS
{
    partial class MainForm
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
            this.ms_Mainform = new System.Windows.Forms.MenuStrip();
            this.mASTERFILESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUpdateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nonReadingMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUpdateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERACCOUNTSMANAGERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistrationToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.unapprovedAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherUserAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unapprovedUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSACTIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Mainform.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Mainform
            // 
            this.ms_Mainform.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_Mainform.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mASTERFILESToolStripMenuItem,
            this.uSERACCOUNTSMANAGERToolStripMenuItem,
            this.tRANSACTIONSToolStripMenuItem,
            this.rEPORTSToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.ms_Mainform.Location = new System.Drawing.Point(0, 0);
            this.ms_Mainform.Name = "ms_Mainform";
            this.ms_Mainform.Size = new System.Drawing.Size(1350, 25);
            this.ms_Mainform.TabIndex = 0;
            this.ms_Mainform.Text = "menuStrip1";
            // 
            // mASTERFILESToolStripMenuItem
            // 
            this.mASTERFILESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.borrowersToolStripMenuItem,
            this.nonReadingMaterialsToolStripMenuItem,
            this.libraryUsersToolStripMenuItem});
            this.mASTERFILESToolStripMenuItem.Name = "mASTERFILESToolStripMenuItem";
            this.mASTERFILESToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.mASTERFILESToolStripMenuItem.Text = "MASTERFILES";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUpdateToolStripMenuItem,
            this.updateBookInformationToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // addUpdateToolStripMenuItem
            // 
            this.addUpdateToolStripMenuItem.Name = "addUpdateToolStripMenuItem";
            this.addUpdateToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.addUpdateToolStripMenuItem.Text = "Add Book";
            this.addUpdateToolStripMenuItem.Click += new System.EventHandler(this.addUpdateToolStripMenuItem_Click);
            // 
            // updateBookInformationToolStripMenuItem
            // 
            this.updateBookInformationToolStripMenuItem.Name = "updateBookInformationToolStripMenuItem";
            this.updateBookInformationToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.updateBookInformationToolStripMenuItem.Text = "Update Book Information";
            this.updateBookInformationToolStripMenuItem.Click += new System.EventHandler(this.updateBookInformationToolStripMenuItem_Click);
            // 
            // borrowersToolStripMenuItem
            // 
            this.borrowersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUpdateToolStripMenuItem1});
            this.borrowersToolStripMenuItem.Name = "borrowersToolStripMenuItem";
            this.borrowersToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.borrowersToolStripMenuItem.Text = "Borrowers";
            // 
            // addUpdateToolStripMenuItem1
            // 
            this.addUpdateToolStripMenuItem1.Name = "addUpdateToolStripMenuItem1";
            this.addUpdateToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.addUpdateToolStripMenuItem1.Text = "Add/Update Borrower";
            this.addUpdateToolStripMenuItem1.Click += new System.EventHandler(this.addUpdateToolStripMenuItem1_Click);
            // 
            // nonReadingMaterialsToolStripMenuItem
            // 
            this.nonReadingMaterialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUpdateToolStripMenuItem2});
            this.nonReadingMaterialsToolStripMenuItem.Name = "nonReadingMaterialsToolStripMenuItem";
            this.nonReadingMaterialsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.nonReadingMaterialsToolStripMenuItem.Text = "Non-Reading Materials";
            // 
            // addUpdateToolStripMenuItem2
            // 
            this.addUpdateToolStripMenuItem2.Name = "addUpdateToolStripMenuItem2";
            this.addUpdateToolStripMenuItem2.Size = new System.Drawing.Size(151, 22);
            this.addUpdateToolStripMenuItem2.Text = "Add/Update";
            // 
            // libraryUsersToolStripMenuItem
            // 
            this.libraryUsersToolStripMenuItem.Name = "libraryUsersToolStripMenuItem";
            this.libraryUsersToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.libraryUsersToolStripMenuItem.Text = "Library Users";
            this.libraryUsersToolStripMenuItem.Click += new System.EventHandler(this.libraryUsersToolStripMenuItem_Click);
            // 
            // uSERACCOUNTSMANAGERToolStripMenuItem
            // 
            this.uSERACCOUNTSMANAGERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistrationToolStripMenu,
            this.unapprovedAccountsToolStripMenuItem,
            this.unapprovedUsersToolStripMenuItem});
            this.uSERACCOUNTSMANAGERToolStripMenuItem.Name = "uSERACCOUNTSMANAGERToolStripMenuItem";
            this.uSERACCOUNTSMANAGERToolStripMenuItem.Size = new System.Drawing.Size(161, 21);
            this.uSERACCOUNTSMANAGERToolStripMenuItem.Text = "ACCOUNTS MANAGER";
            // 
            // RegistrationToolStripMenu
            // 
            this.RegistrationToolStripMenu.Name = "RegistrationToolStripMenu";
            this.RegistrationToolStripMenu.Size = new System.Drawing.Size(189, 22);
            this.RegistrationToolStripMenu.Text = "Registration";
            this.RegistrationToolStripMenu.Click += new System.EventHandler(this.RegistrationToolStripMenu_Click);
            // 
            // unapprovedAccountsToolStripMenuItem
            // 
            this.unapprovedAccountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myInformationToolStripMenuItem,
            this.otherUserAccountsToolStripMenuItem});
            this.unapprovedAccountsToolStripMenuItem.Name = "unapprovedAccountsToolStripMenuItem";
            this.unapprovedAccountsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.unapprovedAccountsToolStripMenuItem.Text = "User Information";
            // 
            // myInformationToolStripMenuItem
            // 
            this.myInformationToolStripMenuItem.Name = "myInformationToolStripMenuItem";
            this.myInformationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.myInformationToolStripMenuItem.Text = "My Information";
            // 
            // otherUserAccountsToolStripMenuItem
            // 
            this.otherUserAccountsToolStripMenuItem.Name = "otherUserAccountsToolStripMenuItem";
            this.otherUserAccountsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.otherUserAccountsToolStripMenuItem.Text = "Other User Accounts";
            this.otherUserAccountsToolStripMenuItem.Click += new System.EventHandler(this.otherUserAccountsToolStripMenuItem_Click);
            // 
            // unapprovedUsersToolStripMenuItem
            // 
            this.unapprovedUsersToolStripMenuItem.Name = "unapprovedUsersToolStripMenuItem";
            this.unapprovedUsersToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.unapprovedUsersToolStripMenuItem.Text = "Unapproved Users";
            this.unapprovedUsersToolStripMenuItem.Click += new System.EventHandler(this.unapprovedUsersToolStripMenuItem_Click);
            // 
            // tRANSACTIONSToolStripMenuItem
            // 
            this.tRANSACTIONSToolStripMenuItem.Name = "tRANSACTIONSToolStripMenuItem";
            this.tRANSACTIONSToolStripMenuItem.Size = new System.Drawing.Size(118, 21);
            this.tRANSACTIONSToolStripMenuItem.Text = "TRANSACTIONS";
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.rEPORTSToolStripMenuItem.Text = "REPORTS";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.ms_Mainform);
            this.MainMenuStrip = this.ms_Mainform;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ms_Mainform.ResumeLayout(false);
            this.ms_Mainform.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Mainform;
        private System.Windows.Forms.ToolStripMenuItem mASTERFILESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUpdateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nonReadingMaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUpdateToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem uSERACCOUNTSMANAGERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSACTIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistrationToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem unapprovedAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherUserAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unapprovedUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryUsersToolStripMenuItem;
    }
}