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
    public partial class CustomerSignUp : Form
    {
        Customer c1 = new Customer();
        Address a1 = new Address();
        //properties
        string custId = "";
        string pw = "";
        string fn = "";
        string ln = "";
        string street = "";
        string city = "";
        string state = "";
        int zip = 0;
        string email = "";
        string payment = "visa";

        public CustomerSignUp()
        {
            InitializeComponent();
        }
        //nav buttons
        private void btn_Portal_Click(object sender, EventArgs e)
        {
            PaymentPortal nav_Portal = new PaymentPortal();
            nav_Portal.Show();
            this.Hide();
        }

        private void btn_CreateAcc_Click(object sender, EventArgs e)
        {

            // Insert payment options here//////////////////////
            
            pw = tbx_Password.Text;
            fn = tbx_FirstName.Text;
            ln = tbx_LastName.Text;
            street = tbx_Street.Text;
            state = tbx_State.Text;
            zip = Int32.Parse(tbx_Zip.Text);
            email = tbx_Email.Text;
            custId = tbx_Phone.Text;

            //check for duplicates
           
                //assign values
                c1.setCustId(custId);
                a1.setStreet(street);
                a1.setCity(city);
                a1.setState(state);
                a1.setZip(zip);
                c1.setCustPw(pw);
                c1.setCustFname(fn);
                c1.setCustLname(ln);
                c1.setCustAddress(a1);
                c1.setEmail(email);
                
                //insert payment////////////
                System.Diagnostics.Debug.WriteLine(email);
                c1.InsertDB();
        
        

            //forward to next form
            CustomerHome nav_Home = new CustomerHome();
            nav_Home.Show();
            this.Hide();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help");
        }
    }
}
