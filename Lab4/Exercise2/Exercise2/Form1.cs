using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form

    {
        ServiceReference4.WebService1SoapClient client = new ServiceReference4.WebService1SoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var response = client.GetDateAsync();
            labelDT.Text = response.Result.Body.GetDateResult;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var response = client.DisplayElementsAsync(textBoxAdd.Text);
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            foreach (var item in response.Result.Body.DisplayElementsResult)
            {
                listBox1.Items.Add(item);
            }

            listBox1.EndUpdate();
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRon_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConv_Click(object sender, EventArgs e)
        {
            var response = client.ConvertRONtoEUROAsync(Convert.ToDouble(textBoxRon.Text));
            textBoxEur.Text = response.Result.ToString();
        }

        private void textBoxEur_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDT_Click(object sender, EventArgs e)
        {

        }

        private void buttonCtoF_Click(object sender, EventArgs e)
        {
            var response = client.ConvertTempAsync(Convert.ToDouble(textBoxC.Text), "C");
            textBoxResult.Text = response.Result.Body.ConvertTempResult.ToString();
        }

        private void buttonFtoC_Click(object sender, EventArgs e)
        {
            var response = client.ConvertTempAsync(Convert.ToDouble(textBoxF.Text), "F");
            textBoxResult.Text = response.Result.Body.ConvertTempResult.ToString();
        }
    }
}
