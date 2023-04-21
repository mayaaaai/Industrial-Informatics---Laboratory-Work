using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection connection = new SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=Lab3-II;Persist Security Info=True;User ID=sa;Password=sA-12345");

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        //Read Operation
        [WebMethod]

        public List<string> Read()
        {
            connection.Open();

            SqlCommand comm = new SqlCommand("SELECT * FROM dbo.Universitati", connection);
            SqlDataReader reader = comm.ExecuteReader();

            List<string> text = new List<string>();
            while (reader.Read())
            {
                text.Add(reader["NameUniv"].ToString());

            }

            connection.Close();

            return text;
        }


        //Create Operation
        [WebMethod]
        public void Create((int, string, string, int) Univ)
        {
            connection.Open();

            SqlCommand comm1 = new SqlCommand("SELECT MAX(id) FROM Universitati", connection);
            int lastid = (int)comm1.ExecuteScalar();
            int newid = lastid + 1;


            SqlCommand comm = new SqlCommand("INSERT INTO dbo.Universitati (id,NameUniv,City,Code) VALUES (@id,@NameUniv, @City, @Code)", connection);

            comm.Parameters.AddWithValue("@id", Univ.Item1);
            comm.Parameters.AddWithValue("@NameUniv", Univ.Item2);
            comm.Parameters.AddWithValue("@City", Univ.Item3);
            comm.Parameters.AddWithValue("@Code", Univ.Item4);

            comm.ExecuteNonQuery();


            connection.Close();

        }

        //Update Operation
        [WebMethod]
        public void Update((string, string) UpdateUniv)
        {

            string univname = UpdateUniv.Item1;
            string newName = UpdateUniv.Item2;


            connection.Open();
            SqlCommand comm = new SqlCommand("UPDATE dbo.Universitati SET dbo.Universitati.NameUniv = @NameUniv WHERE NameUniv=@SelectedName", connection);

            comm.Parameters.AddWithValue("@SelectedName", univname);
            comm.Parameters.AddWithValue("@NameUniv", newName);

            comm.ExecuteNonQuery();


            connection.Close();

        }

        //Delete Operation
        [WebMethod]
        public void Delete(string name)
        {


            connection.Open();
            SqlCommand comm = new SqlCommand("DELETE FROM dbo.Universitati WHERE NameUniv=@NameUniv", connection);
            comm.Parameters.AddWithValue("@NameUniv", name);

            comm.ExecuteNonQuery();
            connection.Close();

        }
    }
}
