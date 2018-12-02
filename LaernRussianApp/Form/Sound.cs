using AppLearnRussian;
using AppLearnRussian.Resources.BLL;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LaernRussianApp
{
    public partial class Sound : Form
    {


        public Sound()
        {

            InitializeComponent();
        }
        private bool Status;
        public string fileName;

        private Point mouselocation;
        private static Sound instance;
        public static Sound Instance
        {
            get
            {
                if (instance == null)
                    instance = new Sound();
                return instance;
            }
            set { instance = value; }
        }

        private void Sound_MouseDown(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y);
        }

        private void Sound_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousePose;
            }
        }

     
        private void Sound_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.Ver_positive);
            if (Systeminfo.Status == true)
            {
                btnOn.Visible = true;
                btnOff.Visible = false;
                Status = true;
            }
            else
            {
                btnOn.Visible = false;
                btnOff.Visible = true;
            }
            LoadListview();
            if (Systeminfo.Volume!=0)
                trackBar.Value = Systeminfo.Volume/10;
            else
                Mp3Player.Volume(trackBar.Value * 10);
        }
        void LoadListview()
        {
            ListView1.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo("DataMedia/Music");
            FileInfo[] arrayfilename = directoryInfo.GetFiles();
            foreach (var item in arrayfilename)
            {
                ListView1.Items.Add(item.Name);
            }
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count > 0)
            {
                fileName = "DataMedia/Music/" + lv.SelectedItems[0].Text;
                Mp3Player.Exit();
                Mp3Player.open(fileName);
                Mp3Player.Volume(trackBar.Value*10);
                Mp3Player.play();
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            btnOn.Visible = true;
            btnOff.Visible = false;
            Status = true;
            Systeminfo.Status = true;
            Mp3Player.play();
          
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            btnOn.Visible = false;
            btnOff.Visible = true;
            Systeminfo.Status = false;
            Status = false;
            Mp3Player.Pause();
        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(fileName))
            {
                XmlBLL xmlBLL = new XmlBLL();
                xmlBLL.SetSysteminfo(fileName, Status);
                if (Status == true)
                    Systeminfo.Status = true;
                else Systeminfo.Status = false;
                this.Close();
            }
            else MessageBox.Show("Bạn chưa chọn bài hát", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "File Mp3 |*.mp3";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = open.FileName;

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string targetPath = "DataMedia/Music/";
            if (!String.IsNullOrEmpty(txtFileName.Text))
            {
                //  if(File.Exists())
                string destFile = System.IO.Path.Combine(targetPath, Path.GetFileName(txtFileName.Text));
                if (!File.Exists(destFile))
                {
                    File.Copy(txtFileName.Text, destFile, true);
                }
                else MessageBox.Show("file này đã tồn tại.", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadListview();
        }

        private void trackBar_Scroll(object sender, ScrollEventArgs e)
        {
            Mp3Player.Volume(trackBar.Value*10);
            Systeminfo.Volume = trackBar.Value * 10;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(fileName!=null)
            {
                DialogResult res = MessageBox.Show("Bạn có muốn xóa file " + fileName + " Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(res == DialogResult.OK)
                {
                    Mp3Player.Exit();
                    File.Delete(fileName);
                    LoadListview();
                }
            }
        }
    }
}
