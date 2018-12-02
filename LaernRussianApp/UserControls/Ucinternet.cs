using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaernRussianApp
{
    public partial class Ucinternet : UserControl
    {
        public  Ucinternet()
        {
            InitializeComponent();
        }
        private static Ucinternet instance;
        public  static Ucinternet Instance
        {
            get
            {
                if (instance == null)
                    instance = new Ucinternet();
                return instance;
            }
            private set { instance = value; }
        }
        string url;
        WebBrowser webBrowser = new WebBrowser() { Dock = DockStyle.Bottom, Size = new Size(1198, 560), ScriptErrorsSuppressed= true };
        public async Task intenet()
        {
            panelMain.Controls.Clear();
            webBrowser.Url = new Uri(url);
            panelMain.Controls.Add(webBrowser);
        }
        private async void btnGoogle_Click(object sender, EventArgs e)
        {
            url = "https://Google.com";
            await intenet();
        }

        private async void btnYouTube_Click(object sender, EventArgs e)
        {
            url = "https://Youtube.com";
            await intenet();
        }

        private async void btnYandex_Click(object sender, EventArgs e)
        {
            url = "https://www.yandex.ru";
            await intenet();

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private async void btnbao_Click(object sender, EventArgs e)
        {
            url = "https://www.gazeta.ru/";
            await intenet();

        }

        private async void Ucinternet_Load(object sender, EventArgs e)
        {
            url = "https://www.gazeta.ru/";
            await intenet();
        }
    }
}