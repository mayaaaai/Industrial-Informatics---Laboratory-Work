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

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\incer\\OneDrive\\Desktop\\lista.txt");

            listBoxTP.BeginUpdate();

            for (int i = 0; i < 3; i++)
            {
                string line = sr.ReadLine();
                listBoxTP.Items.Add(line);
            }

            listBoxTP.EndUpdate();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBoxTP.SelectedItem?.ToString();
            if (selectedItem == "Novak Djokovic")
            {
                pictureBoxTP.Image = Image.FromFile("nole.png");
            }

            else if (selectedItem == "Roger Federer")
            {
                pictureBoxTP.Image = Image.FromFile("roger.png");
            }

            else if (selectedItem == "Rafael Nadal")
            {
                pictureBoxTP.Image = Image.FromFile("rafa.png");
            }

            pictureBoxTP.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void pictureBoxTP_Click(object sender, EventArgs e)
        {


        }

        private void groupBoxTickets_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxSeats_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonSZ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (radioButtonSZ.Checked == true && radioButtonTP.Checked == true)
            {
                MessageBox.Show("Ai cumpărat un bilet la sesiunea de zi cu loc în tribuna principală.");
            }

            if (radioButtonSZ.Checked == true && radioButtonTS.Checked == true)
            {
                MessageBox.Show("Ai cumpărat un bilet la sesiunea de zi cu loc în tribuna de sus.");

            }

            if (radioButtonSZ.Checked == true && radioButtonTT.Checked == true)
            {
                MessageBox.Show("Ai cumpărat un bilet la sesiunea de zi cu loc în tribuna de lângă teren.");

            }

            if (radioButtonSS.Checked == true && radioButtonTP.Checked == true)
            {
                MessageBox.Show("Ai cumpărat un bilet la sesiunea de seară cu loc în tribuna principală.");

            }
            if (radioButtonSS.Checked == true && radioButtonTS.Checked == true)
            {
                MessageBox.Show("Ai cumpărat un bilet la sesiunea de seară cu loc în tribuna de sus. ");
            }

            if (radioButtonSS.Checked == true && radioButtonTT.Checked == true)
            {
                MessageBox.Show("Ai cumpărat un bilet la sesiunea de seară cu loc în tribuna de lângă teren.");
            }
        }
    }
}
