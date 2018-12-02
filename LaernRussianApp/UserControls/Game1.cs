using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLearnRussian.Resources.BLL;
using LaernRussianApp;
using System.Speech.Synthesis;
using System.Threading;

namespace AppLearnRussian
{
    public partial class Game1 : UserControl
    {
        private string Id;
        public Game1(string ID)
        {
            ID1 = ID;
            InitializeComponent();
          
           
        }

       
        public int Number = 0;
        XmlBLL xmlBll = new XmlBLL();
        List<OjWord> list;
        string AnswerTrue;
        int[] arrayRandom;

        public string ID1 { get => Id; set => Id = value; }

        private void Game1_Load(object sender, EventArgs e)
        {
            Mp3Player.Pause();
            list = xmlBll.ListWords(ID1);
        
            arrayRandom = ArrayRandom(list.Count);
            LoadWord(Number);
        }
        void speak(string Text)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            new Thread(() =>
            {
                speech.Volume = 100;
                speech.Speak(Text);
                Thread.Sleep(500);
            }).Start();
           
           
        }

        private void LoadWord(int Number)
        {

            string code = "ЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
            char[] Arraycode = code.ToArray();
           
            OjWord ojWord = list[arrayRandom[Number]];
            btnOK.Image = Image.FromFile(ojWord.FileNameword1);
            AnswerTrue = ojWord.Word1.ToUpper();
            lb1.Text = ojWord.Purport1;
            List<char> listBtn = ojWord.Word1.ToUpper().ToList();
            int lenght = listBtn.Count;

            //// thêm nút vào trong Câu trả lời
            int x1 = 330;
            int x2 = 330;
            for (int i = 0; i < listBtn.Count; i++)
            {

                Button btn = new Button();
                btn.Font = new System.Drawing.Font("Microsoft Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                btn.Size = new Size(40, 40);
                btn.Click += btn_answer_click;

                if (i < 15)
                {
                    btn.Location = new Point(x1, 40);
                    x1 += 20;
                }
                else
                {
                    btn.Location = new Point(x2, 80);
                    x2 += 20;
                }
                foreach (Button item in GrbAnswer.Controls)
                {
                    int Xitem = item.Location.X;
                    int Yitem = item.Location.Y;
                    if (i < 15 && Yitem == 40)
                        item.Location = new Point(Xitem - 20, 40);
                    if (i >= 15 && Yitem == 80)
                        item.Location = new Point(Xitem - 20, 80);
                }
                GrbAnswer.Controls.Add(btn);

            }

            //// Thêm kí tự ảo
            int Changelenght = lenght < 5 ? lenght * 2 : lenght + 5;
             Random random = new Random();
            for (int i = 0; i < Changelenght - lenght; i++)
            {
                listBtn.Add(Arraycode[random.Next(0, 33)]);
            }

            /// Đưa nut vào gợi ý
            int[] rd = ArrayRandom(Changelenght);
             x1 = 330;
             x2 = 330;
            for (int i = 0; i < listBtn.Count; i++)
            {

                Button btn = new Button();
                btn.Font = new System.Drawing.Font("Microsoft Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Text = listBtn[rd[i]].ToString();
                btn.Size = new Size(40, 40);
                btn.Tag = i;
                btn.BackColor = Color.SeaShell;
                btn.Click += btn_suggestion_click;

                if (i < 15)
                {
                    btn.Location = new Point(x1, 0);
                    x1 += 20;
                }
                else
                {
                    btn.Location = new Point(x2, 40);
                    x2 += 20;
                }
                foreach (Button item in pnlSuggestion.Controls)
                {
                    int Xitem = item.Location.X;
                    int Yitem = item.Location.Y;
                    if (i < 15 && Yitem == 0)
                        item.Location = new Point(Xitem - 20, 0);
                    if (i >= 15 && Yitem == 40)
                        item.Location = new Point(Xitem - 20, 40);
                }
                pnlSuggestion.Controls.Add(btn);

            }
             speak(AnswerTrue);
        }

        /// <summary>
        /// //
        /// </summary>
       
        public void btn_suggestion_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           
            foreach (Button item in GrbAnswer.Controls)
            {
                if (item.Text == "")
                {
                    item.Text = btn.Text;
                    item.Tag = btn.Tag;
                    btn.Visible = false;
                    return;

                }
            }


        }
        public void btn_answer_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text != "")
            {
                foreach (Button item in pnlSuggestion.Controls)
                {
                    if(item.Tag == btn.Tag)
                    {
                        item.Visible = true;
                        btn.Text = "";
                        return;
                    }
                }
            }

        }
        private static int[] ArrayRandom(int count)
        {

            int[] arrayrd = new int[count];
            Random rd = new Random();
            for (int j = 0; j < count; j++)
            {
                Rd: int Rd = rd.Next(0, count);
                for (int k = 0; k < j; k++)
                {
                    if (arrayrd[k] == Rd)
                        goto Rd;
                }
                arrayrd[j] = Rd;
            }

            return arrayrd;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Number >= list.Count-1)
                return;
            Number += 1;
           
            pnlSuggestion.Controls.Clear();
            GrbAnswer.Controls.Clear();
            LoadWord(Number);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Number <= 0)
                return;
            Number -= 1;
            pnlSuggestion.Controls.Clear();
            GrbAnswer.Controls.Clear();
            LoadWord(Number);
        }


        private void btncheck_Click(object sender, EventArgs e)
        {
            string Answer = "";
            foreach (Button btn in GrbAnswer.Controls)
            {
                Answer += btn.Text;
            }
            ResultVocabulary result = ResultVocabulary.Instance;
            if (Answer.ToUpper() == AnswerTrue)
            {
                result.Res = true;
                DataInfoUser.Point += 10;
                Number += 1;
                 
            }
            else
                result.Res = false;
            result.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            UcVocabulary.instance = null;
            pnlMain.Controls.Clear();
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            
            speak(AnswerTrue);
           
        }

        private void btnSuggestion_Click(object sender, EventArgs e)
        {
            char[] arrayAnswer = AnswerTrue.ToUpper().ToArray();
            for (int i = 0; i<arrayAnswer.Count();i++)
            {
                if (GrbAnswer.Controls[i].Text == "")
                {
                    DialogResult res = MessageBox.Show("Bạn sẽ bị trừ 5 điểm khi nhập trợ giúp.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    if (res == DialogResult.OK)
                    {
                        GrbAnswer.Controls[i].Text = arrayAnswer[i].ToString();
                        DataInfoUser.Point -= 5;
                    }
                   
                    return;
                }
            }
                    
        }
    }
}
