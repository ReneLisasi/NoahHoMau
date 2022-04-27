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
    public partial class Builder : Form
    {
        //properties
        Pizza p1= new Pizza();
        int listIndex;
        List<string> foodList = new List<string>();
        public Builder()
        {
            InitializeComponent();
        }
        //pizza
        private void cbx_Pizza_SelectedIndexChanged(object sender, EventArgs e)
        {   
            string pizzaType = "";
            pizzaType = cbx_Pizza.Text;
            Pizza p2 = new Pizza(pizzaType);
            p1 = p2;
            
        }

        private void RefreshOrderList()
        {
            lbl_OrderList.Text = String.Join(Environment.NewLine, foodList);
        }

        private void btn_Pizza_Add_Click(object sender, EventArgs e)
        {   
            listIndex = foodList.Count;
            foodList.Add(p1.ToStringg());
            RefreshOrderList();
        }

        private void btn_Pizza_Subt_Click(object sender, EventArgs e)
        {
            foodList.Remove(p1.ToStringg());
            RefreshOrderList();
        }
        //end pizza
        private void cbx_Drinks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Desserts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Toppings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Crust_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Cheese_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
