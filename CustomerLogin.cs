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
    public partial class CustomerLogin : Form
    {
        public static String selectedId; //used for collecting from forms
        Customer c1 = new Customer();
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //selectedId = Convert.ToInt32(nbx_Customer.Value);
            selectedId = tbx_Phone.Text;
            c1.SelectDB(selectedId);
            String pw = c1.getCustPw();
            String id = c1.getCustId();
            System.Diagnostics.Debug.WriteLine(selectedId);
            System.Diagnostics.Debug.WriteLine(c1.getCustFname());
            //admin login
            if (tbx_Phone.Text.Equals("admin") && tbx_Password.Text.Equals("123"))
            {
                //collect student id and send to new form

                AdminHome nav_aHome = new AdminHome();
                nav_aHome.Show();
                this.Hide();
            }
            //login credentials test
            if (tbx_Phone.Text.Equals(id) && tbx_Password.Text.Equals(pw))
            {
                //collect student id and send to new form

                CustomerHome nav_Home = new CustomerHome();
                nav_Home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password or phone number");
            }
            

        }

        private void btn_Singup_Click(object sender, EventArgs e)
        {
            CustomerSignUp nav_Home = new CustomerSignUp();
            nav_Home.Show();
            this.Hide();
        }

        private void btn_ForgotPw_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password reset instructions have been sent to you via SMS.");
        }
    }
}
