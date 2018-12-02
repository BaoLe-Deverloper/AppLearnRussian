using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
using MaterialSkin.Animations;
using System.Threading;
using AppLearnRussian.UserControls;
using AppLearnRussian.Resources.BLL;
using LaernRussianApp;

namespace AppLearnRussian
{

    public partial class Main : CheckUser

    {

      
        public static string usernamelogin;

        public Point mouselocation;

        public Main()
        {

            Thread t = new Thread(new ThreadStart(load));
            t.Start();
            Thread.Sleep(3000);
            this.Enabled = false;
            InitializeComponent();
            t.Abort();
        }

        void load()
        {
            Application.Run(new FormLoad());
        }
        #region AppMouseMove

        private void customImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y);
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousePose;
            }
        }


        #endregion

        #region Load Form
        /// <summary>
        /// Event Load UcAddQuestion
        /// </summary>


        private void Load_test(object sender, EventArgs e)
        {
            ///

            ////Load test
            UcQuestions test = UcQuestions.Instance;
           
            pnlMain.Controls.Clear();
            panelDockL.Visible = false;
            pnlMain.Controls.Add(panelDockL);
            pnlMain.Visible = false;
            pnlMain.Controls.Add(test);
            pnlMain.Visible = true;

        }
        private void new_test()
        {
            UcQuestions.instance = null;
            Load_test(this, EventArgs.Empty);
        }

        private void close_UcQuestion()
        {
            btnhomen_Click(this, EventArgs.Empty);
            infoTest.Lever = "";
            infoTest.NumberQuestions = 0;

            UcQuestions.instance = null;
        }

        private void Start_Game1(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            panelDockL.Visible = false;
            pnlMain.Controls.Add(panelDockL);
            pnlMain.Visible = false;
           
            pnlMain.Visible = true;
        }
        private void Main_Load(object sender, EventArgs e)

        {

            XmlBLL xmlBLL = new XmlBLL();
            xmlBLL.GetSysteminfo();
            if(Systeminfo.Status == true)
            {
               
                Mp3Player.open(Systeminfo.FileNameSound);
                Mp3Player.Volume(100);
                Mp3Player.play(); 
              
            }
           

            // Subscribe Event //Event registration
            choose.Load_test += Load_test;
            btnLogout.Click += btnhomen_Click;
            ResultTest.Instance.close_test += close_UcQuestion;
            ResultTest.Instance.new_test += new_test;

            try
            {
                if (!String.IsNullOrEmpty(DataInfoUser.usernamelogin))
                {
                    txtUsername.Text = DataInfoUser.usernamelogin;

                    pBUser.Image = DataInfoUser.imguser;
                }
                else
                {
                    txtUsername.Text = "NoUser";
                    btnLogout.Visible = false;
                    btnLogin.Visible = true;
                }
            }

            catch (Exception)
            {

            }
            if (DataInfoUser.Admin == true)
            {
                btnAdmin.Visible = true;
                txtUsername.ForeColor = Color.Red;
            }
            else txtUsername.ForeColor = Color.DarkBlue;
          
            checkuser();
            this.TopMost = false;
            this.Enabled= true;
        }


        void checkuser()
        {
            if(String.IsNullOrEmpty(DataInfoUser.usernamelogin))
            {
                btnVocabulary.Enabled = false;
                btnInfo.Enabled = false;
                btnTest.Enabled = false;
                btnbook.Enabled = false;
                lbMessage.Text = "Hãy Đăng nhập hoặc Đăng Kí để sử dụng những chức năng đang bị khóa";
                
            }
            else
            {
                btnVocabulary.Enabled = true;
                btnInfo.Enabled = true;
                btnTest.Enabled = true;
                btnbook.Enabled = true;
                lbMessage.Text = "";
            }
        }

        #endregion

        #region Login sigup windowstate

        /// <summary>
        /// ///////////////////
        /// </summary>




        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion

        #region Menu Chính

       
        /// <summary>
        /// Button Info
        /// </summary>
        /// 

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (panelDockL.Visible == true)
                panelDockL.Visible = false;
            else
            {
                panelDockL.Visible = true;
                panelDockL.BringToFront();
            }
        }

        private void btnhomen_Click(object sender, EventArgs e)
        {

            panelleft.Height = btnhomen.Height;
            panelleft.Top = btnhomen.Top;
            pnlMain.Controls.Clear();
            panelDockL.Visible = false;
            pnlMain.Controls.Add(pnlBackGroud);
            pnlMain.Controls.Add(panelDockL);

        }


        private void btnInfo_Click(object sender, EventArgs e)
        {

            panelleft.Height = btnInfo.Height;
            panelleft.Top = btnInfo.Top;

            UcInfomation information = new UcInfomation();
            information.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            panelDockL.Visible = false;
            pnlMain.Controls.Add(panelDockL);

            pnlMain.Controls.Add(information);
        }
  
        ChooseLever choose = ChooseLever.Instance;
        private void btnTest_Click(object sender, EventArgs e)
        {



            if (infoTest.Lever != "" && infoTest.NumberQuestions != 0)
            {
                Load_test(this, EventArgs.Empty);
            }
            else
            {
                panelDockL.Visible = false;
              
                choose.ShowDialog();
                panelleft.Height = btnTest.Height;
                panelleft.Top = btnTest.Top;
            }

        }

        private void btnbook_Click(object sender, EventArgs e)
        {

            UcBook ucBook = new UcBook();

            pnlMain.Controls.Clear();
            panelDockL.Visible = false;
            pnlMain.Controls.Add(ucBook);
            pnlMain.Controls.Add(panelDockL);

            panelleft.Height = btnbook.Height;
            panelleft.Top = btnbook.Top;
        }

        /// <summary>
        /// Button Setting
        /// </summary>

        private void btnSetting_Click(object sender, EventArgs e)
        {

            
           
            panelDockL.Visible = false;
           
            panelleft.Height = btnSetting.Height;
            panelleft.Top = btnSetting.Top;
            Sound sound = Sound.Instance;
            sound.ShowDialog();

        }
        private void btnVocabulary_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            UcVocabulary.Instance.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(UcVocabulary.Instance);
            pnlMain.Controls.Clear();
            panelDockL.Visible = false;
            pnlMain.Controls.Add(UcVocabulary.Instance);
            pnlMain.Controls.Add(panelDockL);
            panelleft.Height = btnVocabulary.Height;
            panelleft.Top = btnVocabulary.Top;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            UcAdmin UcAdmin = new UcAdmin();
            UcAdmin.Dock = DockStyle.Fill;

            pnlMain.Controls.Clear();
            panelDockL.Visible = false;
            pnlMain.Controls.Add(panelDockL);
            pnlMain.Visible = false;
            pnlMain.Controls.Add(UcAdmin);
            pnlMain.Visible = true;
            panelleft.Height = btnAdmin.Height;
            panelleft.Top = btnAdmin.Top;
        }
        private async void btninternet_Click(object sender, EventArgs e)
        {
            Mp3Player.Pause();
            Systeminfo.Status = false;
            Ucinternet ucinternet =  Ucinternet.Instance;
            pnlMain.Controls.Clear();
            panelDockL.Visible = false;
            pnlMain.Controls.Add(panelDockL);
            pnlMain.Visible = false;
            pnlMain.Controls.Add(ucinternet);
            pnlMain.Visible = true;
            panelleft.Height = btninternet.Height;
            panelleft.Top = btninternet.Top;

        }
        #endregion

        #region Link Liên kết
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Https://Facebook.com/baole15081998");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Https://baolehvpkkq@gmail.com");
        }

        private void customImageButton4_Click(object sender, EventArgs e)
        {
            Process.Start("Https://Facebook.com/baole15081998");
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/id466006992");
        }









        #endregion



        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.ShowDialog();
            if (!string.IsNullOrEmpty(DataInfoUser.usernamelogin))
            {
                this.txtUsername.Text = DataInfoUser.usernamelogin;
                btnLogout.Visible = true;
                btnLogin.Visible = false;
                if (DataInfoUser.Admin == true)
                {
                    btnAdmin.Visible = true;
                    txtUsername.ForeColor = Color.Red;
                }
                else
                {
                    btnAdmin.Visible = false;
                    txtUsername.ForeColor = Color.DarkBlue;
                }


            }

            if (DataInfoUser.imguser != null)
                pBUser.Image = DataInfoUser.imguser;
            checkuser();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            btnLogout.Visible = false;
            btnLogin.Visible = true;
            btnAdmin.Visible = false;
            XmlBLL xmlBLL = new XmlBLL();
            User user = new User();
            user.UserName1 = DataInfoUser.usernamelogin;
            xmlBLL.ForgetUser(user);
            DataInfoUser.usernamelogin = null;
            DataInfoUser.Lever = null;
            DataInfoUser.imguser = null;
            DataInfoUser.date = new DateTime();
            checkuser();
            DataInfoUser.Email = null;
            DataInfoUser.Remember = false;
            this.txtUsername.Text = "No UserName";
            pBUser.Image = Image.FromFile("Data/Users/NoUser.png");
        }

       
    }
}
