using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2
{
    public partial class Form1 : Form
    {
        ServiceReference2.WebService1SoapClient client = new ServiceReference2.WebService1SoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            var response = client.ReadAsync();
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            foreach (var item in response.Result.Body.ReadResult)
            {
                listBox1.Items.Add(item);
            }

            listBox1.EndUpdate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string name = textBoxName.Text;
            string city = textBoxCity.Text;
            int code = Convert.ToInt32(textBoxCode.Text);

            ServiceReference2.ValueTupleOfInt32StringStringInt32 university = new ServiceReference2.ValueTupleOfInt32StringStringInt32();
            university.Item1 = id;
            university.Item2 = name;
            university.Item3 = city;
            university.Item4 = code;


            var response = client.CreateAsync(university);

            buttonRead_Click(sender, e);



        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {

            string univName = textBoxOName.Text;
            string newName = textBoxNName.Text;



            ServiceReference2.ValueTupleOfStringString UnivUpdate = new ServiceReference2.ValueTupleOfStringString();
            UnivUpdate.Item1 = univName;
            UnivUpdate.Item2 = newName;

            var response = await client.UpdateAsync(UnivUpdate);

            buttonRead_Click(sender, e);
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            string name = textBoxDel.Text;
            var response = await client.DeleteAsync(name);
            buttonRead_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
