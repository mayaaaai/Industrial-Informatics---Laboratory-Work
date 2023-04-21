namespace Lab3
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
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.textBox1CU = new System.Windows.Forms.TextBox();
            this.textBox2Oras = new System.Windows.Forms.TextBox();
            this.listBoxUniv = new System.Windows.Forms.ListBox();
            this.listBoxFac = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.labelcity = new System.Windows.Forms.Label();
            this.labelcode = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxCU = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(651, 300);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 1;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(156, 300);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // textBox1CU
            // 
            this.textBox1CU.Location = new System.Drawing.Point(258, 232);
            this.textBox1CU.Name = "textBox1CU";
            this.textBox1CU.Size = new System.Drawing.Size(227, 20);
            this.textBox1CU.TabIndex = 5;
            this.textBox1CU.TextChanged += new System.EventHandler(this.textBox1CU_TextChanged);
            // 
            // textBox2Oras
            // 
            this.textBox2Oras.Location = new System.Drawing.Point(258, 183);
            this.textBox2Oras.Name = "textBox2Oras";
            this.textBox2Oras.Size = new System.Drawing.Size(227, 20);
            this.textBox2Oras.TabIndex = 6;
            this.textBox2Oras.TextChanged += new System.EventHandler(this.textBox2Oras_TextChanged);
            // 
            // listBoxUniv
            // 
            this.listBoxUniv.FormattingEnabled = true;
            this.listBoxUniv.Location = new System.Drawing.Point(70, 39);
            this.listBoxUniv.Name = "listBoxUniv";
            this.listBoxUniv.Size = new System.Drawing.Size(161, 225);
            this.listBoxUniv.TabIndex = 7;
            this.listBoxUniv.SelectedIndexChanged += new System.EventHandler(this.listBoxUniv_SelectedIndexChanged);
            // 
            // listBoxFac
            // 
            this.listBoxFac.FormattingEnabled = true;
            this.listBoxFac.Location = new System.Drawing.Point(258, 39);
            this.listBoxFac.Name = "listBoxFac";
            this.listBoxFac.Size = new System.Drawing.Size(227, 95);
            this.listBoxFac.TabIndex = 8;
            this.listBoxFac.SelectedIndexChanged += new System.EventHandler(this.listBoxFac_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Universități";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Facultăți";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Oraș";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cod Universitar";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(558, 300);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 13;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(551, 167);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(38, 13);
            this.labelname.TabIndex = 17;
            this.labelname.Text = "Nume:";
            // 
            // labelcity
            // 
            this.labelcity.AutoSize = true;
            this.labelcity.Location = new System.Drawing.Point(551, 202);
            this.labelcity.Name = "labelcity";
            this.labelcity.Size = new System.Drawing.Size(32, 13);
            this.labelcity.TabIndex = 18;
            this.labelcity.Text = "Oraș:";
            // 
            // labelcode
            // 
            this.labelcode.AutoSize = true;
            this.labelcode.Location = new System.Drawing.Point(551, 241);
            this.labelcode.Name = "labelcode";
            this.labelcode.Size = new System.Drawing.Size(82, 13);
            this.labelcode.TabIndex = 19;
            this.labelcode.Text = "Cod Universitar:";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(70, 300);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 20;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(512, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 134);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(554, 183);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(172, 20);
            this.textBoxName.TabIndex = 22;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(554, 218);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(172, 20);
            this.textBoxCity.TabIndex = 23;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // textBoxCU
            // 
            this.textBoxCU.Location = new System.Drawing.Point(554, 257);
            this.textBoxCU.Name = "textBoxCU";
            this.textBoxCU.Size = new System.Drawing.Size(172, 20);
            this.textBoxCU.TabIndex = 24;
            this.textBoxCU.TextChanged += new System.EventHandler(this.textBoxCU_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 518);
            this.Controls.Add(this.textBoxCU);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.labelcode);
            this.Controls.Add(this.labelcity);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFac);
            this.Controls.Add(this.listBoxUniv);
            this.Controls.Add(this.textBox2Oras);
            this.Controls.Add(this.textBox1CU);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox textBox1CU;
        private System.Windows.Forms.TextBox textBox2Oras;
        private System.Windows.Forms.ListBox listBoxUniv;
        private System.Windows.Forms.ListBox listBoxFac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelcity;
        private System.Windows.Forms.Label labelcode;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxCU;
    }
}

