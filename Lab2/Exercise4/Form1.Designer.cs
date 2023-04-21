namespace Exercise4
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxTP = new System.Windows.Forms.ListBox();
            this.pictureBoxTP = new System.Windows.Forms.PictureBox();
            this.groupBoxTickets = new System.Windows.Forms.GroupBox();
            this.groupBoxSeats = new System.Windows.Forms.GroupBox();
            this.radioButtonTP = new System.Windows.Forms.RadioButton();
            this.radioButtonTS = new System.Windows.Forms.RadioButton();
            this.radioButtonTT = new System.Windows.Forms.RadioButton();
            this.radioButtonSS = new System.Windows.Forms.RadioButton();
            this.radioButtonSZ = new System.Windows.Forms.RadioButton();
            this.btnProceed = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTP)).BeginInit();
            this.groupBoxTickets.SuspendLayout();
            this.groupBoxSeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(141, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 316);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBoxTP);
            this.tabPage1.Controls.Add(this.listBoxTP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(506, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnProceed);
            this.tabPage2.Controls.Add(this.groupBoxSeats);
            this.tabPage2.Controls.Add(this.groupBoxTickets);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(506, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listBoxTP
            // 
            this.listBoxTP.FormattingEnabled = true;
            this.listBoxTP.Location = new System.Drawing.Point(15, 25);
            this.listBoxTP.Name = "listBoxTP";
            this.listBoxTP.Size = new System.Drawing.Size(164, 212);
            this.listBoxTP.TabIndex = 0;
            this.listBoxTP.SelectedIndexChanged += new System.EventHandler(this.listBoxTP_SelectedIndexChanged);
            // 
            // pictureBoxTP
            // 
            this.pictureBoxTP.Location = new System.Drawing.Point(203, 25);
            this.pictureBoxTP.Name = "pictureBoxTP";
            this.pictureBoxTP.Size = new System.Drawing.Size(282, 212);
            this.pictureBoxTP.TabIndex = 1;
            this.pictureBoxTP.TabStop = false;
            this.pictureBoxTP.Click += new System.EventHandler(this.pictureBoxTP_Click);
            // 
            // groupBoxTickets
            // 
            this.groupBoxTickets.Controls.Add(this.radioButtonSZ);
            this.groupBoxTickets.Controls.Add(this.radioButtonSS);
            this.groupBoxTickets.Location = new System.Drawing.Point(43, 43);
            this.groupBoxTickets.Name = "groupBoxTickets";
            this.groupBoxTickets.Size = new System.Drawing.Size(188, 179);
            this.groupBoxTickets.TabIndex = 0;
            this.groupBoxTickets.TabStop = false;
            this.groupBoxTickets.Text = "Sesiunea dorită:";
            this.groupBoxTickets.Enter += new System.EventHandler(this.groupBoxTickets_Enter);
            // 
            // groupBoxSeats
            // 
            this.groupBoxSeats.Controls.Add(this.radioButtonTT);
            this.groupBoxSeats.Controls.Add(this.radioButtonTS);
            this.groupBoxSeats.Controls.Add(this.radioButtonTP);
            this.groupBoxSeats.Location = new System.Drawing.Point(263, 43);
            this.groupBoxSeats.Name = "groupBoxSeats";
            this.groupBoxSeats.Size = new System.Drawing.Size(211, 179);
            this.groupBoxSeats.TabIndex = 1;
            this.groupBoxSeats.TabStop = false;
            this.groupBoxSeats.Text = "Locul în tribuna dorită:";
            this.groupBoxSeats.Enter += new System.EventHandler(this.groupBoxSeats_Enter);
            // 
            // radioButtonTP
            // 
            this.radioButtonTP.AutoSize = true;
            this.radioButtonTP.Location = new System.Drawing.Point(6, 36);
            this.radioButtonTP.Name = "radioButtonTP";
            this.radioButtonTP.Size = new System.Drawing.Size(109, 17);
            this.radioButtonTP.TabIndex = 0;
            this.radioButtonTP.TabStop = true;
            this.radioButtonTP.Text = "Tribuna principala";
            this.radioButtonTP.UseVisualStyleBackColor = true;
            this.radioButtonTP.CheckedChanged += new System.EventHandler(this.radioButtonTP_CheckedChanged);
            // 
            // radioButtonTS
            // 
            this.radioButtonTS.AutoSize = true;
            this.radioButtonTS.Location = new System.Drawing.Point(6, 79);
            this.radioButtonTS.Name = "radioButtonTS";
            this.radioButtonTS.Size = new System.Drawing.Size(80, 17);
            this.radioButtonTS.TabIndex = 1;
            this.radioButtonTS.TabStop = true;
            this.radioButtonTS.Text = "Tribuna sus";
            this.radioButtonTS.UseVisualStyleBackColor = true;
            this.radioButtonTS.CheckedChanged += new System.EventHandler(this.radioButtonTS_CheckedChanged);
            // 
            // radioButtonTT
            // 
            this.radioButtonTT.AutoSize = true;
            this.radioButtonTT.Location = new System.Drawing.Point(6, 126);
            this.radioButtonTT.Name = "radioButtonTT";
            this.radioButtonTT.Size = new System.Drawing.Size(88, 17);
            this.radioButtonTT.TabIndex = 2;
            this.radioButtonTT.TabStop = true;
            this.radioButtonTT.Text = "Tribuna teren";
            this.radioButtonTT.UseVisualStyleBackColor = true;
            this.radioButtonTT.CheckedChanged += new System.EventHandler(this.radioButtonTT_CheckedChanged);
            // 
            // radioButtonSS
            // 
            this.radioButtonSS.AutoSize = true;
            this.radioButtonSS.Location = new System.Drawing.Point(6, 107);
            this.radioButtonSS.Name = "radioButtonSS";
            this.radioButtonSS.Size = new System.Drawing.Size(107, 17);
            this.radioButtonSS.TabIndex = 1;
            this.radioButtonSS.TabStop = true;
            this.radioButtonSS.Text = "Sesiune de seara";
            this.radioButtonSS.UseVisualStyleBackColor = true;
            this.radioButtonSS.CheckedChanged += new System.EventHandler(this.radioButtonSS_CheckedChanged);
            // 
            // radioButtonSZ
            // 
            this.radioButtonSZ.AutoSize = true;
            this.radioButtonSZ.Location = new System.Drawing.Point(6, 49);
            this.radioButtonSZ.Name = "radioButtonSZ";
            this.radioButtonSZ.Size = new System.Drawing.Size(88, 17);
            this.radioButtonSZ.TabIndex = 2;
            this.radioButtonSZ.TabStop = true;
            this.radioButtonSZ.Text = "Sesiune de zi";
            this.radioButtonSZ.UseVisualStyleBackColor = true;
            this.radioButtonSZ.CheckedChanged += new System.EventHandler(this.radioButtonSZ_CheckedChanged);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(211, 247);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTP)).EndInit();
            this.groupBoxTickets.ResumeLayout(false);
            this.groupBoxTickets.PerformLayout();
            this.groupBoxSeats.ResumeLayout(false);
            this.groupBoxSeats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxTP;
        private System.Windows.Forms.ListBox listBoxTP;
        private System.Windows.Forms.GroupBox groupBoxSeats;
        private System.Windows.Forms.GroupBox groupBoxTickets;
        private System.Windows.Forms.RadioButton radioButtonTS;
        private System.Windows.Forms.RadioButton radioButtonTP;
        private System.Windows.Forms.RadioButton radioButtonTT;
        private System.Windows.Forms.RadioButton radioButtonSS;
        private System.Windows.Forms.RadioButton radioButtonSZ;
        private System.Windows.Forms.Button btnProceed;
    }
}

