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
                ComboBoxVideoCaptureDevice.Items.Add(FilterInformation.MonikerString);
            }
            ComboBoxVideoCaptureDevice.SelectedIndex = 0;
        }
    }
}
