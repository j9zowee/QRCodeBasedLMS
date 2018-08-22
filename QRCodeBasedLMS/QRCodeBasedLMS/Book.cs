﻿using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeBasedLMS
{
    public partial class Book : Form
    {
        private string qrcode;
        public Book(string qr)
        {
            InitializeComponent();
            qrcode = qr;
        }

        dcLMSDataContext db = new dcLMSDataContext();
        clsBook bk = new clsBook();
        private void Book_Load(object sender, EventArgs e)
        {
            dgvBook.DataSource = db.sp_ViewBook();
            cmb_SearchCategory.Text = "QR Code";
            cmb_Status.Text = "Available";
            if (qrcode != "")
            {
                dgvBook.DataSource = db.sp_SearchBook(cmb_SearchCategory.Text, qrcode);
            }
            
        }
        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_BookIDNum.Text) || string.IsNullOrWhiteSpace(txt_Title.Text) || string.IsNullOrWhiteSpace(txt_Pages.Text) || string.IsNullOrWhiteSpace(txt_Publisher.Text) || string.IsNullOrWhiteSpace(txt_CopyrightYear.Text))
            {
                MessageBox.Show("Incomplete Information!\nPlease enter values in textboxes that has (*) indicator.");
            }
            else
            {
                if(bk.CheckValidCopyrightYear() == false)
                {
                    MessageBox.Show("Invalid Copyright Year!");
                }
                else
                {
                    
                    if (btnAddOrUpdate.Text == "ADD")
                    {
                        bk.BookIDNumber = txt_BookIDNum.Text;
                        bk.BookType = cmbBookType.Text;
                        bk.ISBN = txt_ISBN.Text;
                        bk.AccessionNumber = int.Parse(txt_AccessionNumber.Text);
                        bk.CallNumber = txt_CallNumber.Text;
                        bk.DateReceived = DateTime.Parse(dtp_DateReceived.Text);
                        bk.Title = txt_Title.Text;
                        bk.Author = txt_Author.Text;
                        bk.Publisher = txt_Publisher.Text;
                        bk.CopyrightYear = int.Parse(txt_CopyrightYear.Text);
                        bk.Edition = txt_Edition.Text;
                        bk.Volume = txt_Volume.Text;
                        bk.Pages = int.Parse(txt_Pages.Text);
                        bk.Status = cmb_Status.Text;
                        bk.Remarks = txt_Remarks.Text;
                        bk.AddRecord();
                        using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
                        {
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                pb_QRBook.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                            }
                        }
                        dgvBook.DataSource = db.sp_ViewBook(); ;
                        MessageBox.Show("Sucessfully Added!");
                        ClearText();
                        EnableTextboxes();
                    }
                    else
                    {
                        BookCopy bc = new BookCopy(txt_BookIDNum.Text);
                        bc.Show();
                        this.Hide();
                    }
                }
                
            }
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddOrUpdate.Text = "ADD COPY";
            DisableTextboxes();
            gb_Copy.Visible = false;
            txt_BookIDNum.Text = dgvBook.CurrentRow.Cells[0].Value.ToString();
            cmbBookType.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
            txt_ISBN.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
            txt_CallNumber.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
            txt_Title.Text = dgvBook.CurrentRow.Cells[4].Value.ToString();
            txt_Author.Text = dgvBook.CurrentRow.Cells[5].Value.ToString();
            txt_Publisher.Text = dgvBook.CurrentRow.Cells[6].Value.ToString();
            txt_CopyrightYear.Text = dgvBook.CurrentRow.Cells[7].Value.ToString();
            txt_Edition.Text = dgvBook.CurrentRow.Cells[8].Value.ToString();
            txt_Volume.Text = dgvBook.CurrentRow.Cells[9].Value.ToString();
            txt_Pages.Text = dgvBook.CurrentRow.Cells[10].Value.ToString();
            txt_Remarks.Text = dgvBook.CurrentRow.Cells[11].Value.ToString();

            lbl_NumCopies.Visible = true;
            lbl_NumCopies.Text = "Total No. of Copies : " +db.sp_TotalBookCopy(txt_BookIDNum.Text).Count().ToString();
        }
        public void DisableTextboxes()
        {
            txt_BookIDNum.Enabled = false;
            cmbBookType.Enabled = false;
            txt_ISBN.Enabled = false;
            txt_CallNumber.Enabled = false;
            txt_AccessionNumber.Enabled = false;
            dtp_DateReceived.Enabled = false;
            txt_Title.Enabled = false;
            txt_Author.Enabled = false;
            txt_Publisher.Enabled = false;
            txt_CopyrightYear.Enabled = false;
            txt_Edition.Enabled = false;
            txt_Volume.Enabled = false;
            txt_Pages.Enabled = false;
            cmb_Status.Enabled = false;
            txt_Remarks.Enabled = false;
        }
        public void EnableTextboxes()
        {
            txt_BookIDNum.Enabled = true;
            cmbBookType.Enabled = true;
            txt_ISBN.Enabled = true;
            txt_CallNumber.Enabled = true;
            txt_AccessionNumber.Enabled = true;
            dtp_DateReceived.Enabled = true;
            txt_Title.Enabled = true;
            txt_Author.Enabled = true;
            txt_Publisher.Enabled = true;
            txt_CopyrightYear.Enabled = true;
            txt_Edition.Enabled = true;
            txt_Volume.Enabled = true;
            txt_Pages.Enabled = true;
            cmb_Status.Enabled = true;
            txt_Remarks.Enabled = true;
        }
        private void txt_BookIDNum_TextChanged(object sender, EventArgs e)
        {
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encode.QRCodeScale = 6;
            Bitmap bmp = encode.Encode(txt_BookIDNum.Text);
            pb_QRBook.Image = bmp;
        }

        public void ClearText()
        {
            txt_BookIDNum.Text = "";
            txt_ISBN.Text = "";
            txt_AccessionNumber.Text = "";
            txt_CallNumber.Text = "";
            txt_Title.Text = "";
            txt_Author.Text = "";
            txt_Publisher.Text = "";
            txt_CopyrightYear.Text = "";
            txt_Edition.Text = "";
            txt_Volume.Text = "";
            txt_Pages.Text = "";
            cmb_Status.Text = "";
            txt_Remarks.Text = "";
            btnAddOrUpdate.Text = "ADD";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableTextboxes();
            gb_Copy.Visible = true;
            lbl_NumCopies.Visible = false;
            dgvBook.DataSource = db.sp_ViewBook();
        }

        private void cmb_SearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_SearchCategory.Text == "QR Code")
            {
                Link_Scan.Visible = true;
                txt_Search.Visible = false;
            }
            else
            {
                txt_Search.Visible = true;
                Link_Scan.Visible = false;
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            dgvBook.DataSource = db.sp_SearchBook(cmb_SearchCategory.Text, txt_Search.Text);
        }

        private void txt_AccessionNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CopyrightYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_CopyrightYear.MaxLength = 4;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void txt_Pages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.Show();
            this.Hide();
        }

        

        private void Link_Scan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScanQRCode scan = new ScanQRCode("book");
            scan.Show();
            this.Close();
        }

        
    }
}
