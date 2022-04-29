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
    public partial class AdminCustomers : Form
    {

        private Customer c1 = new Customer();
        public AdminCustomers()
        {
            InitializeComponent();
        }
        
        //This method will event handle the delete account button being pressed.
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!tbx_Phone.Text.IsEmpty()) //Ensure that there actually is a phoneNumber to search for user.
            {
                c1.SelectDB(tbx_Phone.Text);
                c1.DeleteDB();
                return;
            }
        }

        //This method will handle the lookup button being pressed and will lookup a user.
        private void btn_Lookup_Click(object sender, EventArgs e)
        {
            if (!tbx_Phone.Text.isEmpty) //Ensure that there actually is a phoneNumber to search for user.
            {
                c1.SelectDB(tbx_Phone.Text);
                // This will fill all the text boxes will the user information.
                tbx_Phone = c1.getCustId();
                tbx_First_Name = c1.getFirstName();
                tbx_Last_Name = c1.getLastName();
                tbx_Payment_Type = c1.getPaymentType(); //todo fix this
                tbx_Email = c1.Email;
                tbx_Street = c1.getAddress().Street;
                tbx_State = c1.getAddress().State;
                tbx_City = c1.getAddress().City;
                tbx_Zip = c1.getAddress().getZip();
                return;
            }
        }
    }
}
