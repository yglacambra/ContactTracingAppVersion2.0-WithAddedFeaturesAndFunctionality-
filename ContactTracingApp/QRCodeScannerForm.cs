using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;


namespace ContactTracingApp
{
    public partial class QRCodeScannerForm : Form
    {
        public QRCodeScannerForm()
        {
            InitializeComponent();
        }

        FilterInfoCollection FilterInformationCollection;
        VideoCaptureDevice VidCaptureDevice;
        private void QRCodeScannerForm_Load(object sender, EventArgs e)
        {
            FilterInformationCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo FilterInformation in FilterInformationCollection)
            {
                ComboBoxVideoCaptureDevice.Items.Add(FilterInformation.Name);
            }
            ComboBoxVideoCaptureDevice.SelectedIndex = 0;
        }

        private void BtnStartScan_Click(object sender, EventArgs e)
        {
            VidCaptureDevice = new VideoCaptureDevice(FilterInformationCollection[ComboBoxVideoCaptureDevice.SelectedIndex].MonikerString);
            VidCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VidCaptureDevice.Start();
            QRCodeReadingTimer.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            PictureBoxCameraVideo.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QRCodeScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VidCaptureDevice.IsRunning)
            {
         
            }
        }

        private void QRCodeReadingTimer_Tick(object sender, EventArgs e)
        {
            if (PictureBoxCameraVideo.Image != null)
            {
                BarcodeReader QRCodeReader = new BarcodeReader();
                Result QRCodeResult = QRCodeReader.Decode((Bitmap)PictureBoxCameraVideo.Image);
                if (QRCodeResult != null)
                {
                    QRCodeReadingTimer.Stop();
                    StreamWriter InfoToBeAutoFilledOnTheFormFileWriter;
                    InfoToBeAutoFilledOnTheFormFileWriter = File.AppendText("Information that will be used to fill up the Form automatically.txt");
                    InfoToBeAutoFilledOnTheFormFileWriter.WriteLine(QRCodeResult);
                    InfoToBeAutoFilledOnTheFormFileWriter.Close();
                    File.SetAttributes("Information that will be used to fill up the Form automatically.txt", FileAttributes.Hidden);
                    if (VidCaptureDevice.IsRunning)
                    {
                   
                    }
                    ContactTracingAppForm Form1 = new ContactTracingAppForm();
                    Form1.Visible = true;
                    Form1.ThereIsAResultFromTheQRCodeScannerForm = true;
                    this.Close();
                }
            }
        }
    }
}
