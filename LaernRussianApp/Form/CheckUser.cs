using AppLearnRussian.Resources.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearnRussian
{
    public  class CheckUser:MetroFramework.Forms.MetroForm
    {

        public CheckUser()
        {
            XmlBLL xmlBLL = new XmlBLL();
            User user = null;
            try
            {
                user = xmlBLL.CheckRemember();
            }
            catch { };
            if (user != null)
            {
                DataInfoUser.usernamelogin = user.UserName1;
                DataInfoUser.Lever = user.Lever1;
                DataInfoUser.imguser = Image.FromFile(user.FileImage1);
                DataInfoUser.date = (DateTime)user.DateSignUp1;
                DataInfoUser.Point = user.Point1;
                DataInfoUser.Email = user.Email1;
                DataInfoUser.Admin = user.Admin1;
                DataInfoUser.Remember = true;
                
            }
            else
            {
                Login login = new Login();
                login.ShowDialog();
                if(String.IsNullOrEmpty(DataInfoUser.usernamelogin))
                {
                   
                }

            }
                
        }
    }
}
