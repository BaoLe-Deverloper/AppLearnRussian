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
using System.Threading;

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
           
           
        }


        public async Task LoadPdf()
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(pdf);
            pdf.Visible = true;
            pdf.Dock = DockStyle.Fill;
            using (FileStream fs = new FileStream(NameFile, FileMode.Open, FileAccess.Read))
            { 
               pdf.src = fs.Name;
                  
            }
              
        }
        private async void label11_Click(object sender, EventArgs e)
        {
          
            NameFile = @"DataMedia\filepdf\T1.pdf";
            
            await LoadPdf();
           
        }

        private async void label8_Click_1(object sender, EventArgs e)
        {
          
            NameFile = @"DataMedia\filepdf\D1.pdf";
          
            await LoadPdf();
          
        }

        private async void panel2_Click(object sender, EventArgs e)
        {
          
            NameFile = @"DataMedia\filepdf\D2.pdf";
            await LoadPdf();
        }

        private async void pictureBox6_Click(object sender, EventArgs e)
        {
         
            NameFile = @"DataMedia\filepdf\D3.pdf";
            await LoadPdf();
        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            NameFile = @"DataMedia\filepdf\J.pdf";
            await  LoadPdf();
        }


        private async void panel11_Click(object sender, EventArgs e)
        {

            NameFile = @"DataMedia\filepdf\E5.pdf";
            await LoadPdf();
        }
        
    }
}
