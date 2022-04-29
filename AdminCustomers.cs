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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!tbx_Phone.Text.Equals(null)) //Ensure that there actually is a phoneNumber to search for user.
            {
                c1.SelectDB(tbx_Phone.Text);
                // This will fill all the text boxes will the user information.
                c1.setCustId(tbx_Phone.Text);
                c1.setFirstName(tbx_FirstName.Text);
                c1.setLastName(tbx_LastName.Text);
                tbx_Payment.Text = "Visa"; //todo fix this
                c1.setCustEmail(tbx_Email.Text) ;
                c1.setCustAddress( new Address(tbx_Street.Text, tbx_City.Text, tbx_State.Text, Int32.Parse(tbx_Zip.Text)));
                c1.UpdateDB();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!tbx_Phone.Text.Equals(null)) //Ensure that there actually is a phoneNumber to search for user.
            {
                c1.SelectDB(tbx_Phone.Text);
                c1.DeleteDB();
                return;
            }
        }

        private void btn_Lookup_Click(object sender, EventArgs e)
        {
            if (!tbx_Phone.Text.Equals(null)) //Ensure that there actually is a phoneNumber to search for user.
            {
                c1.SelectDB(tbx_Phone.Text);
                // This will fill all the text boxes will the user information.
                tbx_Phone.Text = c1.getCustId();
                tbx_FirstName.Text = c1.getFirstName();
                tbx_LastName.Text = c1.getLastName();
                tbx_Payment.Text = "Visa"; //todo fix this
                tbx_Email.Text = c1.Email;
                tbx_Street.Text = c1.getAddress().Street;
                tbx_State.Text = c1.getAddress().State;
                tbx_City.Text = c1.getAddress().City;
                tbx_Zip.Text = c1.getAddress().getZip().ToString();
            }
            }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            AdminHome nav_aHome = new AdminHome();
            nav_aHome.Show();
                this.Hide();
        }
    }
}
