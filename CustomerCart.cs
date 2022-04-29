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
        string selectedItem;
        
        public CustomerCart()
        {
            InitializeComponent();
            foreach(string item in Builder.foodList)
            {
            cbx_CartList.Items.Add(item);
            }

        }
        private void RefreshCBX()
        {
            cbx_CartList.DataSource = Builder.foodList;
        }
        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has been placed");
            CustomerOrders.OrderList = Builder.foodList;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Builder.foodList.Remove(selectedItem);
            RefreshCBX();
        }

        private void btn_Remove_All_Click(object sender, EventArgs e)
        {
            Builder.foodList.RemoveRange(0, Builder.foodList.Count);
            RefreshCBX();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            CustomerLogin nav_Login = new CustomerLogin();
            nav_Login.Show();
            this.Hide();
        }

        private void cbx_OrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = cbx_CartList.Text;
        }
    }
}
