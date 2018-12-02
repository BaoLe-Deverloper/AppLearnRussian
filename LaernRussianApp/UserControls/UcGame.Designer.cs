namespace AppLearnRussian
{
    partial class Game
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.PbSuggestion = new System.Windows.Forms.PictureBox();
            this.btnNext = new ControlLibrary.CustomImageButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbspeed = new MetroFramework.Controls.MetroComboBox();
            this.btnToGame1 = new ControlLibrary.CustomImageButton();
            this.btnStop = new ControlLibrary.CustomImageButton();
            this.btnPlay = new ControlLibrary.CustomImageButton();
            this.customImageButton2 = new ControlLibrary.CustomImageButton();
            this.customImageButton1 = new ControlLibrary.CustomImageButton();
            this.lbVietnamese = new System.Windows.Forms.Label();
            this.lbRussian = new System.Windows.Forms.Label();
            this.btnBack = new ControlLibrary.CustomImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.PbSuggestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToGame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // PbSuggestion
            // 
            this.PbSuggestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbSuggestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbSuggestion.Location = new System.Drawing.Point(191, 22);
            this.PbSuggestion.Name = "PbSuggestion";
            this.PbSuggestion.Size = new System.Drawing.Size(585, 337);
            this.PbSuggestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSuggestion.TabIndex = 0;
            this.PbSuggestion.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageHover")));
            this.btnNext.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageNormal")));
            this.btnNext.Location = new System.Drawing.Point(798, 210);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 88);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNext.TabIndex = 2;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(52)))), ((int)(((byte)(8)))));
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.cbspeed);
            this.pnlMain.Controls.Add(this.btnToGame1);
            this.pnlMain.Controls.Add(this.btnStop);
            this.pnlMain.Controls.Add(this.btnPlay);
            this.pnlMain.Controls.Add(this.customImageButton2);
            this.pnlMain.Controls.Add(this.customImageButton1);
            this.pnlMain.Controls.Add(this.lbVietnamese);
            this.pnlMain.Controls.Add(this.lbRussian);
            this.pnlMain.Controls.Add(this.PbSuggestion);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.btnNext);
            this.pnlMain.Location = new System.Drawing.Point(96, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(998, 589);
            this.pnlMain.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(58, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tốc Độ ";
            // 
            // cbspeed
            // 
            this.cbspeed.FormattingEnabled = true;
            this.cbspeed.ItemHeight = 23;
            this.cbspeed.Items.AddRange(new object[] {
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "3500",
            "4000",
            "5000"});
            this.cbspeed.Location = new System.Drawing.Point(31, 144);
            this.cbspeed.Name = "cbspeed";
            this.cbspeed.Size = new System.Drawing.Size(121, 29);
            this.cbspeed.TabIndex = 6;
            this.cbspeed.UseSelectable = true;
            this.cbspeed.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // btnToGame1
            // 
            this.btnToGame1.Image = ((System.Drawing.Image)(resources.GetObject("btnToGame1.Image")));
            this.btnToGame1.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnToGame1.ImageHover")));
            this.btnToGame1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnToGame1.ImageNormal")));
            this.btnToGame1.Location = new System.Drawing.Point(819, 22);
            this.btnToGame1.Name = "btnToGame1";
            this.btnToGame1.Size = new System.Drawing.Size(141, 60);
            this.btnToGame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnToGame1.TabIndex = 5;
            this.btnToGame1.TabStop = false;
            this.metroToolTip1.SetToolTip(this.btnToGame1, "Nhấp để chuyển sang trò chơi \r\n     với Từ Vựng đã học.");
            this.btnToGame1.Click += new System.EventHandler(this.btnToGame1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnStop.ImageHover")));
            this.btnStop.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnStop.ImageNormal")));
            this.btnStop.Location = new System.Drawing.Point(31, 22);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(141, 60);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 5;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnPlay.ImageHover")));
            this.btnPlay.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnPlay.ImageNormal")));
            this.btnPlay.Location = new System.Drawing.Point(31, 22);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(141, 60);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 5;
            this.btnPlay.TabStop = false;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // customImageButton2
            // 
            this.customImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("customImageButton2.Image")));
            this.customImageButton2.ImageHover = ((System.Drawing.Image)(resources.GetObject("customImageButton2.ImageHover")));
            this.customImageButton2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customImageButton2.ImageNormal")));
            this.customImageButton2.Location = new System.Drawing.Point(799, 476);
            this.customImageButton2.Name = "customImageButton2";
            this.customImageButton2.Size = new System.Drawing.Size(47, 43);
            this.customImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customImageButton2.TabIndex = 4;
            this.customImageButton2.TabStop = false;
            // 
            // customImageButton1
            // 
            this.customImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("customImageButton1.Image")));
            this.customImageButton1.ImageHover = ((System.Drawing.Image)(resources.GetObject("customImageButton1.ImageHover")));
            this.customImageButton1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customImageButton1.ImageNormal")));
            this.customImageButton1.Location = new System.Drawing.Point(798, 372);
            this.customImageButton1.Name = "customImageButton1";
            this.customImageButton1.Size = new System.Drawing.Size(48, 47);
            this.customImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customImageButton1.TabIndex = 4;
            this.customImageButton1.TabStop = false;
            this.customImageButton1.Click += new System.EventHandler(this.customImageButton1_Click);
            // 
            // lbVietnamese
            // 
            this.lbVietnamese.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVietnamese.BackColor = System.Drawing.Color.Coral;
            this.lbVietnamese.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbVietnamese.Font = new System.Drawing.Font("UTM Androgyne", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVietnamese.ForeColor = System.Drawing.Color.SeaShell;
            this.lbVietnamese.Location = new System.Drawing.Point(227, 476);
            this.lbVietnamese.Name = "lbVietnamese";
            this.lbVietnamese.Size = new System.Drawing.Size(521, 57);
            this.lbVietnamese.TabIndex = 3;
            this.lbVietnamese.Text = "label1";
            this.lbVietnamese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRussian
            // 
            this.lbRussian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRussian.BackColor = System.Drawing.Color.Coral;
            this.lbRussian.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbRussian.Font = new System.Drawing.Font("UTM Androgyne", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRussian.ForeColor = System.Drawing.Color.SeaShell;
            this.lbRussian.Location = new System.Drawing.Point(226, 362);
            this.lbRussian.Name = "lbRussian";
            this.lbRussian.Size = new System.Drawing.Size(522, 57);
            this.lbRussian.TabIndex = 3;
            this.lbRussian.Text = "label1";
            this.lbRussian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageHover")));
            this.btnBack.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageNormal")));
            this.btnBack.Location = new System.Drawing.Point(51, 210);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 88);
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.AutoPopDelay = 5000;
            this.metroToolTip1.InitialDelay = 50;
            this.metroToolTip1.ReshowDelay = 50;
            this.metroToolTip1.StripAmpersands = true;
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Tag = "";
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(1198, 595);
            this.Load += new System.EventHandler(this.Game1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbSuggestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToGame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbSuggestion;
        private ControlLibrary.CustomImageButton btnNext;
        private System.Windows.Forms.Panel pnlMain;
        private ControlLibrary.CustomImageButton btnBack;
        private System.Windows.Forms.Label lbRussian;
        private ControlLibrary.CustomImageButton customImageButton2;
        private System.Windows.Forms.Label lbVietnamese;
        private ControlLibrary.CustomImageButton btnPlay;
        private System.Windows.Forms.Timer timer1;
        private ControlLibrary.CustomImageButton btnToGame1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cbspeed;
        private ControlLibrary.CustomImageButton btnStop;
        private ControlLibrary.CustomImageButton customImageButton1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}

