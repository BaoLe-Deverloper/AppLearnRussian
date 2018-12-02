using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Controls;
using MetroFramework.Properties;
using System.IO;
using AppLearnRussian.Resources.BLL;

namespace AppLearnRussian
{
    public partial class Login : Form
    {
        public Point mouseLocation;
        public Login()
        {
            InitializeComponent();
        }

        XmlBLL xmlBLL = new XmlBLL();
        bool Remember;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkBox1.Checked == true)
                textPass.UseSystemPasswordChar = false;
            else textPass.UseSystemPasswordChar = true;
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            #region условие
            if (string.IsNullOrEmpty(textUser.Text))
            {
                MessageBox.Show("Вы ввели неправильное имя пользователя!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textPass.Text))
            {
                MessageBox.Show("Вы ввели неверный пароль!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPass.Focus();
                return;
            }
            #endregion

            #region
            string Username = textUser.Text;
            string Pass = textPass.Text;

            try
            {

                User user = xmlBLL.Login(Username, Pass);
                DataInfoUser.usernamelogin = user.UserName1;
                DataInfoUser.date = user.DateSignUp1;
                DataInfoUser.Lever = user.Lever1;
                DataInfoUser.imguser = Image.FromFile(user.FileImage1);
                DataInfoUser.date = (DateTime)user.DateSignUp1;
                DataInfoUser.Point = user.Point1;
                DataInfoUser.Email = user.Email1;
                DataInfoUser.Admin = user.Admin1;
               
                if (! String.IsNullOrEmpty(user.FileImage1))
                   DataInfoUser.imguser = Image.FromFile(user.FileImage1);
                this.Close();
                if (Remember != true)
                    xmlBLL.ForgetUser(user);
                else xmlBLL.RememberUser(user);




            }

            catch (Exception)
            {
                MessageBox.Show("Ошибка входа в систем!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            #endregion
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;

            }
        }

        private void customImageButton1_Click_1(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textPass.UseSystemPasswordChar = true;
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.Ver_positive);
            if(!String.IsNullOrEmpty(DataInfoUser.usernamelogin))
            {
                textUser.Text = DataInfoUser.usernamelogin;
                chbRemember.Checked = true;
            }
        }

        void show()
        {
            this.Show();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.showlogin += new Signup.Showlogin(show);
            signup.ShowDialog();
           
        }

        private void chbRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRemember.Checked == true)
                Remember = true;
            else
                Remember = false;
        }
    }
}
