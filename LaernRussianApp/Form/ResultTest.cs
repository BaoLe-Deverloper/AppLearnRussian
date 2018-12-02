using LaernRussianApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLearnRussian
{
    public partial class ResultTest : Form
    {
        public delegate void Handler_Uctest();
        public Handler_Uctest close_test;
        public Handler_Uctest new_test;
        private int NumberAnswers;
        public Point mouselocation;
        private int NumberAnswerTrue;
        public ResultTest()
        {
            InitializeComponent();
        }

        public static ResultTest instance;
        public static ResultTest Instance
        {
            get
            {
                if (instance == null)
                    instance = new ResultTest();
                return instance;
            }
            private set { instance = value; }
        }

        public int NumberAnswers1 { get => NumberAnswers; set => NumberAnswers = value; }
        public int NumberAnswerTrue1 { get => NumberAnswerTrue; set => NumberAnswerTrue = value; }

        private void ResultTest_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.Ver_positive);
            this.Visible = true;
            int NumberAnswerFalse = NumberAnswers1 - NumberAnswerTrue;

            float percent = ((float)NumberAnswerTrue / (float)NumberAnswers1);

            if (percent < 0.65 && percent >= 0)
            {
               
                pbPoint.Image = Image.FromFile("Image/so2.jpg");
            }
            if ( percent < 0.75 && percent >= 0.65)
            {
               
                pbPoint.Image = Image.FromFile("Image/so3.jpg");
            }
            if (percent < 0.90 && percent >= 0.75)
            {
              
                pbPoint.Image = Image.FromFile("Image/so4.jpg");
            }
            if (percent >= 0.90 )
            {
            
                pbPoint.Image = Image.FromFile("Image/so5.jpg");
            }

            txtNumber.Text = NumberAnswers1.ToString();
            txtNumberAnswersTrue.Text = NumberAnswerTrue.ToString();
            txtNumberAnswersFalse.Text = NumberAnswerFalse.ToString();

        }

      
        private void customImageButton3_Click(object sender, EventArgs e)
        {
            close_test();
            this.Close();
        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousePose;
            }
        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            UcQuestions.instance = null;
            this.Visible = false;
            ChooseLever choose = ChooseLever.Instance;
            choose.ShowDialog();
            this.Close();
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            new_test();
            this.Close();
        }
    }
}
