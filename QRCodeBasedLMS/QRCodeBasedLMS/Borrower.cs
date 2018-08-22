using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QRCodeBasedLMS
{
    public partial class Borrower : Form
    {
        private string qrcode;
        public Borrower(string qr)
        {
            InitializeComponent();
            qrcode = qr;
        }
        dcLMSDataContext db = new dcLMSDataContext();
        clsBorrower brwr = new clsBorrower();
        private void txtBorrowerID_TextChanged(object sender, EventArgs e)
        {
            //generate qr code
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encode.QRCodeScale = 6;
            Bitmap bmp = encode.Encode(txt_BorrowerIDNum.Text);
            pbBorrowerQR.Image = bmp;
        }

        private void Borrower_Load(object sender, EventArgs e)
        {
            dgvBorrower.DataSource = db.sp_ViewBorrower();
            cmb_SearchCategory.Text = "QR Code";
            if(qrcode != "")
            {
                dgvBorrower.DataSource = db.sp_SearchBorrower(cmb_SearchCategory.Text, qrcode);
            }
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_BorrowerIDNum.Text) || string.IsNullOrWhiteSpace(txt_SchoolIDNumber.Text) || string.IsNullOrWhiteSpace(txt_Firstname.Text) || string.IsNullOrWhiteSpace(txt_Lastname.Text) || string.IsNullOrWhiteSpace(txt_Section.Text) || string.IsNullOrWhiteSpace(txt_Address.Text) || string.IsNullOrWhiteSpace(txt_ContactNum.Text))
            {
                MessageBox.Show("Incomplete Information!\nPlease enter values in all of the textboxes.");
            }
            else
            {
                //assigning values to properties in the clsBorrower
                string gender;
                if (rb_Male.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                brwr.BorrowerIDNumber = txt_BorrowerIDNum.Text;
                brwr.SchoolID = txt_SchoolIDNumber.Text;
                brwr.Firstname = txt_Firstname.Text;
                brwr.Lastname = txt_Lastname.Text;
                brwr.Section = txt_Section.Text;
                brwr.Gender = gender;
                brwr.Address = txt_Address.Text;
                brwr.ContactNumber = txt_ContactNum.Text;
                if(btnAddOrUpdate.Text == "ADD")
                {
                    //adding borrowerr
                    brwr.AddRecord();

                    //saving qr code
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            pbBorrowerQR.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                        }
                    }

                    dgvBorrower.DataSource = db.sp_ViewBorrower();
                    MessageBox.Show("Successfully Added!");
                    ClearText();
                }
                else
                {
                    //updating borrower's information
                    brwr.UpdateRecord();
                    dgvBorrower.DataSource = db.sp_ViewBorrower();
                    MessageBox.Show("Successfully Updated!");
                    ClearText();
                    btnAddOrUpdate.Text = "ADD";
                }
                
            }

        }
        public void ClearText()
        {
            txt_BorrowerIDNum.Text = "";
            txt_SchoolIDNumber.Text = "";
            txt_Firstname.Text = "";
            txt_Lastname.Text = "";
            txt_Section.Text = "";
            txt_Address.Text = "";
            txt_ContactNum.Text = "";
            rb_Male.Checked = true;
        }

        
        private void dgvBorrower_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //passing values from dgv to txtboxes
            btnAddOrUpdate.Text = "UPDATE";
            txt_BorrowerIDNum.Text = dgvBorrower.CurrentRow.Cells[0].Value.ToString();
            txt_SchoolIDNumber.Text = dgvBorrower.CurrentRow.Cells[1].Value.ToString();
            txt_Firstname.Text = dgvBorrower.CurrentRow.Cells[2].Value.ToString();
            txt_Lastname.Text = dgvBorrower.CurrentRow.Cells[3].Value.ToString();
            txt_Section.Text = dgvBorrower.CurrentRow.Cells[4].Value.ToString();
            string gender = dgvBorrower.CurrentRow.Cells[5].Value.ToString();
            if(gender == "Male")
            {
                rb_Male.Checked = true;
            }
            else
            {
                rb_Female.Checked = true;
            }
            txt_Address.Text = dgvBorrower.CurrentRow.Cells[6].Value.ToString();
            txt_ContactNum.Text = dgvBorrower.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
            btnAddOrUpdate.Text = "ADD";
        }

        private void cmb_SearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //search
            if(cmb_SearchCategory.Text == "QR Code")
            {
                txt_Search.Visible = false;
                Link_Scan.Visible = true;
            }
            else
            {
                txt_Search.Visible = true;
                Link_Scan.Visible = false;
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            //searching using the lastname and firstname
            dgvBorrower.DataSource = db.sp_SearchBorrower(cmb_SearchCategory.Text, txt_Search.Text);
        }

        

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void Link_Scan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScanQRCode scan = new ScanQRCode("borrower");
            scan.Show();
            this.Close();
        }
    }
}
