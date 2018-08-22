using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace QRCodeBasedLMS
{
    public partial class Borrow : Form
    {
        
        public Borrow()
        {
            InitializeComponent();
           
        }
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        dcLMSDataContext db = new dcLMSDataContext();

        
        private void Borrow_Load(object sender, EventArgs e)
        {
            
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cmbDevice.Items.Add(Device.Name);
            }
            cmbDevice.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            btnCamera.Visible = false;

            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            
        }
        private void FinalFrame_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            pb_ScanQR.Image = (Image)eventArgs.Frame.Clone();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pb_ScanQR.Image);
            try
            {
                string decoded = result.ToString().Trim();
                if (txt_BorrowerID.Text == "")
                {
                    if (decoded != "")
                    {
                        timer.Stop();
                        txt_BorrowerID.Text = decoded;
                        MessageBox.Show("Successfully Scanned!");
                    }
                }
                else
                {
                    if (decoded != "")
                    {
                        timer.Stop();
                        txt_BookIDNum.Text = decoded;
                        MessageBox.Show("Success besh!");
                        string borrowIDNumber = "12345";
                        DateTime dt = DateTime.Now;
                        DateTime due = dt.AddDays(3);
                        DialogResult res = MessageBox.Show("CONFIRM:\nDo you want to borrow " + txt_BookIDNum.Text + "?", "Borrow Book", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            db.sp_BorrowBook(borrowIDNumber, txt_BorrowerID.Text, txt_BookIDNum.Text, dt, due);
                            MessageBox.Show("Successully Borrowed!");
                            
                            IndexForm index = new IndexForm();
                            index.Show();
                            this.Close();
                        }
                        else
                        {
                            IndexForm index = new IndexForm();
                            index.Show();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            
            timer.Enabled = true;
            timer.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to cancel borrowing a book? ", "Borrow Book", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                IndexForm index = new IndexForm();
                index.Show();
                this.Close();
            }
            else
            {
                Borrow br = new Borrow();
                br.Show();
                this.Close();
            }
        }

        private void Borrow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            btnCamera.Visible = false;
        }

        private void cmbDevice_TextChanged(object sender, EventArgs e)
        {
            btnCamera.Visible = true;
        }
    }
}
