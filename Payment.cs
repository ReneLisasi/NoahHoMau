using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoahHoMau
{
    class Payment
    {
        /******
         * This class should be a container for all things payment and should have the following:
         * Payment type/card type
         * Card number
         * cvv
         * name on card
         * paypal email maybe
         */

        //properties
        String PaymentType = "";
        String CardNumber = "";
        String CVV = "";
        String CardName = "";

        String PaymentEmail = "";

        //constructor that passes no arguments
            public Payment()
        {
            PaymentType = "";
            CardNumber = "";
            CVV = "";
            CardName = "";
            PaymentEmail = "";
        }
        //constructor that passes all arguments
        public Payment(string paymentType, string cardNumber, string cvv, string cardName, string paymentEmail )
        {
            PaymentType = paymentType;
            CardNumber = cardNumber;
            CVV = cvv;
            CardName = cardName;
            PaymentEmail = paymentEmail;
        }

        //display method
        public string displayPayment()
        {
            return $"{PaymentType} {CardNumber} {CVV} {CardName} {PaymentEmail}";
        }

        //getters and setters

    }
}
