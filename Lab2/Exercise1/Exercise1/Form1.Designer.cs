namespace Exercise1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginBtn = new Button();
            lblLoginT = new Label();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(333, 269);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // lblLoginT
            // 
            lblLoginT.AutoSize = true;
            lblLoginT.Location = new Point(344, 114);
            lblLoginT.Name = "lblLoginT";
            lblLoginT.Size = new Size(0, 15);
            lblLoginT.TabIndex = 3;
            lblLoginT.Click += lblLoginT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 441);
            Controls.Add(lblLoginT);
            Controls.Add(loginBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loginBtn;
        private Label lblLoginT;
    }
}