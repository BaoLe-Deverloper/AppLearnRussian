using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class UCQuestion : UserControl
    {
        public UCQuestion()
        {
            InitializeComponent();
        }

        private bool Result;
        private string AnswerTrue;
        private string Question;
        private string A;
        private string B;
        private string C;
        private string D;
        private int number;
        public string Question1 {  set => Question = value; }
        public string A1 { set => A = value; }
        public string B1 {  set => B = value; }
        public string C1 {  set => C = value; }
        public string D1 { set => D = value; }
        public int Number {  set => number = value; }
        public bool Result1 { get => Result; set => Result = value; }
        public string AnswerTrue1 { set => AnswerTrue = value; }

        public void Load_Question()
        {
            int height = 0;
       
            if (number != 0)
            {
                if (!String.IsNullOrEmpty(Question))
                {
                    groupBox1.Text = "      Вопрос " + number.ToString() + " : ";
                    lbQuestion.Text = Question ;
                }

                if (!String.IsNullOrEmpty(A))
                {
                    RadioButton R1 = new RadioButton();
                    R1.Name = "А";
                    R1.Size = new Size(390, 50);
                
                    R1.Appearance = Appearance.Button;
                    height = 50;
                    R1.Text = A;
                    R1.Click += rdButton_click;
                    R1.BackColor = Color.DarkGray;
                    pnlAnswer.Controls.Add(R1);
                    R1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
                if (!String.IsNullOrEmpty(B))
                {
                    RadioButton R2 = new RadioButton();
                    R2.Name = "Б";
                    R2.Size = new Size(390, 50);
                    R2.Appearance = Appearance.Button;
                    R2.BackColor = Color.DarkGray;
                    height += 50;
                    R2.Text = B;
                    R2.Click+= rdButton_click;
                    pnlAnswer.Controls.Add(R2);
                    R2.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
                if (!String.IsNullOrEmpty(C))
                {
                    RadioButton R3 = new RadioButton();
                    R3.Name = "В";
                    R3.Size = new Size(390, 50);
                    R3.Appearance = Appearance.Button;
                    R3.BackColor = Color.DarkGray;
                    R3.Text = C;
                    R3.Click += rdButton_click;
                    pnlAnswer.Controls.Add(R3);
                    R3.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); 
                }
                if (!String.IsNullOrEmpty(D))
                {
                    RadioButton R4 = new RadioButton();
                    R4.Name = "Г";
                    R4.Size = new Size(390, 50);
                    R4.Appearance = Appearance.Button;
                    R4.BackColor = Color.DarkGray;
                    height += 50;
                    R4.Text = D;
                    R4.Click += rdButton_click;
                    pnlAnswer.Controls.Add(R4);
                    R4.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
               

            }
        }
        private void UCQuestion_Load(object sender, EventArgs e)
        {
            Load_Question();
        }

        private void rdButton_click (object sender, EventArgs e)
        {
           foreach ( RadioButton rb in pnlAnswer.Controls)
            {
                rb.BackColor = Color.DarkGray;
               
                ((RadioButton)sender).BackColor = System.Drawing.Color.Green;
              
            }
            RadioButton rd = ((RadioButton)sender);
            if (rd.Name == AnswerTrue)
                Result = true;
            else Result = false;
        
        }
    }
}
