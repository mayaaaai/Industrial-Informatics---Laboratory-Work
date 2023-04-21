using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{

    public partial class Form1 : Form
    {
        float num1;
        float num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Add":
                    textBoxRes.Text = (num1 + num2).ToString();
                    break;
                case "Substract":
                    textBoxRes.Text = (num1 - num2).ToString();
                    break;
                case "Multiply":
                    textBoxRes.Text = (num1 * num2).ToString();
                    break;
                case "Divide":
                    textBoxRes.Text = (num1 / num2).ToString();
                    break;
                case "Exit":
                    this.Close();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNum1_TextChanged(object sender, EventArgs e)
        {
            num1 = (float)Convert.ToInt32(textBoxNum1.Text);


        }

        private void textBoxNum2_TextChanged(object sender, EventArgs e)
        {
            num2 = (float)Convert.ToInt32(textBoxNum2.Text);

        }

        private void textBoxRes_TextChanged(object sender, EventArgs e)
        {

        }
        private bool flag;
        private void btnClear_Click(object sender, EventArgs e)
        {
            int val;
            if (flag == false)

                flag = true;
            try
            {
                val = System.Convert.ToInt32(textBoxNum1.Text);
            }

            catch
            {
                MessageBox.Show("Input string was not in a correct format.");
                textBoxNum1.Clear();
                textBoxNum2.Clear();
                textBoxRes.Clear();
            }

            flag = false;



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
