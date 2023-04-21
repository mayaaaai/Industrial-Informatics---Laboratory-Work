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

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxLT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxRT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\incer\\OneDrive\\Desktop\\lista.txt");

            listBoxLT.BeginUpdate();

            for (int i = 0; i < 3; i++)
            {
                string line = sr.ReadLine();
                listBoxLT.Items.Add(line);


            }

            listBoxLT.EndUpdate();


        }

        private void btnCpy_Click(object sender, EventArgs e)
        {
            listBoxRT.BeginUpdate();


            listBoxRT.Items.Add(listBoxLT.SelectedItems[0]);


            listBoxRT.EndUpdate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBoxRT.BeginUpdate();


            listBoxRT.Items.Remove(listBoxRT.SelectedItems[0]);


            listBoxRT.EndUpdate();
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
