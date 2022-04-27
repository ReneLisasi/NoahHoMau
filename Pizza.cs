using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoahHoMau
{
    class Pizza
    {
        //Properties
        public string PizzaName;
        private string PizzaCheese = null;
        private string PizzaCrust = null;
        private string PizzaSize;
        private string PizzaToppings;

        public int Index;

        //constructor that takes no arguements

        public Pizza()
        {
            PizzaName = null;
            PizzaCheese = null;
            PizzaCrust = null;
            PizzaSize = null;
            PizzaToppings = null;
            Index = 0;
        }
        //Hardcoded Default constructors
        public Pizza(string pizzaName)
        {
            switch (pizzaName){
                case "Pepperoni":
            PizzaName = "Pepperoni";
            PizzaCheese = "Mozarella";
            PizzaCrust = "Medium";
            PizzaSize = "Medium";
            PizzaToppings = "Pepperoni";
                    break;

                case "Supreme":
                    PizzaName = "Supreme";
                    PizzaCheese = "American Cheese";
                    PizzaCrust = "Medium";
                    PizzaSize = "Medium";
                    PizzaToppings = "Mushroom";
                    break;

                case "Cheese":
                    PizzaName = "Cheese";
                    PizzaCheese = "Three Cheese";
                    PizzaCrust = "Medium";
                    PizzaSize = "Medium";
                    PizzaToppings = "Garlic";
                    break;
            }
            
        }

        //constructor with arguements

        public Pizza(string pizzaName, string pizzaCheese, string pizzaCrust, string pizzaSize, string pizzaToppings)
        {
            PizzaName = pizzaName;
            PizzaCheese = pizzaCheese;
            PizzaCrust = pizzaCrust;
            PizzaSize = pizzaSize;
            PizzaToppings = pizzaToppings;
        }
        // Spits out a Pizza
        public static void PizzaTest()
        {
            Pizza Pepperoni = new Pizza("m","x", "y", "z", "a");
            Pepperoni.DisplayPizza();
            Pizza Custom = new Pizza();
        }

        //getters and setters
        public string getPizzaName() { return PizzaName; }
        public string getPizzaBase() { return PizzaCheese; }
        public string getPizzaCrust() { return PizzaCrust; }
        public string getPizzaSize() { return PizzaSize; }
        public string getPizzaToppings() { return PizzaToppings; }
        public int getIndex() { return Index; }

        public void setPizzaName(string pizzaName) { PizzaName = pizzaName; }
        public void setPizzaBase(string pizzaBase) { PizzaCheese = pizzaBase; }
        public void setPizzaCrust(string pizzaCrust) { PizzaCrust = pizzaCrust; }
        public void setPizzaSize(string pizzaSize) { PizzaSize = pizzaSize; }
        public void setPizzaToppings(string pizzaToppings) { PizzaToppings = pizzaToppings; }
        public void setIndex(int index) { Index=index; }
        //Display Method
        public void DisplayPizza()
        {
            System.Diagnostics.Debug.WriteLine(this.ToStringg());
        }
        public string ToStringg()
        {
            return $"{PizzaName} {PizzaToppings} {PizzaCrust} {PizzaCheese} {PizzaSize}";
        }
    }
}

