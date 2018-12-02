using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppLearnRussian.UserControls
{
    public partial class UcBook : UserControl
    {
        public UcBook()
        {
            InitializeComponent();
        }

        public string NameFile;


        private void UcBook_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

        }
       
        
        public void LoadPdf (String NameFile)
        {
            pnlMain.Controls.Clear();
            pdf.Dock = DockStyle.Fill;
            
            pnlMain.Controls.Add(pdf);
          
            using ( FileStream fs = new FileStream(NameFile, FileMode.Open, FileAccess.Read))
                pdf.src = fs.Name;
           
           
        }
        private void label11_Click(object sender, EventArgs e)
        {
            
            NameFile = @"DataMedia\filepdf\1. тексты Большакова.pdf";
          
            LoadPdf(NameFile);
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
           
            NameFile = @"DataMedia\filepdf\Дорога в России 1.pdf";
            LoadPdf(NameFile);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
          
            NameFile = @"DataMedia\filepdf\Дорога в России 2.pdf";
            LoadPdf(NameFile);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            NameFile = @"DataMedia\filepdf\Дорога в России 3.pdf";
            LoadPdf(NameFile);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NameFile = @"DataMedia\filepdf\Живем и учимся в России.pdf";
            LoadPdf(NameFile);
        }

       
        private void panel11_Click(object sender, EventArgs e)
        {
         
            NameFile = @"DataMedia\filepdf\5 элементов_Уровень А1.pdf";
            LoadPdf(NameFile);
        }

 


    
    }
}
