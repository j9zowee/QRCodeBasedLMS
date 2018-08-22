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
    public partial class AttendanceMonitoring : Form
    {
        public AttendanceMonitoring()
        {
            InitializeComponent();
        }
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        dcLMSDataContext db = new dcLMSDataContext();
        
        private void AttendanceMonitoring_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var fname = (from s in db.tblLibraryUsers
                         where s.lib_SchoolID == txt_SchoolID.Text
                         select s.lib_Firstname).FirstOrDefault();
            var lname = (from s in db.tblLibraryUsers
                         where s.lib_SchoolID == txt_SchoolID.Text
                         select s.lib_Lastname).FirstOrDefault();
            
            if (fname != null && lname != null)
            {
                txt_Name.Text = lname + ", " + fname;
                MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                encode.QRCodeScale = 6;
                Bitmap bmp = encode.Encode(txt_SchoolID.Text);
                pb_ScanQR.Image = bmp;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            db.sp_Attendance(txt_SchoolID.Text, txt_Name.Text, dt);
            txt_SchoolID.Clear();
            txt_Name.Clear();
        }
        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IndexForm index = new IndexForm();
            index.Show();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pb_ScanQR.Image);
            try
            {
                string decoded = result.ToString().Trim();
                if (decoded != "")
                {
                    timer.Stop();
                    txt_SchoolID.Text = decoded;
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

        private void AttendanceMonitoring_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
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
