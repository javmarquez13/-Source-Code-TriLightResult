using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace TriLightResult
{
    public partial class Form1 : Form
    {
        string _triLightFeat;
        string _tracer;
        string _Step;
        string _Status;
        string _PixelCount;
        string _Flag;

        Image _blueRef;
        Image _BlackRef;
        Image _WhiteRef;
        Image _GreenRef;
        Image _NoLabelRef;
        Image _NoLabelCamRef;

        public Form1(string[] Args)
        {
            InitializeComponent();

            if(Args[1] == "ModifyImage")
            {
                ModifyImageReso();
                return;
            }

            _tracer = Args[1];
            _triLightFeat = Args[2];            
            _Step = Args[3];
            _Status = Args[4];
            _PixelCount = Args[5];

            try
            {
                _Flag = Args[6];
            }
            catch(Exception ex)
            {

            }
            
        }

        void ModifyImageReso()
        {
            Image image = Image.FromFile(@"C:\Images\Debug\Test.png");
            Bitmap bitmap = new Bitmap(image, new Size(1080, 720));
            bitmap.Save(@"C:\Images\Debug\Test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            Environment.Exit(0);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icono__1_;
            //this.DesktopLocation = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height); //970, 522
            this.DesktopLocation = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0); //970, 522

            lblResult.Text = string.Empty;
            lblTracer.Text = string.Empty;

            pBoxImgRef.SizeMode = PictureBoxSizeMode.StretchImage;

            if (_Step.Contains("Pixel"))
            {
                if (_triLightFeat == "Blue") pBoxImgRef.Image = Properties.Resources.BlueBox;
                if (_triLightFeat == "Black") pBoxImgRef.Image = Properties.Resources.BlackBox;
                if (_triLightFeat == "White") pBoxImgRef.Image = Properties.Resources.WhiteBox;
                if (_triLightFeat == "Green") pBoxImgRef.Image = Properties.Resources.GreenBox;
                if (_triLightFeat == "NoLabel") pBoxImgRef.Image = Properties.Resources.NoLabelBox;
                lblValue.Text = "Pixel count:";
            }
         

            if (_Step.Contains("Pos"))
            {
                if (_Step == "SA-Pos" && _triLightFeat == "Blue")
                {
                    _blueRef = Image.FromFile(@"C:\Images\References\Blue\blueA.jpg");
                }            
                if (_Step == "SB-Pos" && _triLightFeat == "Blue")
                {
                    _blueRef = Image.FromFile(@"C:\Images\References\Blue\blueB.jpg");
                }

                if (_Step == "SA-Pos" && _triLightFeat == "Green")
                {
                    _GreenRef = Image.FromFile(@"C:\Images\References\Green\GreenA.jpg");
                }
                if (_Step == "SB-Pos" && _triLightFeat == "Green")
                {
                    _GreenRef = Image.FromFile(@"C:\Images\References\Green\GreenB.jpg");
                }

                if (_Step == "SA-Pos" && _triLightFeat == "White")
                {
                    _WhiteRef = Image.FromFile(@"C:\Images\References\White\WhiteA.jpg");
                }
                if (_Step == "SB-Pos" && _triLightFeat == "White")
                {
                    _WhiteRef = Image.FromFile(@"C:\Images\References\White\WhiteB.jpg");
                }

                if (_Step == "SA-Pos" && _triLightFeat == "Black")
                {
                    _BlackRef = Image.FromFile(@"C:\Images\References\Black\blackA.jpg");
                }
                if (_Step == "SB-Pos" && _triLightFeat == "Black")
                {
                    _BlackRef = Image.FromFile(@"C:\Images\References\Black\blackB.jpg");
                }

                if (_Step == "SA-Pos" && _triLightFeat == "NoLabel")
                {
                    _NoLabelRef = Image.FromFile(@"C:\Images\References\NoLabel\NoLabelA.jpg");
                }

                if (_Step == "SA-Pos" && _triLightFeat == "NoLabelCam")
                {
                    _NoLabelCamRef = Image.FromFile(@"C:\Images\References\NoLabelCam\NoLabelCamA.jpg");
                }


                if (_triLightFeat == "Blue") pBoxImgRef.Image = _blueRef;
                if (_triLightFeat == "Black") pBoxImgRef.Image = _BlackRef;
                if (_triLightFeat == "White") pBoxImgRef.Image = _WhiteRef;
                if (_triLightFeat == "Green") pBoxImgRef.Image = _GreenRef;
                if (_triLightFeat == "NoLabel") pBoxImgRef.Image = _NoLabelRef;
                if (_triLightFeat == "NoLabelCam") pBoxImgRef.Image = _NoLabelCamRef;

                lblValue.Text = "Confidence value:";
            }

            if (_Step.Contains("Box"))
            {
                if (_triLightFeat == "Blue") pBoxImgRef.Image = Properties.Resources.BlueBox;
                if (_triLightFeat == "Black") pBoxImgRef.Image = Properties.Resources.BlackBox;
                if (_triLightFeat == "White") pBoxImgRef.Image = Properties.Resources.WhiteBox;
                if (_triLightFeat == "Green") pBoxImgRef.Image = Properties.Resources.GreenBox;
                if (_triLightFeat == "NoLabel") pBoxImgRef.Image = Properties.Resources.NoLabelBox;

                lblValue.Text = "Pixel count:";
            }


            if (_Status == "FAIL")
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "FAIL";
                lblTracer.Text = _tracer;
            }
            if (_Status == "PASS")
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = "PASS";
                lblTracer.Text = _tracer;
            }

            lblPixelCount.Text = _PixelCount;

            Image img_Eva = Image.FromFile(@"C:\Images\Debug\Test.jpg");
            pBoxImgEvaluation.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxImgEvaluation.Image = img_Eva;

            this.Refresh();
            this.Update();
        }

        void SaveEvidence(string TRACER, string STEP)
        {           
            string _pathResult = @"C:\Images\Pass\" + DateTime.Now.ToString("MM_yyyy_dd") + @"\" + DateTime.Now.ToString("HH") + @"\" + TRACER +  @"\";

            DirectoryInfo DirInfo = new DirectoryInfo(_pathResult);
            if (!DirInfo.Exists)
            {
                DirInfo.Create();
            }


            Bitmap bmp = new Bitmap(this.Width, this.Height);
            DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            bmp.Save(_pathResult + TRACER + "_" + STEP + "_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".png");          
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Refresh();

            if (_Flag == "Save")
            {
                SaveEvidence(_tracer, _Step);
            }
            
        }
    }
}
