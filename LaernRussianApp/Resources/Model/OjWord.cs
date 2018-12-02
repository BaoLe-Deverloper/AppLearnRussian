using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearnRussian
{
    public class OjWord
    {
        private string ID;
        private  string Word;
        private  string FileNameword;
        private  int LocationStress;
        private  string Purport;
        private string Topic;
        private string Status;

        public  string Word1 { get => Word; set => Word = value; }
        public  string FileNameword1 { get => FileNameword; set => FileNameword = value; }
        public  int LocationStress1 { get => LocationStress; set => LocationStress = value; }
      
        public string ID1 { get => ID; set => ID = value; }
        public string Topic1 { get => Topic; set => Topic = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string Purport1 { get => Purport; set => Purport = value; }

        public OjWord()
        {

        }
    }
}
