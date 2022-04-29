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
    //todo rene check this for me.
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        //This method will handle the order manager button being pressed and will take the user to the order manager.
        private void btn_OrderManager_Click(object sender,EventArgs e)
        {
            AdminOrders nav_Admin_Orders = new AdminOrders();
            nav_Admin_Orders.Show();
            this.Hide();
        }

        //This method will handle the customer manager being pressed and will take the user to the customer manager.
        private void btn_CustomerManager_Click(object sender,EventArgs e)
        {
            AdminCustomers nav_Admin_Customer = new AdminCustomers();
            nav_Admin_Customer.Show();
            this.Hide();
        }
    }
}
