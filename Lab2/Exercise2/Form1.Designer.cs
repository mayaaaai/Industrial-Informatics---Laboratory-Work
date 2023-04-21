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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExt = new System.Windows.Forms.Button();
            this.btnCpy = new System.Windows.Forms.Button();
            this.listBoxRT = new System.Windows.Forms.ListBox();
            this.listBoxLT = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(355, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExt
            // 
            this.btnExt.Location = new System.Drawing.Point(355, 402);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(75, 23);
            this.btnExt.TabIndex = 9;
            this.btnExt.Text = "Exit";
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // btnCpy
            // 
            this.btnCpy.Location = new System.Drawing.Point(355, 113);
            this.btnCpy.Name = "btnCpy";
            this.btnCpy.Size = new System.Drawing.Size(75, 23);
            this.btnCpy.TabIndex = 8;
            this.btnCpy.Text = "Copy";
            this.btnCpy.UseVisualStyleBackColor = true;
            this.btnCpy.Click += new System.EventHandler(this.btnCpy_Click);
            // 
            // listBoxRT
            // 
            this.listBoxRT.FormattingEnabled = true;
            this.listBoxRT.Location = new System.Drawing.Point(512, 43);
            this.listBoxRT.Name = "listBoxRT";
            this.listBoxRT.Size = new System.Drawing.Size(211, 251);
            this.listBoxRT.TabIndex = 7;
            this.listBoxRT.SelectedIndexChanged += new System.EventHandler(this.listBoxRT_SelectedIndexChanged);
            // 
            // listBoxLT
            // 
            this.listBoxLT.FormattingEnabled = true;
            this.listBoxLT.Location = new System.Drawing.Point(65, 43);
            this.listBoxLT.Name = "listBoxLT";
            this.listBoxLT.Size = new System.Drawing.Size(211, 251);
            this.listBoxLT.TabIndex = 6;
            this.listBoxLT.SelectedIndexChanged += new System.EventHandler(this.listBoxLT_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.btnCpy);
            this.Controls.Add(this.listBoxRT);
            this.Controls.Add(this.listBoxLT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Button btnCpy;
        private System.Windows.Forms.ListBox listBoxRT;
        private System.Windows.Forms.ListBox listBoxLT;
    }
}

