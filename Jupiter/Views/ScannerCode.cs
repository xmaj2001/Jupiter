using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using ZXing;

namespace Jupiter.Views
{
    public partial class ScannerCode : Form
    {
        private FilterInfoCollection Cameras;
        private VideoCaptureDevice video;
        private BarcodeReader codeBar;
        private int camera = 0;
        public string Code = "";
        private Timer update = new Timer();
        public ScannerCode(int indexCamera)
        {
            InitializeComponent();
            camera = indexCamera;
            iniciarCamera();
        }

        void iniciarCamera()
        {
            try
            {
                Cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                codeBar = new BarcodeReader();
                video = new VideoCaptureDevice(Cameras[camera].MonikerString);
                video.NewFrame += Video_NewFrame;
                update.Tick += Update_Tick;
                update.Start();
                video.Start();
            }
            catch (Exception er)
            {
                MessageBox.Show("Não foi possível ter acesso a câmara: ", er.Message);
            }
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            if(Cam.Image != null)
            {
                var result = codeBar.Decode((Bitmap)Cam.Image);
                if (result != null)
                {
                    Code = result.Text;
                    this.Close();
                }
            }
        }

        private void Video_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Cam.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            video.SignalToStop();
            video.WaitForStop();
            if (video.IsRunning) video.Stop();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (video.IsRunning) video.Stop();
            this.Close();
        }
    }
}
