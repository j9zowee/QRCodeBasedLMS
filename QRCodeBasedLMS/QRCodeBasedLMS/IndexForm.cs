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
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void link_SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Borrow sbi = new Borrow();
            sbi.Show();
            this.Hide();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void link_Attendance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AttendanceMonitoring am = new AttendanceMonitoring();
            am.Show();
            this.Hide();
        }
    }
}