using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearnRussian
{
    public  class User
    {
        private string UserName;
        private string Email;
        private string Pass;
        private DateTime DateSignUp;
        private string FileImage;
        private string Lever;
        private bool Admin;
        private int  Point;
        private bool Remember;

        public string UserName1 { get => UserName; set => UserName = value; }
        public string Pass1 { get => Pass; set => Pass = value; }
        public DateTime DateSignUp1 { get => DateSignUp; set => DateSignUp = value; }
        public string Lever1 { get => Lever; set => Lever = value; }
        public string FileImage1 { get => FileImage; set => FileImage = value; }
        public bool Admin1 { get => Admin; set => Admin = value; }
        public string Email1 { get => Email; set => Email = value; }
       
        public bool Remember1 { get => Remember; set => Remember = value; }
        public int Point1 { get => Point; set => Point = value; }

        public User()
        {

        }
    }
}
