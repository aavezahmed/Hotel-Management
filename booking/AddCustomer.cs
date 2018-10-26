using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace booking
{
    public partial class AddCustomer : Form
    {
        OracleConnection con1;
        OracleCommand cmd;
        OracleDataReader rdr;
        string query;
        string s1;

        public AddCustomer()
        {
            InitializeComponent();
            con1 = new OracleConnection("Data Source=localhost;User ID=alphastay;password=alphastay ");
            textBox1.Enabled = false;
            string query2, ID;
            query2 = "Select max(customer_id) from customer";
            con1.Open();
            cmd = new OracleCommand(query2, con1);
            cmd.CommandText = query2;
            ID = Convert.ToString(cmd.ExecuteScalar());
            if (ID.Equals(""))
                textBox1.Text = Convert.ToString(1);
            else
            {
                int s;
                s = Convert.ToInt16(ID) + 1;
                textBox1.Text = Convert.ToString(s);
                s1 = s.ToString();
            }
            con1.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void backb_button_Click(object sender, EventArgs e)
        {
            Home back = new Home();
            back.Show();
            Hide();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            int TEMP = 0;
            textBox2.Focus();
            con1.Open();
            query = "Insert into customer values('" + textBox1.Text + "','" + textBox2.Text + "','" + richTextBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd = new OracleCommand(query, con1);
            try
            {
                TEMP = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }

            if (TEMP > 0)
            {
                string s2 = "new";
                MessageBox.Show(" RECORD ADDED SUCESSFULLY");
                Home r = new Home();
                r.Show();
                this.Hide();
            }


            else
                MessageBox.Show("INSERT OPERATION FAILED ");
            con1.Close();

        }
    

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
