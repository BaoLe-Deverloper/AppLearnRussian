using AppLearnRussian;
using ControlLibrary;
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
    public partial class ChooseLever : Form
    {
        public EventHandler Load_test;
        private Point mouselocation;
        string Lever;
        int Number;
        public ChooseLever()
        {
            InitializeComponent();
        }

        private static  ChooseLever instance;
        public static ChooseLever Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChooseLever();
                return instance;
            }
            private set { instance = value; }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btn_Lever_click(object sender, EventArgs e)
        {
            Lever = ((CustomImageButton)sender).Tag.ToString();
            lbLever.Text = "Lever " + Lever;
        }

        private void btn_Number_click(object sender, EventArgs e)
        {
            Number = int.Parse(((CustomImageButton)sender).Tag.ToString());
            lbNumber.Text = Number.ToString() + " Câu";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (Lever != "" && Number != 0)
            {
                DialogResult result = MessageBox.Show("Bạn đã chọn lever " + Lever + " và " + Number.ToString() + " Câu hỏi", "Thông báo Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {

                    infoTest.Lever = Lever;
                    infoTest.NumberQuestions = Number;
                    Load_test(this, EventArgs.Empty);
                    lbLever.Text = "Lever ";
                    lbNumber.Text = "Số Câu";
                    this.Close();
                }
                else
                    return;
            }
            else
                MessageBox.Show("Bạn chưa chọn các mục trên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ChooseLever_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.Ver_positive);
          
             
        }

        private void ChooseLever_MouseDown(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y);
        }

        private void ChooseLever_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousepose = Control.MousePosition;
                mousepose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousepose;

            }
        }
    }
}
