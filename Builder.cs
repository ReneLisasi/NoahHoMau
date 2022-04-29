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

        Drink d1 = new Drink();
        Dessert e1 = new Dessert();
        int listIndex;
        public static List<string> foodList = new List<string>();
        List<string> toppingsList = new List <string>();

        public Builder()
        {
            InitializeComponent();
        }
        //pizza
        private void cbx_Pizza_SelectedIndexChanged(object sender, EventArgs e)
        {   
            string pizzaType = "";
            pizzaType = cbx_Pizza.Text;
            p1.setPizzaName(pizzaType);
        }

        private void RefreshOrderList()
        {
            lbl_OrderList.Text = String.Join(Environment.NewLine, foodList);
        }
        private void setCustom()
        {
            p1.setPizzaName("Custom");
            cbx_Pizza.Text = "Custom";
        }

        private void btn_Pizza_Add_Click(object sender, EventArgs e)
        {
            p1.setPizzaToppings(ToppingsSelection());
            p1.setPizzaCrust(CrustSelection());
            p1.setPizzaSize(SizeSelection());
            p1.setPizzaCheese(CheeseSelection());
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
            d1.setDrinkName(cbx_Drinks.Text);
        }

        private void cbx_Desserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            e1.setDessertName(cbx_Desserts.Text);
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Drink_Add_Click(object sender, EventArgs e)
        {
            foodList.Add(d1.ToStringg());
            d1.setDrinkSize(DrinkSizeSelection());
            RefreshOrderList();
        }

        private void btn_Drink_Subt_Click(object sender, EventArgs e)
        {
            foodList.Remove(d1.ToStringg());
            RefreshOrderList();
        }

        private void btn_Dessert_Add_Click(object sender, EventArgs e)
        {
            foodList.Add(e1.ToStringg());
            RefreshOrderList();
        }

        private void btn_Dessert_Subt_Click(object sender, EventArgs e)
        {
            foodList.Remove(e1.ToStringg());
            RefreshOrderList();
        }
        //obselete
        private void rd_Size_Small_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_Size_Medium_CheckedChanged(object sender, EventArgs e)
        {

        }
        //selections
        public string ToppingsSelection()
        {   
            if (rd_Toppings_Pepperoni.Checked == true){toppingsList.Add("Pepperoni"); setCustom(); }
            if (rd_Toppings_Mushroom.Checked == true){ toppingsList.Add("Mushroom"); setCustom(); }
            if (rd_Toppings_Garlic.Checked == true){toppingsList.Add("Garlic"); setCustom(); }
            if (rd_Toppings_Bacon.Checked == true){toppingsList.Add("Bacon"); setCustom(); }
            if (rd_Toppings_Pineapple.Checked == true){toppingsList.Add("Pineapple"); setCustom(); }
            
            return String.Join(Environment.NewLine, toppingsList);
        }

        public string CheeseSelection()
        {
            string cheese = "";
            //cheeses
            if (rd_Toppings_AmericanCheese.Checked == true) { cheese = "American Cheese"; rd_Toppings_Mozzarella.Checked = rd_Toppings_ExtraCheese.Checked = false; setCustom(); }
            if (rd_Toppings_Mozzarella.Checked == true) { cheese="Mozzarella"; rd_Toppings_AmericanCheese.Checked = rd_Toppings_ExtraCheese.Checked = false; setCustom(); }
            if (rd_Toppings_ExtraCheese.Checked == true) {cheese="Extra Cheese"; rd_Toppings_AmericanCheese.Checked = rd_Toppings_Mozzarella.Checked = false; setCustom(); }
            return cheese;
        }
        public string CrustSelection()
        {
            string crust = "";
            if (rd_Crust_Thin.Checked == true) { crust="Thin Crust"; rd_Crust_Medium.Checked = rd_Crust_Thick.Checked = false; setCustom(); }
            if (rd_Crust_Medium.Checked == true) { crust="Medium Crust"; rd_Crust_Thin.Checked = rd_Crust_Thick.Checked = false; setCustom(); }
            if (rd_Crust_Thick.Checked == true) { crust="Thick Crust"; rd_Crust_Medium.Checked = rd_Crust_Thin.Checked = false; setCustom(); }
            return crust;
        }
        public string SizeSelection()
        {
            string size = "";
            if (rd_Size_Small.Checked == true) { size = "Small"; setCustom(); }
            if (rd_Size_Medium.Checked == true) { size = "Medium"; setCustom(); }
            if (rd_Size_Large.Checked == true) { size = "Large"; setCustom(); }
            if (rd_Size_XLarge.Checked == true) { size = "Extra Large"; setCustom(); }
            return size;
        }
        public string DrinkSizeSelection()
        {
            string size = "";
            if (rd_Drink_Small.Checked == true) { size = "Thin Crust"; rd_Drink_Medium.Checked = rd_Drink_Large.Checked = false; setCustom(); }
            if (rd_Drink_Medium.Checked == true) { size = "Medium Crust"; rd_Drink_Small.Checked = rd_Drink_Large.Checked = false; setCustom(); }
            if (rd_Drink_Large.Checked == true) { size = "Thick Crust"; rd_Drink_Medium.Checked = rd_Drink_Small.Checked = false; setCustom(); }
            return size;
        }
        //nav
        private void pbx_Cart_Click(object sender, EventArgs e)
        {
            CustomerCart nav_Cart = new CustomerCart();
            nav_Cart.Show();
            this.Hide();
        }

        private void btn_Clear_Custom_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Order_Click(object sender, EventArgs e)
        {

        }

        private void btn_Help_Click(object sender, EventArgs e)
        {

        }
    }
}
