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

namespace PhoneLog
{
    public partial class Phone : Form
    {
        private const string connString = "Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=PhoneLog;Integrated Security=True;Pooling=False";
        SqlConnection con = new SqlConnection(connString);

        public Phone()
        {
            InitializeComponent();
        }

        private void Phone_Load(object sender, EventArgs e)
        {
            //ActiveControl = textBox2;
            //textBox2.Focus();
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlCommand -> insert, update, delete
            //SqlDatareader -> select
            //SqlDataAdapter -> select,insert, update, delete
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO PhoneLogs(FirstName, LastName, Mobile, Email, Category)
                VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
       
            Display();
            MessageBox.Show("Successfully!!!!.......");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlCommand -> insert, update, delete
            //SqlDatareader -> select
            //SqlDataAdapter -> select,insert, update, delete
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from PhoneLogs where (Mobile = '" + textBox3.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            Display();
            MessageBox.Show("Delete Successfully!!!!.......");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SqlCommand -> insert, update, delete
            //SqlDatareader -> select
            //SqlDataAdapter -> select,insert, update, delete
            con.Open();
            SqlCommand cmd = new SqlCommand(@"update PhoneLogs
            set FirstName = '" + textBox1.Text + "', LastName = '" + textBox2.Text + "', Mobile = '" + textBox3.Text + "', Email = '" + textBox4.Text + "', Category = '" + comboBox1.Text + "' where (Mobile = '" + textBox3.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            Display();
            MessageBox.Show(" Successful Update!!!!.......");
        }

        void Display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select *  from PhoneLogs", con);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dta.Rows)
            {
                int n = dataGridView1.Rows.Add();
                for (int i = 0; i < 5; i++)
                {
                    dataGridView1.Rows[n].Cells[i].Value = item[i].ToString();
                }
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //Selection mode should be FULLROWSELECT

            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select *  from PhoneLogs where (Mobile like '" + textBox5.Text + "%') or (FirstName like '%" + textBox5.Text + "%')or (LastName like '%" + textBox5.Text + "%')", con);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dta.Rows)
            {
                int n = dataGridView1.Rows.Add();
                for (int i = 0; i < 5; i++)
                {
                    dataGridView1.Rows[n].Cells[i].Value = item[i].ToString();
                }
            }
        }
    }
}
