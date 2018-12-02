using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearnRussian.Resources.Model
{
      public  class QuestionListen
    {
        private string ID;
        private string Question;
        private string AnswerTrue;
        private string A;
        private string B;
        private string C;
        private string D;

      
        public string Question1 { get => Question; set => Question = value; }
        public string AnswerTrue1 { get => AnswerTrue; set => AnswerTrue = value; }
        public string A1 { get => A; set => A = value; }
        public string B1 { get => B; set => B = value; }
        public string C1 { get => C; set => C = value; }
        public string D1 { get => D; set => D = value; }
        public string ID1 { get => ID; set => ID = value; }

        public QuestionListen()
        {

        }
    }
}
