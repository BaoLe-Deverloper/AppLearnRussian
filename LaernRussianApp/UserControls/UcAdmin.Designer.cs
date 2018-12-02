namespace AppLearnRussian
{
    partial class UcAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAdmin));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TabPageAddQuestion = new MetroFramework.Controls.MetroTabPage();
            this.btnUpDate = new MetroFramework.Controls.MetroButton();
            this.DataGrid = new MetroFramework.Controls.MetroGrid();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lever = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerTrue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grammar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btInsert = new MetroFramework.Controls.MetroButton();
            this.tabPageAddVocabulary = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridVocabulary = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlinput = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUp = new MetroFramework.Controls.MetroButton();
            this.btninsert = new MetroFramework.Controls.MetroButton();
            this.txtvietnamese = new MetroFramework.Controls.MetroTextBox();
            this.txtrussian = new MetroFramework.Controls.MetroTextBox();
            this.txtFile = new MetroFramework.Controls.MetroTextBox();
            this.btnchoose = new MetroFramework.Controls.MetroButton();
            this.pnlStress = new System.Windows.Forms.FlowLayoutPanel();
            this.cbTopic = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabPageAddGrammar = new MetroFramework.Controls.MetroTabPage();
            this.btnNostress = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.TabPageAddQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.tabPageAddVocabulary.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVocabulary)).BeginInit();
            this.pnlinput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.TabPageAddQuestion);
            this.metroTabControl1.Controls.Add(this.tabPageAddVocabulary);
            this.metroTabControl1.Controls.Add(this.TabPageAddGrammar);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1182, 596);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            // 
            // TabPageAddQuestion
            // 
            this.TabPageAddQuestion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TabPageAddQuestion.Controls.Add(this.btnUpDate);
            this.TabPageAddQuestion.Controls.Add(this.DataGrid);
            this.TabPageAddQuestion.Controls.Add(this.btInsert);
            this.TabPageAddQuestion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TabPageAddQuestion.HorizontalScrollbar = true;
            this.TabPageAddQuestion.HorizontalScrollbarBarColor = true;
            this.TabPageAddQuestion.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageAddQuestion.HorizontalScrollbarSize = 10;
            this.TabPageAddQuestion.Location = new System.Drawing.Point(4, 35);
            this.TabPageAddQuestion.Name = "TabPageAddQuestion";
            this.TabPageAddQuestion.Size = new System.Drawing.Size(1174, 557);
            this.TabPageAddQuestion.TabIndex = 0;
            this.TabPageAddQuestion.Text = "AddQuestions";
            this.TabPageAddQuestion.VerticalScrollbarBarColor = true;
            this.TabPageAddQuestion.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageAddQuestion.VerticalScrollbarSize = 10;
            // 
            // btnUpDate
            // 
            this.btnUpDate.Location = new System.Drawing.Point(114, 3);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(90, 35);
            this.btnUpDate.TabIndex = 4;
            this.btnUpDate.Text = "UpDate";
            this.btnUpDate.UseSelectable = true;
            this.btnUpDate.Click += new System.EventHandler(this.btnUpDate_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Lever,
            this.Question,
            this.AnswerTrue,
            this.A,
            this.B,
            this.C,
            this.D,
            this.Grammar});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DataGrid.HighLightPercentage = 0.8F;
            this.DataGrid.Location = new System.Drawing.Point(-4, 44);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGrid.RowHeadersWidth = 18;
            this.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1178, 465);
            this.DataGrid.TabIndex = 3;
            this.DataGrid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number1";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // Lever
            // 
            this.Lever.DataPropertyName = "Lever1";
            this.Lever.HeaderText = "Lever";
            this.Lever.Name = "Lever";
            // 
            // Question
            // 
            this.Question.DataPropertyName = "Question1";
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            // 
            // AnswerTrue
            // 
            this.AnswerTrue.DataPropertyName = "AnswerTrue1";
            this.AnswerTrue.HeaderText = "AnswerTrue";
            this.AnswerTrue.Name = "AnswerTrue";
            this.AnswerTrue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // A
            // 
            this.A.DataPropertyName = "A1";
            this.A.HeaderText = "A";
            this.A.Name = "A";
            // 
            // B
            // 
            this.B.DataPropertyName = "B1";
            this.B.HeaderText = "B";
            this.B.Name = "B";
            // 
            // C
            // 
            this.C.DataPropertyName = "C1";
            this.C.HeaderText = "C";
            this.C.Name = "C";
            // 
            // D
            // 
            this.D.DataPropertyName = "D1";
            this.D.HeaderText = "D";
            this.D.Name = "D";
            // 
            // Grammar
            // 
            this.Grammar.DataPropertyName = "Grammar1";
            this.Grammar.HeaderText = "Grammar";
            this.Grammar.Name = "Grammar";
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(3, 3);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(90, 35);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "Insert Data";
            this.btInsert.UseSelectable = true;
            this.btInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tabPageAddVocabulary
            // 
            this.tabPageAddVocabulary.Controls.Add(this.panel2);
            this.tabPageAddVocabulary.Location = new System.Drawing.Point(4, 38);
            this.tabPageAddVocabulary.Name = "tabPageAddVocabulary";
            this.tabPageAddVocabulary.Size = new System.Drawing.Size(1174, 554);
            this.tabPageAddVocabulary.TabIndex = 3;
            this.tabPageAddVocabulary.Text = "AddVocabulary";
            this.tabPageAddVocabulary.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageAddVocabulary_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.DataGridVocabulary);
            this.panel2.Controls.Add(this.pnlinput);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 554);
            this.panel2.TabIndex = 0;
            // 
            // DataGridVocabulary
            // 
            this.DataGridVocabulary.AllowUserToResizeRows = false;
            this.DataGridVocabulary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridVocabulary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridVocabulary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DataGridVocabulary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridVocabulary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridVocabulary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridVocabulary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridVocabulary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVocabulary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Word,
            this.Purport,
            this.Topic,
            this.FileName,
            this.Stress});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridVocabulary.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridVocabulary.EnableHeadersVisualStyles = false;
            this.DataGridVocabulary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridVocabulary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DataGridVocabulary.Location = new System.Drawing.Point(3, 289);
            this.DataGridVocabulary.Name = "DataGridVocabulary";
            this.DataGridVocabulary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridVocabulary.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridVocabulary.RowHeadersWidth = 18;
            this.DataGridVocabulary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridVocabulary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridVocabulary.Size = new System.Drawing.Size(467, 262);
            this.DataGridVocabulary.TabIndex = 3;
            this.DataGridVocabulary.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DataGridVocabulary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridVocabulary_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID1";
            this.ID.FillWeight = 93.04028F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Word
            // 
            this.Word.DataPropertyName = "Word1";
            this.Word.FillWeight = 83.74713F;
            this.Word.HeaderText = "Russian";
            this.Word.Name = "Word";
            // 
            // Purport
            // 
            this.Purport.DataPropertyName = "Purport1";
            this.Purport.FillWeight = 83.74713F;
            this.Purport.HeaderText = "Vietnamese";
            this.Purport.Name = "Purport";
            // 
            // Topic
            // 
            this.Topic.DataPropertyName = "Topic1";
            this.Topic.FillWeight = 83.74713F;
            this.Topic.HeaderText = "Topic";
            this.Topic.Name = "Topic";
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileNameword1";
            this.FileName.FillWeight = 113.9417F;
            this.FileName.HeaderText = "FileName";
            this.FileName.MinimumWidth = 50;
            this.FileName.Name = "FileName";
            // 
            // Stress
            // 
            this.Stress.DataPropertyName = "LocationStress1";
            this.Stress.FillWeight = 51.77665F;
            this.Stress.HeaderText = "Stress";
            this.Stress.Name = "Stress";
            // 
            // pnlinput
            // 
            this.pnlinput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlinput.Controls.Add(this.btnNostress);
            this.pnlinput.Controls.Add(this.label2);
            this.pnlinput.Controls.Add(this.label1);
            this.pnlinput.Controls.Add(this.btnDelete);
            this.pnlinput.Controls.Add(this.btnUp);
            this.pnlinput.Controls.Add(this.btninsert);
            this.pnlinput.Controls.Add(this.txtvietnamese);
            this.pnlinput.Controls.Add(this.txtrussian);
            this.pnlinput.Controls.Add(this.txtFile);
            this.pnlinput.Controls.Add(this.btnchoose);
            this.pnlinput.Controls.Add(this.pnlStress);
            this.pnlinput.Controls.Add(this.cbTopic);
            this.pnlinput.Location = new System.Drawing.Point(485, 0);
            this.pnlinput.Name = "pnlinput";
            this.pnlinput.Size = new System.Drawing.Size(686, 551);
            this.pnlinput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(37, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Topic :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stress :";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(556, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Location = new System.Drawing.Point(448, 390);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(102, 30);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "UpDate";
            this.btnUp.UseSelectable = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btninsert
            // 
            this.btninsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btninsert.Location = new System.Drawing.Point(340, 390);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(102, 30);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "Insert";
            this.btninsert.UseSelectable = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click_2);
            // 
            // txtvietnamese
            // 
            // 
            // 
            // 
            this.txtvietnamese.CustomButton.Image = null;
            this.txtvietnamese.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtvietnamese.CustomButton.Name = "";
            this.txtvietnamese.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtvietnamese.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtvietnamese.CustomButton.TabIndex = 1;
            this.txtvietnamese.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtvietnamese.CustomButton.UseSelectable = true;
            this.txtvietnamese.CustomButton.Visible = false;
            this.txtvietnamese.Lines = new string[0];
            this.txtvietnamese.Location = new System.Drawing.Point(310, 35);
            this.txtvietnamese.MaxLength = 32767;
            this.txtvietnamese.Name = "txtvietnamese";
            this.txtvietnamese.PasswordChar = '\0';
       
            this.txtvietnamese.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtvietnamese.SelectedText = "";
            this.txtvietnamese.SelectionLength = 0;
            this.txtvietnamese.SelectionStart = 0;
            this.txtvietnamese.ShortcutsEnabled = true;
            this.txtvietnamese.Size = new System.Drawing.Size(245, 23);
            this.txtvietnamese.TabIndex = 5;
            this.txtvietnamese.UseSelectable = true;
            this.txtvietnamese.WaterMark = "vocabulary vietnamese";
            this.txtvietnamese.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtvietnamese.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtrussian
            // 
            // 
            // 
            // 
            this.txtrussian.CustomButton.Image = null;
            this.txtrussian.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtrussian.CustomButton.Name = "";
            this.txtrussian.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtrussian.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtrussian.CustomButton.TabIndex = 1;
            this.txtrussian.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtrussian.CustomButton.UseSelectable = true;
            this.txtrussian.CustomButton.Visible = false;
            this.txtrussian.Lines = new string[0];
            this.txtrussian.Location = new System.Drawing.Point(41, 35);
            this.txtrussian.MaxLength = 32767;
            this.txtrussian.Name = "txtrussian";
            this.txtrussian.PasswordChar = '\0';
         
            this.txtrussian.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtrussian.SelectedText = "";
            this.txtrussian.SelectionLength = 0;
            this.txtrussian.SelectionStart = 0;
            this.txtrussian.ShortcutsEnabled = true;
            this.txtrussian.Size = new System.Drawing.Size(244, 23);
            this.txtrussian.TabIndex = 5;
            this.txtrussian.UseSelectable = true;
            this.txtrussian.WaterMark = "vocabulary russian";
            this.txtrussian.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtrussian.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtrussian.TextChanged += new System.EventHandler(this.txtrussian_TextChanged);
            // 
            // txtFile
            // 
            // 
            // 
            // 
            this.txtFile.CustomButton.Image = null;
            this.txtFile.CustomButton.Location = new System.Drawing.Point(492, 1);
            this.txtFile.CustomButton.Name = "";
            this.txtFile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFile.CustomButton.TabIndex = 1;
            this.txtFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFile.CustomButton.UseSelectable = true;
            this.txtFile.CustomButton.Visible = false;
            this.txtFile.Lines = new string[0];
            this.txtFile.Location = new System.Drawing.Point(41, 86);
            this.txtFile.MaxLength = 32767;
            this.txtFile.Name = "txtFile";
            this.txtFile.PasswordChar = '\0';
          
            this.txtFile.ReadOnly = true;
            this.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFile.SelectedText = "";
            this.txtFile.SelectionLength = 0;
            this.txtFile.SelectionStart = 0;
            this.txtFile.ShortcutsEnabled = true;
            this.txtFile.Size = new System.Drawing.Size(514, 23);
            this.txtFile.TabIndex = 4;
            this.txtFile.UseSelectable = true;
            this.txtFile.WaterMark = "File Name Picture";
            this.txtFile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnchoose
            // 
            this.btnchoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnchoose.Location = new System.Drawing.Point(573, 86);
            this.btnchoose.Name = "btnchoose";
            this.btnchoose.Size = new System.Drawing.Size(100, 23);
            this.btnchoose.TabIndex = 3;
            this.btnchoose.Text = ".... Choose Image";
            this.btnchoose.UseSelectable = true;
            this.btnchoose.Click += new System.EventHandler(this.btnchoose_Click);
            // 
            // pnlStress
            // 
            this.pnlStress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStress.AutoScroll = true;
            this.pnlStress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.pnlStress.Location = new System.Drawing.Point(19, 277);
            this.pnlStress.Name = "pnlStress";
            this.pnlStress.Size = new System.Drawing.Size(651, 84);
            this.pnlStress.TabIndex = 2;
            // 
            // cbTopic
            // 
            this.cbTopic.FormattingEnabled = true;
            this.cbTopic.ItemHeight = 23;
            this.cbTopic.Items.AddRange(new object[] {
            "Дом",
            "Одежда",
            "Транспорт",
            "Еда",
            "Образование",
            "Ресторан",
            "Профессия",
            "Животные",
            "Армия"});
            this.cbTopic.Location = new System.Drawing.Point(132, 134);
            this.cbTopic.Name = "cbTopic";
            this.cbTopic.Size = new System.Drawing.Size(310, 29);
            this.cbTopic.TabIndex = 1;
            this.cbTopic.UseSelectable = true;
            this.cbTopic.SelectedIndexChanged += new System.EventHandler(this.cbTopic_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TabPageAddGrammar
            // 
            this.TabPageAddGrammar.HorizontalScrollbarBarColor = true;
            this.TabPageAddGrammar.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageAddGrammar.HorizontalScrollbarSize = 10;
            this.TabPageAddGrammar.Location = new System.Drawing.Point(4, 35);
            this.TabPageAddGrammar.Name = "TabPageAddGrammar";
            this.TabPageAddGrammar.Size = new System.Drawing.Size(1174, 557);
            this.TabPageAddGrammar.TabIndex = 2;
            this.TabPageAddGrammar.Text = "AddGrammar";
            this.TabPageAddGrammar.VerticalScrollbarBarColor = true;
            this.TabPageAddGrammar.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageAddGrammar.VerticalScrollbarSize = 10;
            // 
            // btnNostress
            // 
            this.btnNostress.Location = new System.Drawing.Point(132, 247);
            this.btnNostress.Name = "btnNostress";
            this.btnNostress.Size = new System.Drawing.Size(62, 24);
            this.btnNostress.TabIndex = 8;
            this.btnNostress.Tag = "0";
            this.btnNostress.Text = "No stress";
            this.btnNostress.UseSelectable = true;
            this.btnNostress.Click += new System.EventHandler(this.btnNostress_Click);
            // 
            // UcAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.metroTabControl1);
            this.DoubleBuffered = true;
            this.Name = "UcAdmin";
            this.Size = new System.Drawing.Size(1182, 596);
            this.metroTabControl1.ResumeLayout(false);
            this.TabPageAddQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.tabPageAddVocabulary.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVocabulary)).EndInit();
            this.pnlinput.ResumeLayout(false);
            this.pnlinput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private static string NewMethod()
        {
            return "vocabulary russian";
        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TabPageAddQuestion;
        private MetroFramework.Controls.MetroTabPage TabPageAddGrammar;
        private MetroFramework.Controls.MetroButton btInsert;
        private MetroFramework.Controls.MetroGrid DataGrid;
        private MetroFramework.Controls.MetroButton btnUpDate;
  
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lever;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerTrue;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grammar;
        private System.Windows.Forms.TabPage tabPageAddVocabulary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlinput;
        private MetroFramework.Controls.MetroTextBox txtvietnamese;
        private MetroFramework.Controls.MetroTextBox txtrussian;
        private MetroFramework.Controls.MetroTextBox txtFile;
        private System.Windows.Forms.FlowLayoutPanel pnlStress;
        private MetroFramework.Controls.MetroComboBox cbTopic;
        private MetroFramework.Controls.MetroGrid DataGridVocabulary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUp;
        private MetroFramework.Controls.MetroButton btninsert;
        private MetroFramework.Controls.MetroButton btnchoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stress;
        private MetroFramework.Controls.MetroButton btnNostress;
    }
}

