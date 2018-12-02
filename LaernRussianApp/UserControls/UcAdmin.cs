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
using System.Threading;
using AppLearnRussian.Resources.BLL;
using System.IO;

namespace AppLearnRussian
{
    public partial class UcAdmin : UserControl
    {


        public UcAdmin()
        {

            InitializeComponent();
            LoadData();

        }
        XmlBLL xmlBLL = new XmlBLL();


        #region Add Questions

        void LoadData()
        {
            try
            {
                DataGrid.DataSource = xmlBLL.DataQuestions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            Admin_Questions admin_Questions = new Admin_Questions();
            admin_Questions.Number = DataGrid.RowCount + 1;
            admin_Questions.Text = " Question " + (DataGrid.RowCount + 1).ToString();
            admin_Questions.btnUpdate1.Enabled = false;
            admin_Questions.loadData = new Admin_Questions.LoadData(LoadData);
            admin_Questions.ShowDialog();

        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Admin_Questions admin_Questions = new Admin_Questions();
            admin_Questions.Number = e.RowIndex + 1;
            admin_Questions.cbLever.Text = DataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            admin_Questions.txtQuestion.Text = DataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            admin_Questions.cbTrue.Text = DataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            admin_Questions.txtA.Text = DataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            admin_Questions.txtB.Text = DataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            admin_Questions.txtC.Text = DataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            admin_Questions.txtD.Text = DataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            admin_Questions.Grammar = DataGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            admin_Questions.btnInsert.Enabled = false;
            admin_Questions.btnUpdate1.Visible = true;
            admin_Questions.btnUpDate2.Visible = false;
            admin_Questions.Text = "Question " + (e.RowIndex + 1).ToString();
            admin_Questions.loadData = new Admin_Questions.LoadData(LoadData);
            admin_Questions.ShowDialog();

        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            Admin_Questions admin_Questions = new Admin_Questions();
            admin_Questions.btnInsert.Enabled = false;
            admin_Questions.Text = "UpDate Question";
            admin_Questions.pnlSearch.Visible = true;
            admin_Questions.btnUpdate1.Visible = false;
            admin_Questions.btnUpDate2.Visible = true;
            admin_Questions.loadData = new Admin_Questions.LoadData(LoadData);
            admin_Questions.ShowDialog();

        }
        #endregion





        #region Add Vocabulary
        string IDVocabulary;
        string FileNameVocabulary;
        OjWord ojWord = new OjWord();
        int LocationStress;
        private void btnchoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileNameVocabulary = openFile.FileName;
                pictureBox1.Image = Image.FromFile(FileNameVocabulary);
                txtFile.Text = FileNameVocabulary;
            }
        }


        private void tabPageAddVocabulary_Paint(object sender, PaintEventArgs e)
        {

            LoadDataVocabulary();
        }

        void LoadDataVocabulary()
        {

            DataGridVocabulary.DataSource = xmlBLL.ListWords(cbTopic.Text);

        }
        private void btninsert_Click_2(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtrussian.Text) && String.IsNullOrEmpty(txtvietnamese.Text) && String.IsNullOrEmpty(cbTopic.Text) && String.IsNullOrEmpty(FileNameVocabulary))
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DateTime d = DateTime.Now;
            string ID = d.Day.ToString() + d.Hour.ToString() + d.Minute.ToString() + d.Second.ToString() + d.Millisecond.ToString();
            ojWord.ID1 = ID;
            ojWord.Word1 = txtrussian.Text;
            ojWord.Purport1 = txtvietnamese.Text;

            ojWord.Topic1 = cbTopic.Text;
            string file = @"Data\Vocabulary\" + ID + ".png";
            if (!String.IsNullOrEmpty(txtFile.Text))
            {
                File.Copy(txtFile.Text, file);
            }
            ojWord.FileNameword1 = file;
            ojWord.LocationStress1 = LocationStress;
            xmlBLL.InsertWords(ojWord);
            LoadDataVocabulary();
            LocationStress = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (String.IsNullOrEmpty(IDVocabulary))
                return;
            xmlBLL.DeleteWord(IDVocabulary);
            LoadDataVocabulary();
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDVocabulary))
                return;
            ojWord.Word1 = txtrussian.Text;
            ojWord.Purport1 = txtvietnamese.Text;
            ojWord.LocationStress1 = LocationStress;
            ojWord.Topic1 = cbTopic.Text;
            ojWord.FileNameword1 = txtFile.Text;


            string file = @"Data\Vocabulary\" + IDVocabulary + ".png";
            if (txtFile.Text != file)
            {
                if (!String.IsNullOrEmpty(FileNameVocabulary))
                {
                    DateTime d = DateTime.Now;
                    string ID = d.Day.ToString() + d.Hour.ToString() + d.Minute.ToString() + d.Second.ToString() + d.Millisecond.ToString();
                    string newfile = @"Data\Vocabulary\" + ID + ".png";
                    File.Copy(txtFile.Text, newfile);
                }
            }


            xmlBLL.UpdateWord(IDVocabulary, ojWord);
            LoadDataVocabulary();
            LocationStress = 0;
        }
        private void DataGridVocabulary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            IDVocabulary = DataGridVocabulary.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtrussian.Text = DataGridVocabulary.Rows[e.RowIndex].Cells["Word"].Value.ToString();
            txtvietnamese.Text = DataGridVocabulary.Rows[e.RowIndex].Cells["Purport"].Value.ToString();
            txtFile.Text = DataGridVocabulary.Rows[e.RowIndex].Cells["FileName"].Value.ToString();
            cbTopic.Text = DataGridVocabulary.Rows[e.RowIndex].Cells["Topic"].Value.ToString();
            int LocationStress = int.Parse(DataGridVocabulary.Rows[e.RowIndex].Cells["Stress"].Value.ToString());
            foreach (Button item in pnlStress.Controls)
            {
                item.BackColor = Color.White;
                if ((int)item.Tag == LocationStress)
                {
                    item.BackColor = Color.Red;
                }
            }

            pictureBox1.Image = Image.FromFile(txtFile.Text);


        }


        private void txtrussian_TextChanged(object sender, EventArgs e)
        {
            pnlStress.Controls.Clear();
            char[] key = txtrussian.Text.ToArray();
            int i = 1;
            foreach (var item in key)
            {
                Button btn = new Button();
                btn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                btn.Text = item.ToString();
                btn.Tag = i;
                btn.Size = new Size(42, 32);
                btn.BackColor = Color.White;
                btn.Click += btn_click;
                pnlStress.Controls.Add(btn);
                i++;
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (Button item in pnlStress.Controls)
            {
                item.BackColor = Color.White;

            }
            btn.BackColor = Color.Red;
            LocationStress = (int)btn.Tag;
        }

        #endregion

        private void btnNostress_Click(object sender, EventArgs e)
        {
            LocationStress = 0;
        }

        private void cbTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataVocabulary();
        }
    }
}


