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
   
    public partial class ModifyCustomer : Form
    {
        OracleConnection con1;
        OracleCommand cmd;
        string query;
        int temp, I;
        OracleDataReader reader2;
   
        public ModifyCustomer()   
        {
            InitializeComponent();
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            richTextBox1.Visible = true;
         
        }

        private void NSEARCH()
{
    textBox1.Visible = false;
    textBox2.Visible = false;
    textBox3.Visible = false;
    textBox4.Visible = false;
    richTextBox1.Visible = false;
   
}



private void modify1_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)

                MessageBox.Show("SEARCH THE RECORD", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                DialogResult dr;
                dr = MessageBox.Show("ARE YOU SURE YOU WANT TO MODIFY THE RECORD?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    query = "Update customer Set NAME='" + textBox2.Text + "',CONTACT_NO='" + textBox3.Text + "',ADDRESS='" + richTextBox1.Text + "',EMAIL_ID='" + textBox4.Text + "' Where CUSTOMER_ID='" + textBox1.Text + "'";

                    cmd = new OracleCommand(query, con1);
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        con1.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record updated successfully", "MESSAGE");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }

                    finally
                    {
                        con1.Close();

                    }
                }
                con1.Close();

            }

            NSEARCH();

        }

        private void back_button_Click(object sender, EventArgs e)
        {
           
                SearchCustomer sc = new SearchCustomer();
                sc.Show();
                Hide();
        }

        private void ModifyCustomer_Load(object sender, EventArgs e)
        {

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

        private void search_button_Click(object sender, EventArgs e)
        {
          //  ModifyCustomer SBAR;
            if (textBox1.Text == "" || textBox1.Text == " ")
                MessageBox.Show("ENTER THE ID TO BE SEARCHED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                string search = " ";
                int flag = 0;
                con1 = new OracleConnection("Data Source=localhost;User ID=alphastay;password=alphastay");
                search = "select * from customer where CUSTOMER_ID='" + textBox1.Text + "' ";
                cmd = new OracleCommand(search, con1);
                con1.Open();
                reader2 = cmd.ExecuteReader();

                while (reader2.Read())
                {
                    //textBox1.Text = Convert.ToString(reader2["CUSTOMER_ID"]);
                    textBox2.Text = Convert.ToString(reader2["NAME"]);
                    textBox3.Text = Convert.ToString(reader2["CONTACT_NO"]);
                    textBox4.Text = Convert.ToString(reader2["EMAIL_ID"]);
                    richTextBox1.Text = Convert.ToString(reader2["ADDRESS"]);
                    flag = 1;
                }
                if (flag == 0)
                {
                    MessageBox.Show(" Record not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NSEARCH();

                }
                reader2.Close();
                con1.Close();
               // textBox1.Text = " ";
               // textBox1.Focus();
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
