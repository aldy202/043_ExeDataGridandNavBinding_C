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

namespace Exerices
{
    public partial class Form1 : Form
    {
        private SqlCommand cm;
        private DataSet ds;
        private SqlDataAdapter sd;
        private SqlDataReader dr;



        connect con = new connect();

        public Form1()
        {
            InitializeComponent();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = con.Getconn();
            conn.Open();
            cm = new SqlCommand("select * from Admin where Nama = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", conn);
            dr = cm.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {

                this.Hide();
                Menu mn = new Menu();
                mn.Show();
            }

            else
            {
                MessageBox.Show("Your username and password are wrong");
            }



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
