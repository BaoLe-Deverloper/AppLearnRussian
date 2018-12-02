using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearnRussian.Resources.Model
{
    public class OjQuestion
    {
        public static OjQuestion instance;
        public static OjQuestion Instance
        {
            get
            {
                if (instance == null)
                    instance = new OjQuestion();
                return Model.OjQuestion.instance;
            }
            private set { Model.OjQuestion.instance = value; }
        }

       
        // tạo phần tử model tabelQuestion
        private int Number;
        private string Lever;
        private string Question;
        private string AnswerTrue;
        private string A;
        private string B;
        private string C;
        private string D;
        private string Grammar;
        public int Number1 { get => Number; set => Number = value; }
        public string Lever1 { get => Lever; set => Lever = value; }
        public string Question1 { get => Question; set => Question = value; }
        public string AnswerTrue1 { get => AnswerTrue; set => AnswerTrue = value; }
        public string A1 { get => A; set => A = value; }
        public string B1 { get => B; set => B = value; }
        public string C1 { get => C; set => C = value; }
        public string D1 { get => D; set => D = value; }
        public string Grammar1 { get => Grammar; set => Grammar = value; }



        // tạo hàm dựng
    


        public OjQuestion()
        {
        }
       
    
    }
}
