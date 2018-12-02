using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices.ComTypes;
using AppLearnRussian.Resources.BLL;

namespace AppLearnRussian
{
    public partial class Signup : Form
    {
        XmlBLL xmlBLL = new XmlBLL();
        public Point mouselocation;
        public Signup()
        {
            InitializeComponent();
        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textPass.UseSystemPasswordChar = false;
                textConfig.UseSystemPasswordChar = false;
            }

            else
            { 
                textPass.UseSystemPasswordChar = true;
                textConfig.UseSystemPasswordChar = true;
            }
        }

        private void customImageButton3_Click(object sender, EventArgs e)
        {
            #region условие
            if (string.IsNullOrEmpty(textUser.Text))
            {
                MessageBox.Show("Вы не ввели пользователя!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUser.Focus();
                return;

            }

            if (string.IsNullOrEmpty(textPass.Text))
            {
                MessageBox.Show("Вы не ввели пароль!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPass.Focus();
                return;

            }
            if (string.IsNullOrEmpty(textConfig.Text))
            {
                MessageBox.Show("Вы еще не подтвердили свой пароль!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textConfig.Focus();
                return;

            }
            #endregion

            if (textPass.Text == textConfig.Text)
            {
                DateTime t = DateTime.Now;
                User User = new User();
                User.UserName1 = textUser.Text;
                User.Email1 = txtEmail.Text;
                User.Pass1 = textPass.Text;
                User.DateSignUp1 = DateTime.Now;
                User.FileImage1 = "Data/Users/"+ t.Day.ToString() + t.Hour.ToString() + t.Minute.ToString() + t.Second.ToString() + ".PNG";
                User.Lever1 =cbLever.Text;
                User.Admin1 = checkAdmin.Checked;
                
                if (xmlBLL.CheckExistUser(User.UserName1) == true)
                {
                    MessageBox.Show("Эта учетная запись существует", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUser.Clear();
                    textUser.Focus();
                    return;
                }

                if(String.IsNullOrEmpty(cbLever.Text))
                {
                    MessageBox.Show("Вы не выбрали уровень !", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!String.IsNullOrEmpty(file))
                {
                    File.Copy(file, User.FileImage1);

                    xmlBLL.SignUp(User);
                  
                }
                else
                {
                    MessageBox.Show("Please select a photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }    
             
            }

            else
            {
                MessageBox.Show("Пожалуйста, проверьте свой пароль!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textConfig.Focus();
                return;
            }

            MessageBox.Show("Вы успешно создали учетную запись "+textUser.Text+"!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousePose;
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.Ver_positive);
            textPass.UseSystemPasswordChar = true;
            textConfig.UseSystemPasswordChar = true;
        }
        public string file;
      

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "JPG, PNG|*.jpg;*.png";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                file = openfile.FileName;
                if (!string.IsNullOrEmpty(file))
                {
                    Image img = Image.FromFile(file);
                    pBUser.Image = img;
                }
            }
        }
        public delegate void Showlogin();
        public Showlogin showlogin;
        private void Signup_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            showlogin();
        }
    }
}
