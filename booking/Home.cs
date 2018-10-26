using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace booking
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addCustomer_button_Click(object sender, EventArgs e)
        {
            AddCustomer op = new AddCustomer();
            op.Show();
            Hide();
        }

        private void checkIN_button_Click(object sender, EventArgs e)
        {

        }

        private void checkOut_button_Click(object sender, EventArgs e)
        {

        }

        private void room_button_Click(object sender, EventArgs e)
        {
            roomForm room = new roomForm();
            room.Show();
            Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm back_out = new loginForm();
            back_out.Show();
            Hide();
        }

        private void searchCUST_button_Click(object sender, EventArgs e)
        {
            SearchCustomer sc = new SearchCustomer();
            sc.Show();
            Hide();
        }
    }
}
