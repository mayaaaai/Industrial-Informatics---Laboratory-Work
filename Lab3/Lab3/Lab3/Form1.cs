using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Diagnostics.Eventing.Reader;

namespace Lab3
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=Lab3-II;Persist Security Info=True;User ID=sa;Password=sA-12345");
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxUniv_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM dbo.Facultati JOIN dbo.Universitati ON dbo.Universitati.Code = dbo.Facultati.Code WHERE dbo.Universitati.Code = dbo.Facultati.Code AND dbo.Universitati.NameUniv = \'" + listBoxUniv.SelectedItems[0].ToString() + "\'", connection);
            SqlDataReader reader = comm.ExecuteReader();

            listBoxFac.BeginUpdate();
            listBoxFac.Items.Clear();

            while (reader.Read())
            {
                listBoxFac.Items.Add(reader["NameFac"].ToString());
                textBox2Oras.Text = reader["City"].ToString();
                textBox1CU.Text = reader["Code"].ToString();
            }
            listBoxFac.EndUpdate();
            connection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string univname = listBoxUniv.SelectedItem.ToString();

            connection.Open();
            SqlCommand comm = new SqlCommand("DELETE FROM dbo.Universitati WHERE NameUniv=@NameUniv", connection);
            comm.Parameters.AddWithValue("@NameUniv", univname);

            comm.ExecuteNonQuery();
            connection.Close();

            listBoxUniv.Items.Clear();
            buttonRead_Click(sender, e);


        }

        private void listBoxFac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2Oras_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1CU_TextChanged(object sender, EventArgs e)
        {

        }



        private void add_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand comm1 = new SqlCommand("SELECT MAX(id) FROM Universitati", connection);
            int lastid = (int)comm1.ExecuteScalar();
            int newid = lastid + 1;


            SqlCommand comm = new SqlCommand("INSERT INTO dbo.Universitati (id,NameUniv,City,Code) VALUES (@id,@NameUniv, @City, @Code)", connection);

            comm.Parameters.AddWithValue("@id", newid);
            comm.Parameters.AddWithValue("@NameUniv", textBoxName.Text);
            comm.Parameters.AddWithValue("@City", textBoxCity.Text);
            comm.Parameters.AddWithValue("@Code", textBoxCU.Text);

            comm.ExecuteNonQuery();


            connection.Close();

            listBoxUniv.Items.Clear();
            buttonRead_Click(sender, e);


        }

        private void update_Click(object sender, EventArgs e)
        {
            string univname = listBoxUniv.SelectedItem.ToString();
            string newName = textBoxName.Text;
            string city = textBoxCity.Text;
            string code = textBoxCU.Text;

            connection.Open();
            SqlCommand comm = new SqlCommand("UPDATE dbo.Universitati SET dbo.Universitati.NameUniv = @NameUniv, City=@City, Code=@Code WHERE NameUniv=@SelectedName", connection);

            comm.Parameters.AddWithValue("@SelectedName", univname);
            comm.Parameters.AddWithValue("@NameUniv", newName);
            comm.Parameters.AddWithValue("@City", city);
            comm.Parameters.AddWithValue("@Code", code);
            comm.ExecuteNonQuery();


            connection.Close();


            listBoxUniv.Items.Clear();
            buttonRead_Click(sender, e);




        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM dbo.Universitati", connection);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                listBoxUniv.Items.Add(reader["NameUniv"].ToString());
            }

            connection.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Add"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow newRow = dataGridView1.Rows[e.RowIndex];
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                string name = newRow.Cells["NameFac"].Value.ToString();
                string code = newRow.Cells["Code"].Value.ToString();


                using (connection)
                {
                    connection.Open();
                    SqlCommand comm = new SqlCommand("INSERT INTO dbo.Facultati (id,Code,NameFac) VALUES (@id,@Code,@NameFac)", connection);
                    comm.Parameters.AddWithValue("@id", id);
                    comm.Parameters.AddWithValue("@Code", code);
                    comm.Parameters.AddWithValue("@NameFac", name);
                    comm.ExecuteNonQuery();
                    connection.Close();
                }


                LoadViewGrid();


            }

            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                using (connection)
                {
                    connection.Open();
                    SqlCommand comm = new SqlCommand("DELETE FROM Facultati WHERE id=@id", connection);
                    comm.Parameters.AddWithValue("@id", id);
                    comm.ExecuteNonQuery();
                    connection.Close();


                }

                dataGridView1.Rows.RemoveAt(e.RowIndex);
                LoadViewGrid();

            }



        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCU_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadViewGrid()
        {
            string conn = "Data Source=127.0.0.1,1433;Initial Catalog=Lab3-II;Persist Security Info=True;User ID=sa;Password=sA-12345";
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Facultati", conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Facultati");

            dataGridView1.DataSource = dataSet.Tables["Facultati"];


            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            addButton.Name = "Add";
            addButton.HeaderText = "Add";
            addButton.Text = "Add";
            addButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(addButton);


            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButton);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            LoadViewGrid();




        }
    }
}
