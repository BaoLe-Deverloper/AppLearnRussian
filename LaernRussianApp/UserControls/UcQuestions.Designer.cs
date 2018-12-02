namespace AppLearnRussian
{
    partial class UcQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcQuestions));
            this.pnlQuestions = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMinute = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncheck = new ControlLibrary.CustomImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbsecond = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncheck)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuestions
            // 
            this.pnlQuestions.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            resources.ApplyResources(this.pnlQuestions, "pnlQuestions");
            this.pnlQuestions.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlQuestions.Name = "pnlQuestions";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lbMinute);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btncheck);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbsecond);
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbMinute
            // 
            resources.ApplyResources(this.lbMinute, "lbMinute");
            this.lbMinute.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbMinute.Name = "lbMinute";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Name = "label2";
            // 
            // btncheck
            // 
            resources.ApplyResources(this.btncheck, "btncheck");
            this.btncheck.ImageHover = ((System.Drawing.Image)(resources.GetObject("btncheck.ImageHover")));
            this.btncheck.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btncheck.ImageNormal")));
            this.btncheck.Name = "btncheck";
            this.btncheck.TabStop = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lbsecond
            // 
            resources.ApplyResources(this.lbsecond, "lbsecond");
            this.lbsecond.Name = "lbsecond";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UcQuestions
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.pnlQuestions);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "UcQuestions";
            this.Load += new System.EventHandler(this.UcQuestions_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuestions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbsecond;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private ControlLibrary.CustomImageButton btncheck;
    }
}
