using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoahHoMau
{
    public partial class CustomerHome : Form
    {
        public CustomerHome()
        {
            InitializeComponent();
        }

        private void btn_Build_Click(object sender, EventArgs e)
        {
            Builder nav_Builder = new Builder();
            nav_Builder.Show();
            this.Hide();
        }

        //nav buttons
        private void btn_Back_Click(object sender, EventArgs e)
        {
            CustomerLogin nav_Login = new CustomerLogin();
            nav_Login.Show();
            this.Hide();
        }

        private void ptx_Cart_Click(object sender, EventArgs e)
        {
            CustomerCart nav_Cart = new CustomerCart();
            nav_Cart.Show();
            this.Hide();
        }
        //nav
        private void pfoileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerProfile nav_Profile = new CustomerProfile();
            nav_Profile.Show();
            this.Hide();
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerCart nav_Cart = new CustomerCart();
            nav_Cart.Show();
            this.Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerLogin nav_Login = new CustomerLogin();
            nav_Login.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerHome nav_Home = new CustomerHome();
            nav_Home.Show();
            this.Hide();
        }

        private void builderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Builder nav_Builder = new Builder();
            nav_Builder.Show();
            this.Hide();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerOrders nav_Orders = new CustomerOrders();
            nav_Orders.Show();
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }
    }
}
