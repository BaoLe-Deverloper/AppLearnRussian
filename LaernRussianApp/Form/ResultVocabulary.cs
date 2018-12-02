using AppLearnRussian;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaernRussianApp
{
    public partial class ResultVocabulary : Form
    {
        public ResultVocabulary()
        {
            InitializeComponent();
        }
        public  bool res;
        private static ResultVocabulary instance;
        public static ResultVocabulary Instance
        {
            get
            {
                if (instance == null)
                    instance = new ResultVocabulary();
                return instance;
            }
            private set { instance = value; }
        }

        public bool Res { get => res; set => res = value; }

        private Point mouselocation;
        private void ResultVocabulary_MouseDown(object sender, MouseEventArgs e)
        {mouselocation = new Point(-e.X, -e.Y);

        }

        private void ResultVocabulary_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousePose;

            }
        }

        private void ResultVocabulary_Load(object sender, EventArgs e)
        {
            if (Res==true)
            {
                label1.Text = "Bạn đúng rồi";

            }
            else label1.Text = "Bạn sai rồi";
            label2.Text = DataInfoUser.Point.ToString();
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            if (res == true)
            {
               
            }
            this.Close();
        }
    }
}
