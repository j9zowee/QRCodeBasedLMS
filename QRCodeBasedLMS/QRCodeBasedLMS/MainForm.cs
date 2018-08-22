﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeBasedLMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book bk = new Book("");
            bk.Show();
            this.Hide();
        }

        private void addUpdateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Borrower brw = new Borrower("");
            brw.Show();
            this.Hide();
        }

        private void RegistrationToolStripMenu_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndexForm index = new IndexForm();
            index.Show();
            this.Hide();
        }

        private void updateBookInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBookInfo upbk = new UpdateBookInfo();
            upbk.Show();
            this.Hide();
        }

        
        private void unapprovedUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnapprovedAccounts ua = new UnapprovedAccounts("");
            ua.Show();
            this.Hide();
        }

        private void otherUserAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInformation ui = new UserInformation("");
            ui.Show();
            this.Hide();
        }

        private void libraryUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibraryUserMasterlist lum = new LibraryUserMasterlist();
            lum.Show();
        }
    }
}
