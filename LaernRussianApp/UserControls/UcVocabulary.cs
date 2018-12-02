 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLearnRussian
{
    public partial class UcVocabulary : UserControl
    {
        public static UcVocabulary instance;
        public static UcVocabulary Instance
        {
            get
            {
                if (instance == null)
                    instance = new UcVocabulary();
                return instance;
            }
            private set { instance = value; }
        }

        public UcVocabulary()
        {
         
            InitializeComponent();
        }
        private void Showgame1(string ID)
        {

            Game1 game = new Game1(ID);
            game.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(game);
        }
        private void ShowGame(string ID)
        {
            Game  game = new Game(ID);
            game.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(game);
            game.startUcGame1 += Showgame1;



        }
        

        private void btnNha_Click(object sender, EventArgs e)
        {

            ShowGame("Дом");
        }

        private void btnDongVat_Click(object sender, EventArgs e)
        {
            ShowGame("Животные");
        }

        private void btnThucAn_Click(object sender, EventArgs e)
        {
            ShowGame("Еда");
        }

        private void btnLophoc_Click(object sender, EventArgs e)
        {
            ShowGame("Образование");
        }

        private void btnQuanDoi_Click(object sender, EventArgs e)
        {
            ShowGame("Армия");
        }

        private void btnQuanAo_Click(object sender, EventArgs e)
        {
            ShowGame("Одежда");
        }

        private void btnPhuonTien_Click(object sender, EventArgs e)
        {
            ShowGame("Транспорт");
        }

        private void btnNhaHang_Click(object sender, EventArgs e)
        {
            ShowGame("Ресторан");
        }

        private void btnNghe_Click(object sender, EventArgs e)
        {
            ShowGame("Профессия");
        }
    }
}
