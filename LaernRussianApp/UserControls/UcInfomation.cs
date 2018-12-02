using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLearnRussian.UserControls
{
    public partial class UcInfomation : UserControl
    {
        public UcInfomation()
        {
            InitializeComponent();
        }

        private void UcInfomation_Load(object sender, EventArgs e)
        {
          
               
            if (!string.IsNullOrEmpty(DataInfoUser.usernamelogin))
            {
                NameUser.Text = DataInfoUser.usernamelogin;
                pBUser.Image = DataInfoUser.imguser;
                txtDateSignUp.Text = String.Format("{0:M/d/yyyy}", DataInfoUser.date).ToString();
                lbPoint.Text = DataInfoUser.Point.ToString();
            }

            else
            {
                NameUser.Text = "NoUserName";
                pBUser.Image = Image.FromFile("Data/Users/NoUser.png");
                txtDateSignUp.Text = "00 / 00 / 00";
                txtLever.Text = "No";
                lbPoint.Text = "0";

                
            }
        }
    }
}
