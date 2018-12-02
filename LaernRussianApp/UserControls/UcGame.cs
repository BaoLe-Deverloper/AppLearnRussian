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
using System.Speech.Synthesis;
using System.Threading;

namespace AppLearnRussian
{
    public partial class Game : UserControl
    {
        public delegate void StartUcGame1(string ID);
        public StartUcGame1 startUcGame1;
        private string ID;
        public Game(string ID)
        {
            ID1 = ID;
            InitializeComponent();

        }
        private int Number = 0;
        XmlBLL xmlBll = new XmlBLL();
        List<OjWord> list;
        string ChangeWord;
        int[] arrayRandom;

        public string ID1 { get => ID; set => ID = value; }

        private void Game1_Load(object sender, EventArgs e)
        {
            Mp3Player.Pause();
            Systeminfo.Status = false;
            list = xmlBll.ListWords(ID1);  
            arrayRandom = ArrayRandom(list.Count);
            LoadWord(Number);
        }

        void LoadWord(int number)
        {
            OjWord ojWord = list[arrayRandom[number]];
            PbSuggestion.Image = Image.FromFile(ojWord.FileNameword1);
            lbRussian.Text = ojWord.Word1;
            lbVietnamese.Text = ojWord.Purport1;
            ChangeWord = ojWord.Word1;
            new Thread(() =>
            {
                Thread.Sleep(500);
                speak(ChangeWord);
            }).Start();
           
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStop.Visible = false;
            btnPlay.Visible = true;
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnStop.Visible = true;
            btnPlay.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Number >= list.Count - 1)
                return;
            Number += 1;

           
            LoadWord(Number);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Number <= 0)
                return;
            Number -= 1;
       
           
            LoadWord(Number);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Number >= list.Count - 1)
            {
                timer1.Stop();
                startUcGame1(ID1);
                return;
            }
            Number += 1;


            LoadWord(Number);
        }

        private void btnToGame1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startUcGame1(ID1);
        }

        void speak(string Text)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Volume = 100;
            speech.Speak(Text);

        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            speak(ChangeWord);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(cbspeed.Text);
        }
    }
}

