using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLearnRussian.Resources.Model;

using ControlLibrary;
using System.Threading;
using AppLearnRussian.Resources.BLL;


namespace AppLearnRussian
{
    public partial class UcQuestions : UserControl
    {

       

        public UcQuestions()
        {
            this.Enabled = false;
            InitializeComponent();
          
        }
        public static UcQuestions instance;
        public static UcQuestions Instance
        {
            get
            {
                if (instance == null)
                    instance = new UcQuestions();
                return instance;
            }
           private set { instance = value; }
        }

       

        public static int Minute;
        public static int second;

        XmlBLL xmlBLL = new XmlBLL();
        private void UcQuestions_Load(object sender, EventArgs e)
        {
            
            switch(infoTest.NumberQuestions)
            {
                case 10 :
                    {
                        Minute = 2;
                        second = 0;
                        break;
                    }
                case 20:
                    {
                        Minute = 4;
                        second = 0;
                        break;
                    }
                case 30:
                    {
                        Minute = 10;
                        second = 0;
                        break;
                    }
                case 50:
                    {
                        Minute = 20;
                        second = 0;
                        break;
                    }

                case 100:
                    {
                        Minute = 40;
                        second = 0;
                        break;
                    }
            }
            
            timer1.Start();
            //Load Questions
            List<OjQuestion> Datatable = xmlBLL.DataQuestionsByLever(infoTest.Lever);  /*LoadData.Instance.LoadDataQuetion()*/;
            if(Datatable.Count<infoTest.NumberQuestions)
            {
                MessageBox.Show("không đủ câu hỏi trong cơ sở dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error );
                instance = null;
                infoTest.Lever = null;
                infoTest.NumberQuestions = 0;
                return;
            }
            int[] random = ArrayRandom(infoTest.NumberQuestions, Datatable.Count);
           

            int number = 1;
            int  height =0;
            for(int i =0; i <infoTest.NumberQuestions; i++)
            {
                OjQuestion Item = Datatable[random[i]];
                UCQuestion UcQ = new UCQuestion();
               
                UcQ.Location = new Point(0, height);
                UcQ.Number = number;
                UcQ.Question1 = Item.Question1;
                UcQ.A1 = Item.A1;
                UcQ.B1 = Item.B1;
                UcQ.C1 = Item.C1;
                UcQ.D1 = Item.D1;
                UcQ.AnswerTrue1 = Item.AnswerTrue1.Trim();
                pnlQuestions.Controls.Add(UcQ);
               
                height += 277;
                number += 1;
            }

            this.Enabled = true;

        }

       
        public static int[] ArrayRandom(int count, int MaxValue)
        {

            int[] arrayrd = new int[count];
            Random rd = new Random();
            for (int j = 0; j < count; j++)
            {
                Rd: int Rd = rd.Next(0, MaxValue);
                for (int k = 0; k < j; k++)
                {
                    if (arrayrd[k] == Rd)
                        goto Rd;
                }
                arrayrd[j] = Rd;
            }

            return arrayrd;
        }

        //CountTime
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            
            if (Minute >=0)
            {
              
                if(second >0)
                {
                    second--;
                }

                else
                {
                    if (Minute > 0)
                    {
                        second = 59;
                        Minute--;
                    }
                }
               
              
                lbMinute.Text = Minute.ToString() + " : " + second.ToString();
               
            }
           if(Minute== 0 && second ==0)
            {
                timer1.Stop();
                ResultTest resultTest = ResultTest.Instance;
                resultTest.NumberAnswers1 = infoTest.NumberQuestions;
                resultTest.NumberAnswerTrue1 = Result();
                resultTest.ShowDialog();
            }


        }

       private int Result()
        {
           
            int NumberAnswersTrue = 0;
           
            foreach (UCQuestion item in pnlQuestions.Controls)
            {
                if( item.Result1 == true)
                {
                    NumberAnswersTrue += 1;
                }
            }
            return NumberAnswersTrue;
        }

      

        private void btncheck_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ResultTest resultTest = ResultTest.Instance;
            resultTest.NumberAnswers1 = infoTest.NumberQuestions;
            resultTest.NumberAnswerTrue1 = Result();
            resultTest.ShowDialog();
        }
    }
}
