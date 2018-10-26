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
    public partial class SearchCustomer : Form
    {
        OracleConnection con1;
        OracleCommand cmd;
        OracleDataAdapter da;
        DataSet d;
        Boolean boolean = false;
        string query;
        int temp, I;
        public SearchCustomer()
        {
            InitializeComponent();
            con1 = new OracleConnection("Data Source=localhost;User ID=alphastay;password=alphastay");
        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CUSTOMER' table. You can move, or remove it, as needed.
            //this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
            dataGridView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (boolean)
            {
                dataGridView1.DataSource = null;
            }
            //this.rOOMTableAdapter.Fill(this.dataSet1.ROOM);
            query = "select * from CUSTOMER";
            cmd = new OracleCommand(query, con1);
            try
            {
                con1.Open();
                da = new OracleDataAdapter(query, con1);
                d = new DataSet();
                da.Fill(d, "test");
                dataGridView1.DataSource = d.Tables[0];
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            //dataGridView1.Enabled = true;
            boolean = true;
            string s = "";
            s = textBox1.Text;
            if (s != "")
            {
                //MessageBox.Show(s);
                query = "select * from CUSTOMER WHERE CUSTOMER_ID = '" + s + " '";
                cmd = new OracleCommand(query, con1);
                try
                {
                    con1.Open();
                    da = new OracleDataAdapter(query, con1);
                    d = new DataSet();
                    da.Fill(d, "test");
                    dataGridView1.DataSource = d.Tables[0];
                    if (dataGridView1.Rows.Count == 1)
                    {
                        MessageBox.Show("No record found");
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                con1.Close();
            }
            else
            {
                MessageBox.Show("Please enter a Customer ID");
            }
        }
    }
}
