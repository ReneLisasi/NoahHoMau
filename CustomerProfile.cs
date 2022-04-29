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
    public partial class CustomerProfile : Form
    {
        
        //TODO rene, we need to fix all the compile errors here.
        
        //properties
        private Customer c1 = new Customer();
        public CustomerProfile()
        {
            c1.setCustId(CustomerLogin.selectedId);
            InitializeComponent();
            InitializeTextBoxes();
            InitializeLabels();
        }

        //This method will initialize all text boxes.
        private void InitializeTextBoxes()
        {
            tbx_Phone.Text = c1.getCustId();
            tbx_Payment.Text = "Visa"; //todo fix this.
            tbx_Email.Text = c1.getCustEmail();
            tbx_Password.Text = c1.getCustPw();
            tbx_Street.Text = c1.getAddress().getStreet();
            tbx_State.Text = c1.getAddress().getState();
            tbx_City.Text = c1.getAddress().getCity();
            tbx_Zip.Text = c1.getAddress().getZip();
        }

        //This method will initialize all labels
        private void InitializeLabels()
        {
            lbl_ID.Text = c1.getCustId();
            lbl_First_Name.Text = c1.getFirstName();
            lbl_Last_Name.Text = c1.getLastName();
        }

        //This method will event handle the submit button being pressed.
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            c1.setCustId(tbx_Phone.Text);
            c1.setCustEmail(tbx_Email.Text);
            c1.UpdateDB();
        }

        //This method will event handle the delete account button being pressed.
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (btn_Delete_Check()) // If the user presses yes on the confirm.
            {
                c1.DeleteDB();
                GoToLoginScreen(); 
            }
        }

        //This method will event handle the login button being pressed.
        private void GoToLoginScreen()
        {
            CustomerLogin nav_Login = new CustomerLogin();
            nav_Login.Show();
            this.Hide();
        }

        //This method will event handle the help button
        private void btn_Help_Click(object sender, EventArgs e)
        {
            //todo maybe change this later.
            MessageBox.Show("Please contact admin at 123-456-7890 for help");
        }

        //This method will make give the user a prompt on whether the user wants to delete their account or not.
        private bool btn_Delete_Check()
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "Confirmation Window", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //This method will event handle the payment portal button being pressed.
        private void btn_Payment_Portal(object sender, EventArgs e)
        {
            //todo maybe change this later.
            MessageBox.Show("Please contact admin at 123-456-7890 for help");
        }
        
        //This method will take the users to the payment portal
        private void GoToPaymentPortal()
        {
            PaymentPortal nav_Payment_Portal = new PaymentPortal();
            nav_Payment_Portal.Show();
            this.Hide();
        }

    }
}
