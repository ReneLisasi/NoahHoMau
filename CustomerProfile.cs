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
        //properties
        private Customer c1 = new Customer();
        public CustomerProfile()
        {
            InitializeComponent();
            //c1.setCustId();
            c1.SelectDB(CustomerLogin.selectedId);
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
            tbx_Zip.Text = c1.getAddress().getZip().ToString();
        }

        //This method will initialize all labels
        private void InitializeLabels()
        {
            lbl_ID.Text = c1.getCustId();
            lbl_FirstName.Text = c1.getFirstName();
            lbl_LastName.Text = c1.getLastName();
        }
        //BUttons///////////////////////////////////////////////////////////
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            c1.setCustId(tbx_Phone.Text);
            c1.setCustEmail(tbx_Email.Text);
            c1.UpdateDB();
        }

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
        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact admin at 123-456-7890 for help");
        }
        //This method will make give the user a prompt on whether the user wants to delete their account or not.
        private bool btn_Delete_Check()
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "Confirmation Window", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            PaymentPortal nav_Payment = new PaymentPortal();
            nav_Payment.Show();
            this.Hide();
        }
    }
}
