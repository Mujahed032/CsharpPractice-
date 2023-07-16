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


namespace WindowsFormsToConnectDatabase
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-MFK0N4P;Initial Catalog=MyDb;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);

            con.Open();

            string FirstName = TbFirstName.Text;
            string SecondName = TbSecondName.Text;

            string Query = "insert into names (FirstName, SecondName) Values ('"+FirstName+"', '"+SecondName+"')";

            SqlCommand cmd = new SqlCommand(Query, con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data has been saved");
            
        }
    }
}
