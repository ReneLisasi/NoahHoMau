using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoahHoMau
{
    class Drink
    {
        //Properties
        public string DrinkName;
        public string DrinkSize;

        //constructor that takes no arguements

        public Drink()
        {
            DrinkName = null;
            DrinkSize = null;
        }
        public Drink(string drinkName, string drinkSize)
        {
            DrinkName = drinkName;
            DrinkSize = drinkSize;
        }

        //getters and setters
        public string getDrinkName() { return DrinkName; }
        public string getDrinkSize() { return DrinkSize; }

        public void setDrinkName(string drinkName) { DrinkName = drinkName; }
        public void setDrinkSize(string drinkSize) { DrinkSize = drinkSize; }

        //Display Method
        public void DisplayDrink()
        {
            System.Diagnostics.Debug.WriteLine(this.ToStringg());
        }
        public string ToStringg()
        {
            return $"{DrinkName} {DrinkSize}";
        }
    }
}
