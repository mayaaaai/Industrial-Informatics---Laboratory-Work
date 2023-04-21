using System.IO;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            StreamReader str = new StreamReader("C:\\Users\\incer\\OneDrive\\Desktop\\login.txt");
            string line = str.ReadLine();
            string[] uspsw = line.Split(':');

            if (uspsw[0] == "mayaaaai" && uspsw[1] == "parola12")
            {

                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();




            }
            else
            {
                lblLoginT.Text = "Login failed!";
            }
        }

        private void lblLoginT_Click(object sender, EventArgs e)
        {

        }
    }
}