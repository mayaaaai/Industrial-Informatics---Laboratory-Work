namespace Tema1
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
            this.listBoxSpotify = new System.Windows.Forms.ListBox();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnRmv = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxPl1 = new System.Windows.Forms.ListBox();
            this.listBoxPl2 = new System.Windows.Forms.ListBox();
            this.textBoxPl1 = new System.Windows.Forms.TextBox();
            this.textBoxPl2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnANS = new System.Windows.Forms.Button();
            this.checkBoxShuffle = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSpotify
            // 
            this.listBoxSpotify.FormattingEnabled = true;
            this.listBoxSpotify.Location = new System.Drawing.Point(105, 49);
            this.listBoxSpotify.Name = "listBoxSpotify";
            this.listBoxSpotify.Size = new System.Drawing.Size(172, 316);
            this.listBoxSpotify.TabIndex = 1;
            this.listBoxSpotify.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(320, 111);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(75, 23);
            this.btnLike.TabIndex = 2;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnRmv
            // 
            this.btnRmv.Location = new System.Drawing.Point(320, 187);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(75, 23);
            this.btnRmv.TabIndex = 3;
            this.btnRmv.Text = "Remove";
            this.btnRmv.UseVisualStyleBackColor = true;
            this.btnRmv.Click += new System.EventHandler(this.btnRmv_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(424, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(244, 344);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxPl1);
            this.tabPage1.Controls.Add(this.listBoxPl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(236, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxPl2);
            this.tabPage2.Controls.Add(this.listBoxPl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(236, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listBoxPl1
            // 
            this.listBoxPl1.FormattingEnabled = true;
            this.listBoxPl1.Location = new System.Drawing.Point(36, 30);
            this.listBoxPl1.Name = "listBoxPl1";
            this.listBoxPl1.Size = new System.Drawing.Size(173, 277);
            this.listBoxPl1.TabIndex = 0;
            this.listBoxPl1.SelectedIndexChanged += new System.EventHandler(this.listBoxPl1_SelectedIndexChanged);
            // 
            // listBoxPl2
            // 
            this.listBoxPl2.FormattingEnabled = true;
            this.listBoxPl2.Location = new System.Drawing.Point(36, 32);
            this.listBoxPl2.Name = "listBoxPl2";
            this.listBoxPl2.Size = new System.Drawing.Size(173, 277);
            this.listBoxPl2.TabIndex = 1;
            this.listBoxPl2.SelectedIndexChanged += new System.EventHandler(this.listBoxPl2_SelectedIndexChanged);
            // 
            // textBoxPl1
            // 
            this.textBoxPl1.Location = new System.Drawing.Point(4, 4);
            this.textBoxPl1.Name = "textBoxPl1";
            this.textBoxPl1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPl1.TabIndex = 1;
            this.textBoxPl1.TextChanged += new System.EventHandler(this.textBoxPl1_TextChanged);
            // 
            // textBoxPl2
            // 
            this.textBoxPl2.Location = new System.Drawing.Point(6, 6);
            this.textBoxPl2.Name = "textBoxPl2";
            this.textBoxPl2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPl2.TabIndex = 2;
            this.textBoxPl2.TextChanged += new System.EventHandler(this.textBoxPl2_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnANS
            // 
            this.btnANS.Location = new System.Drawing.Point(105, 382);
            this.btnANS.Name = "btnANS";
            this.btnANS.Size = new System.Drawing.Size(172, 23);
            this.btnANS.TabIndex = 7;
            this.btnANS.Text = "Add New Song From Computer";
            this.btnANS.UseVisualStyleBackColor = true;
            this.btnANS.Click += new System.EventHandler(this.btnANS_Click);
            // 
            // checkBoxShuffle
            // 
            this.checkBoxShuffle.AutoSize = true;
            this.checkBoxShuffle.Location = new System.Drawing.Point(464, 387);
            this.checkBoxShuffle.Name = "checkBoxShuffle";
            this.checkBoxShuffle.Size = new System.Drawing.Size(59, 17);
            this.checkBoxShuffle.TabIndex = 8;
            this.checkBoxShuffle.Text = "Shuffle";
            this.checkBoxShuffle.UseVisualStyleBackColor = true;
            this.checkBoxShuffle.CheckedChanged += new System.EventHandler(this.checkBoxShuffle_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxShuffle);
            this.Controls.Add(this.btnANS);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRmv);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.listBoxSpotify);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSpotify;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxPl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxPl1;
        private System.Windows.Forms.TextBox textBoxPl2;
        private System.Windows.Forms.ListBox listBoxPl2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnANS;
        private System.Windows.Forms.CheckBox checkBoxShuffle;
    }
}

