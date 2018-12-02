namespace AppLearnRussian
{
    partial class Game1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            this.btnOK = new System.Windows.Forms.PictureBox();
            this.btnNext = new ControlLibrary.CustomImageButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btncheck = new ControlLibrary.CustomImageButton();
            this.btnClose = new ControlLibrary.CustomImageButton();
            this.GrbSuggestion = new System.Windows.Forms.GroupBox();
            this.pnlSuggestion = new System.Windows.Forms.Panel();
            this.GrbAnswer = new System.Windows.Forms.GroupBox();
            this.btnSuggestion = new ControlLibrary.CustomImageButton();
            this.customImageButton1 = new ControlLibrary.CustomImageButton();
            this.lb1 = new System.Windows.Forms.Label();
            this.customImageButton4 = new ControlLibrary.CustomImageButton();
            this.btnBack = new ControlLibrary.CustomImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.GrbSuggestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSuggestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(264, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(495, 276);
            this.btnOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOK.TabIndex = 0;
            this.btnOK.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageHover")));
            this.btnNext.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageNormal")));
            this.btnNext.Location = new System.Drawing.Point(790, 121);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 83);
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
            this.pnlMain.Controls.Add(this.btncheck);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.GrbSuggestion);
            this.pnlMain.Controls.Add(this.GrbAnswer);
            this.pnlMain.Controls.Add(this.btnSuggestion);
            this.pnlMain.Controls.Add(this.customImageButton1);
            this.pnlMain.Controls.Add(this.lb1);
            this.pnlMain.Controls.Add(this.btnOK);
            this.pnlMain.Controls.Add(this.customImageButton4);
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
            this.label1.Font = new System.Drawing.Font("UTM Androgyne", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(806, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhấn để kiểm tra";
            // 
            // btncheck
            // 
            this.btncheck.Image = ((System.Drawing.Image)(resources.GetObject("btncheck.Image")));
            this.btncheck.ImageHover = ((System.Drawing.Image)(resources.GetObject("btncheck.ImageHover")));
            this.btncheck.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btncheck.ImageNormal")));
            this.btncheck.Location = new System.Drawing.Point(842, 237);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(103, 69);
            this.btncheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncheck.TabIndex = 6;
            this.btncheck.TabStop = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageHover")));
            this.btnClose.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageNormal")));
            this.btnClose.Location = new System.Drawing.Point(855, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 50);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GrbSuggestion
            // 
            this.GrbSuggestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbSuggestion.Controls.Add(this.pnlSuggestion);
            this.GrbSuggestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrbSuggestion.Font = new System.Drawing.Font("UTM Cookies", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbSuggestion.ForeColor = System.Drawing.Color.SpringGreen;
            this.GrbSuggestion.Location = new System.Drawing.Point(159, 455);
            this.GrbSuggestion.Name = "GrbSuggestion";
            this.GrbSuggestion.Size = new System.Drawing.Size(690, 134);
            this.GrbSuggestion.TabIndex = 5;
            this.GrbSuggestion.TabStop = false;
            this.GrbSuggestion.Text = "Gợi Ý";
            // 
            // pnlSuggestion
            // 
            this.pnlSuggestion.ForeColor = System.Drawing.Color.DarkGreen;
            this.pnlSuggestion.Location = new System.Drawing.Point(6, 30);
            this.pnlSuggestion.Name = "pnlSuggestion";
            this.pnlSuggestion.Size = new System.Drawing.Size(678, 89);
            this.pnlSuggestion.TabIndex = 0;
            // 
            // GrbAnswer
            // 
            this.GrbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GrbAnswer.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbAnswer.ForeColor = System.Drawing.Color.Orange;
            this.GrbAnswer.Location = new System.Drawing.Point(159, 331);
            this.GrbAnswer.Name = "GrbAnswer";
            this.GrbAnswer.Size = new System.Drawing.Size(690, 125);
            this.GrbAnswer.TabIndex = 5;
            this.GrbAnswer.TabStop = false;
            this.GrbAnswer.Text = "Đáp Án";
            // 
            // btnSuggestion
            // 
            this.btnSuggestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuggestion.Image = ((System.Drawing.Image)(resources.GetObject("btnSuggestion.Image")));
            this.btnSuggestion.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnSuggestion.ImageHover")));
            this.btnSuggestion.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnSuggestion.ImageNormal")));
            this.btnSuggestion.Location = new System.Drawing.Point(883, 473);
            this.btnSuggestion.Name = "btnSuggestion";
            this.btnSuggestion.Size = new System.Drawing.Size(47, 39);
            this.btnSuggestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSuggestion.TabIndex = 4;
            this.btnSuggestion.TabStop = false;
            this.btnSuggestion.Click += new System.EventHandler(this.btnSuggestion_Click);
            // 
            // customImageButton1
            // 
            this.customImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("customImageButton1.Image")));
            this.customImageButton1.ImageHover = ((System.Drawing.Image)(resources.GetObject("customImageButton1.ImageHover")));
            this.customImageButton1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customImageButton1.ImageNormal")));
            this.customImageButton1.Location = new System.Drawing.Point(883, 411);
            this.customImageButton1.Name = "customImageButton1";
            this.customImageButton1.Size = new System.Drawing.Size(47, 45);
            this.customImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customImageButton1.TabIndex = 4;
            this.customImageButton1.TabStop = false;
            this.customImageButton1.Click += new System.EventHandler(this.customImageButton1_Click);
            // 
            // lb1
            // 
            this.lb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1.BackColor = System.Drawing.Color.Coral;
            this.lb1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb1.Font = new System.Drawing.Font("UTM Androgyne", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.SeaShell;
            this.lb1.Location = new System.Drawing.Point(264, 286);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(495, 42);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "label1";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customImageButton4
            // 
            this.customImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("customImageButton4.Image")));
            this.customImageButton4.ImageHover = ((System.Drawing.Image)(resources.GetObject("customImageButton4.ImageHover")));
            this.customImageButton4.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customImageButton4.ImageNormal")));
            this.customImageButton4.Location = new System.Drawing.Point(-553, 86);
            this.customImageButton4.Name = "customImageButton4";
            this.customImageButton4.Size = new System.Drawing.Size(62, 54);
            this.customImageButton4.TabIndex = 2;
            this.customImageButton4.TabStop = false;
            this.customImageButton4.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageHover")));
            this.btnBack.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageNormal")));
            this.btnBack.Location = new System.Drawing.Point(124, 121);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 83);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "Game1";
            this.Size = new System.Drawing.Size(1198, 595);
            this.Load += new System.EventHandler(this.Game1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.GrbSuggestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSuggestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnOK;
        private ControlLibrary.CustomImageButton btnNext;
        private System.Windows.Forms.Panel pnlMain;
        private ControlLibrary.CustomImageButton btnBack;
        private System.Windows.Forms.Label lb1;
        private ControlLibrary.CustomImageButton btnSuggestion;
        private ControlLibrary.CustomImageButton customImageButton1;
        private System.Windows.Forms.GroupBox GrbSuggestion;
        private System.Windows.Forms.GroupBox GrbAnswer;
        private System.Windows.Forms.Panel pnlSuggestion;
        private ControlLibrary.CustomImageButton btnClose;
        private ControlLibrary.CustomImageButton customImageButton4;
        private ControlLibrary.CustomImageButton btncheck;
        private System.Windows.Forms.Label label1;
    }
}
