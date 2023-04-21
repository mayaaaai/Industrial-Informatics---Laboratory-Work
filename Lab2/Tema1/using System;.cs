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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tema1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "ImprovisedSpotify";
        }

        

        private void btnANS_Click(object sender, EventArgs e)
        {
            listBoxSpotify.BeginUpdate();
            DialogResult dr = this.openFileDialog1.ShowDialog();

            string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
            foreach (string line in lines)
                listBoxSpotify.Items.Add(line);

            listBoxSpotify.EndUpdate();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {


            listBoxPl1.BeginUpdate();
            listBoxPl2.BeginUpdate();

            if (tabControl1.SelectedTab == tabPage1)
            {

                listBoxPl1.Items.Add(listBoxSpotify.SelectedItems[0]);
            }

            else if (tabControl1.SelectedTab == tabPage2)
            {
                listBoxPl2.Items.Add(listBoxSpotify.SelectedItems[0]);
            }

            listBoxPl1.EndUpdate();
            listBoxPl2.EndUpdate();
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            listBoxPl1.BeginUpdate();
            listBoxPl2.BeginUpdate();

            if (tabControl1.SelectedTab == tabPage1)
            {

                listBoxPl1.Items.Remove(listBoxSpotify.SelectedItems[0]);
            }

            else if (tabControl1.SelectedTab == tabPage2)
            {
                listBoxPl2.Items.Remove(listBoxSpotify.SelectedItems[0]);
            }

            listBoxPl1.EndUpdate();
            listBoxPl2.EndUpdate();
        }


        private void textBoxPl1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPl1.Text.Length - 1 > 0 && textBoxPl1.Text[textBoxPl1.Text.Length - 1] == ' ')
            {
                tabPage1.Text = textBoxPl1.Text;
                textBoxPl1.Clear();

            }



        }


        

        private void textBoxPl2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPl2.Text.Length - 1 > 0 && textBoxPl2.Text[textBoxPl2.Text.Length - 1] == ' ')
            {
                tabPage2.Text = textBoxPl2.Text;
                textBoxPl1.Clear();

            }
        }

        
        private void ShufflePlaylist(ListBox listBox)
        {
            Random rd = new Random();

            for (int i = 0; i < (listBox.Items.Count / 2); i++)
            {

                int index = rd.Next(0, listBox.Items.Count);
                int index2 = rd.Next(0, listBox.Items.Count);


                var temp = listBox.Items[index];
                listBox.Items[index] = listBox.Items[index2];
                listBox.Items[index2] = temp;
            }
        }

        private void checkBoxShuffle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShuffle.Checked == true)
            {
                listBoxPl1.BeginUpdate();
                listBoxPl2.BeginUpdate();

                if (tabControl1.SelectedTab == tabPage1)
                {

                    ShufflePlaylist(listBoxPl1);

                }

                else if (tabControl1.SelectedTab == tabPage2)
                {
                    ShufflePlaylist(listBoxPl2);
                }

                listBoxPl1.EndUpdate();
                listBoxPl2.EndUpdate();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("C:\\Users\\incer\\OneDrive\\Desktop\\piese.txt");

            listBoxSpotify.BeginUpdate();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                listBoxSpotify.Items.Add(line);
            }

            listBoxSpotify.EndUpdate();
        }

       



    }
}
