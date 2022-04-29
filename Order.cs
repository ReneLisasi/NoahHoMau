using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***
 * Rene Lisasi
 * Noah Ho Mau
 * April 15th 2022
 * I wrote this
 * *****************/
namespace NoahHoMau
{
    class Order
    {
        /************************
         * Order class should contain:
         * * orderid
         * Order name, 
         * Customer Name, 
         * Customer Address, 
         * OrderList
         * date/time of order
         * time left.
         */

        //properties
        String OrderID = "";
        String OrderName = "";
        Customer customer = new Customer();
        Address CustAddress = new Address();

        List<string> Food = new List<string>();
        //Time properties
        int TimeLeft = 0;
        DateTime OrderTime = new DateTime();

        //cost
        Double Cost = 0;

        //constructor without arguments
        public Order()
        {
            //properties
            OrderID = "";
            OrderName = "";
            customer = new Customer();
            CustAddress = new Address() ;

            //food
            Food = new List<string>();

            //Time properties
            TimeLeft = 0;
            OrderTime = new DateTime();

            //cost
            Cost = 0;
        }
        //constructor with arguments
        public Order(string orderId, string orderName,List<string> food, Customer cust,
            Address custAddress,double cost, DateTime orderTime)
        {
            OrderID = orderId;
            OrderName = orderName;
            customer = cust;
            CustAddress = custAddress;
            Food = food;
            Cost = cost;
            OrderTime = orderTime;
            //time complexity of order based on customer location + number of items = delivery time
            int zip = customer.getAddress().getZip();
            int count = 0;
            zip =- 30060;
            count = Food.Count;
            count = count*5;
            //end calulations to get time
            TimeLeft = zip+count;
        }
        

        //test case
        public void OrderTest()
        {
            /*Order o1 = new Order("0001", "Lil Seizures", "Mason", "123 Main st", new PizzaList(), new DessertList(), new DrinkList(), new DateTime());
            o1.OrderID("0002");
            o1.OrderName("TestName");
            //o1.setpizzalist
            //o1.setdessertlist
            //o1.set
            //o1.setTime

            */
        }
        //getters and setters

        public string getOrderId() { return this.OrderID; }
        public string getOrderName() { return OrderName; }
        public List<string> getFood() { return Food; }
        public double getCost() { return Cost; }


        public void setOrderId(string orderId) {this.OrderID = orderId; }
        public void setOrderName(string orderName) { OrderName = orderName; }
        public void setFood(List<string> food) { Food=food; }
        public void setCost(double cost) { Cost = cost; }

        //Display Method
        public void DisplayOrder()
        {
            System.Diagnostics.Debug.WriteLine(this.ToStringg());
        }
        public string ToStringg()
        {
            return $"{OrderID}\n{OrderName}\n{customer.getCustId()}\n{Food}\n{Cost}\n{TimeLeft}";
        }
        //db methods

    }
}
