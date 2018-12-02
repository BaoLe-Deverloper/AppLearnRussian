using AppLearnRussian.Resources.BLL;

using AppLearnRussian.Resources.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Admin_Questions : Form
    {
        public delegate void LoadData();
        public LoadData loadData;
        XmlBLL xmlBll = new XmlBLL();
        public int Number;
        public string Grammar;
        public Admin_Questions()
        {
            InitializeComponent();
        }
      
        private void View_Questions_Load(object sender, EventArgs e)
        {
            try
            {
                CbGrammar.DataSource = xmlBll.DataGrammars();
                CbGrammar.ValueMember = "Grammar1";
                CbGrammar.Text = Grammar;
            }  
          catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbLever.Text) && !String.IsNullOrEmpty(txtQuestion.Text) && !String.IsNullOrEmpty(txtA.Text) && !String.IsNullOrEmpty(txtB.Text) && !String.IsNullOrEmpty(cbTrue.Text))
            {
                OjQuestion tablequestion = new OjQuestion();
                tablequestion.Number1 = Number;
                tablequestion.Lever1 = cbLever.Text;
                tablequestion.Question1 = txtQuestion.Text;
                tablequestion.AnswerTrue1 = cbTrue.Text;
                tablequestion.A1 = txtA.Text;
                tablequestion.B1 = txtB.Text;
                tablequestion.C1 = txtC.Text;
                tablequestion.D1 = txtD.Text;
                tablequestion.Grammar1 = CbGrammar.Text;

                xmlBll.InsertQuestion(tablequestion);
                loadData();
                Number++;
                this.Text = "Question " + Number.ToString();
                txtQuestion.Clear();
                txtA.Clear();
                txtB.Clear();
                txtC.Clear();
                txtD.Clear();



            }
            else
                MessageBox.Show(" Not Null Value Lever, Question , Answer A, Answer B, Answer True !", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
            if (!String.IsNullOrEmpty(cbLever.Text) && !String.IsNullOrEmpty(txtQuestion.Text) && !String.IsNullOrEmpty(txtA.Text) && !String.IsNullOrEmpty(txtB.Text) && !String.IsNullOrEmpty(cbTrue.Text))
            {
                OjQuestion tablequestion = new OjQuestion();
                tablequestion.Number1 = Number;
                tablequestion.Lever1 = cbLever.Text;
                tablequestion.Question1 = txtQuestion.Text;
                tablequestion.AnswerTrue1 = cbTrue.Text;
                tablequestion.A1 = txtA.Text;
                tablequestion.B1 = txtB.Text;
                tablequestion.C1 = txtC.Text;
                tablequestion.D1 = txtD.Text;
                tablequestion.Grammar1 = CbGrammar.Text;

                xmlBll.UpdateQuestion(tablequestion);
             
                loadData();
               
            }
            else
                MessageBox.Show(" Not Null Value Lever, Question , Answer A, Answer B, Answer True !", " Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtNumberSearch.Text))
            {
                txtNumberSearch.Text = Convert.ToString(Convert.ToInt32(txtNumberSearch.Text) + 1);
            }
           Search();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNumberSearch.Text))
            {
                txtNumberSearch.Text = Convert.ToString(Convert.ToInt32(txtNumberSearch.Text) - 1);
            }
            Search();
        }

        void Search()
        {
            if (!String.IsNullOrEmpty(txtNumberSearch.Text))
            {
                try
                {
                    Number = Convert.ToInt32(txtNumberSearch.Text);

                    OjQuestion tableQuestion = xmlBll.Search(Number);

                    cbLever.Text = tableQuestion.Lever1;
                    txtQuestion.Text = tableQuestion.Question1;
                    cbTrue.Text = tableQuestion.AnswerTrue1;
                    txtA.Text = tableQuestion.A1;
                    txtB.Text = tableQuestion.B1;
                    txtC.Text = tableQuestion.C1;
                    txtD.Text = tableQuestion.D1;
                    CbGrammar.Text = tableQuestion.Grammar1;
                }
                catch (Exception  )
                {
                    MessageBox.Show(" In the database does not exist this value ", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }

            else
                MessageBox.Show("Value Number Null", " Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnUpDate2_Click(object sender, EventArgs e)
        {

            OjQuestion tablequestion = new OjQuestion();
            tablequestion.Number1 = Number;
            tablequestion.Lever1 = cbLever.Text;
            tablequestion.Question1 = txtQuestion.Text;
            tablequestion.AnswerTrue1 = cbTrue.Text;
            tablequestion.A1 = txtA.Text;
            tablequestion.B1 = txtB.Text;
            tablequestion.C1 = txtC.Text;
            tablequestion.D1 = txtD.Text;
            tablequestion.Grammar1 = CbGrammar.Text;



            if (!String.IsNullOrEmpty(cbLever.Text) && !String.IsNullOrEmpty(txtQuestion.Text) && !String.IsNullOrEmpty(txtA.Text) && !String.IsNullOrEmpty(txtB.Text) && !String.IsNullOrEmpty(cbTrue.Text))
            {
                xmlBll.UpdateQuestion(tablequestion);
                loadData();

            }
            else
                MessageBox.Show(" Not Null Value Lever, Question , Answer A, Answer B, Answer True !", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
