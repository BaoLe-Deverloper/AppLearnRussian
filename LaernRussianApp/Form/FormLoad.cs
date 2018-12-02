
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLearnRussian
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
           
            InitializeComponent();
        }
       
       
        private void FormLoad_Load(object sender, EventArgs e)
        {
            
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.Blend);
          
        } 
      
      
    }
    
}
