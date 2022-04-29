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
    public partial class PaymentPortal : Form
    {
        private Customer c1 = new Customer();
        public PaymentPortal()
        {
            InitializeComponent();
            c1.SelectDB(CustomerLogin.selectedId);
        }
        

        //This method will save the payment choice in the customer object.
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (rd_MasterCard.Checked)
            {
                c1.setPaymentType("MasterCard");
            }else if (rd_Amex.Checked)
            {
                c1.setPaymentType("Amex");
            }
            else
            {
                c1.setPaymentType("Visa");
            }
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you need help, Contact Administation at 123-456-7890");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbx_Card.Text = "";
            tbx_Cvv.Text = "";
            tbx_Name.Text = "";
        }



    }
}
