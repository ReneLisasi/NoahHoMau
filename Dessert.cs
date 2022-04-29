using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoahHoMau
{
    class Dessert
    {
        //Properties
        public string DessertName;
        //constructor that takes no arguements

        public Dessert()
        {
            DessertName = null;
        }
        public Dessert(string drinkName, string drinkSize)
        {
            DessertName = drinkName;
        }

        //getters and setters
        public string getDessertName() { return DessertName; }

        public void setDessertName(string drinkName) { DessertName = drinkName; }

        //Display Method
        public void DisplayDessert()
        {
            System.Diagnostics.Debug.WriteLine(this.ToStringg());
        }
        public string ToStringg()
        {
            return $"{DessertName}";
        }

    }
}
