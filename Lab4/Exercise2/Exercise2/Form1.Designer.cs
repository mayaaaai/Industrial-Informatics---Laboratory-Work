namespace Exercise2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxRon = new System.Windows.Forms.TextBox();
            this.textBoxEur = new System.Windows.Forms.TextBox();
            this.buttonConv = new System.Windows.Forms.Button();
            this.labelDT = new System.Windows.Forms.Label();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonCtoF = new System.Windows.Forms.Button();
            this.buttonFtoC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(54, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 264);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(91, 342);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add List";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(324, 46);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 2;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(324, 112);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(100, 20);
            this.textBoxF.TabIndex = 3;
            this.textBoxF.TextChanged += new System.EventHandler(this.textBoxF_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(324, 188);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 4;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // textBoxRon
            // 
            this.textBoxRon.Location = new System.Drawing.Point(586, 76);
            this.textBoxRon.Name = "textBoxRon";
            this.textBoxRon.Size = new System.Drawing.Size(100, 20);
            this.textBoxRon.TabIndex = 7;
            this.textBoxRon.TextChanged += new System.EventHandler(this.textBoxRon_TextChanged);
            // 
            // textBoxEur
            // 
            this.textBoxEur.Location = new System.Drawing.Point(586, 154);
            this.textBoxEur.Name = "textBoxEur";
            this.textBoxEur.Size = new System.Drawing.Size(100, 20);
            this.textBoxEur.TabIndex = 8;
            this.textBoxEur.TextChanged += new System.EventHandler(this.textBoxEur_TextChanged);
            // 
            // buttonConv
            // 
            this.buttonConv.Location = new System.Drawing.Point(598, 112);
            this.buttonConv.Name = "buttonConv";
            this.buttonConv.Size = new System.Drawing.Size(75, 23);
            this.buttonConv.TabIndex = 9;
            this.buttonConv.Text = "Convert";
            this.buttonConv.UseVisualStyleBackColor = true;
            this.buttonConv.Click += new System.EventHandler(this.buttonConv_Click);
            // 
            // labelDT
            // 
            this.labelDT.AutoSize = true;
            this.labelDT.Location = new System.Drawing.Point(638, 419);
            this.labelDT.Name = "labelDT";
            this.labelDT.Size = new System.Drawing.Size(53, 13);
            this.labelDT.TabIndex = 10;
            this.labelDT.Text = "DateTime";
            this.labelDT.Click += new System.EventHandler(this.labelDT_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(79, 316);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdd.TabIndex = 11;
            this.textBoxAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // buttonCtoF
            // 
            this.buttonCtoF.Location = new System.Drawing.Point(333, 246);
            this.buttonCtoF.Name = "buttonCtoF";
            this.buttonCtoF.Size = new System.Drawing.Size(75, 23);
            this.buttonCtoF.TabIndex = 12;
            this.buttonCtoF.Text = "CtoF";
            this.buttonCtoF.UseVisualStyleBackColor = true;
            this.buttonCtoF.Click += new System.EventHandler(this.buttonCtoF_Click);
            // 
            // buttonFtoC
            // 
            this.buttonFtoC.Location = new System.Drawing.Point(333, 299);
            this.buttonFtoC.Name = "buttonFtoC";
            this.buttonFtoC.Size = new System.Drawing.Size(75, 23);
            this.buttonFtoC.TabIndex = 13;
            this.buttonFtoC.Text = "FtoC";
            this.buttonFtoC.UseVisualStyleBackColor = true;
            this.buttonFtoC.Click += new System.EventHandler(this.buttonFtoC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFtoC);
            this.Controls.Add(this.buttonCtoF);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.labelDT);
            this.Controls.Add(this.buttonConv);
            this.Controls.Add(this.textBoxEur);
            this.Controls.Add(this.textBoxRon);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxRon;
        private System.Windows.Forms.TextBox textBoxEur;
        private System.Windows.Forms.Button buttonConv;
        private System.Windows.Forms.Label labelDT;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonCtoF;
        private System.Windows.Forms.Button buttonFtoC;
    }
}

