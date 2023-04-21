using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form1"].Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            StreamReader str = new StreamReader("C:\\Users\\incer\\OneDrive\\Desktop\\login.txt");
            string line = str.ReadLine();
            string[] uspsw = line.Split(':');

            lblHello.Text = "Welcome, " + uspsw[0] + " 0_0";
        }
    }
}
