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
    public partial class CustomerCart : Form
    {
        public CustomerCart()
        {
            InitializeComponent();
            cbx_OrderList.Items.Add(String.Join(Environment.NewLine, Builder.foodList));
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

        }

        private void btn_Remove_All_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            CustomerLogin nav_Login = new CustomerLogin();
            nav_Login.Show();
            this.Hide();
        }

        private void cbx_OrderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
