using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Market
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OnlineMarketEntities db = new OnlineMarketEntities();

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "ahmedawwad221b@gmail.com";
            txtPassword.Text = "01015625845";
            custRadio.Checked = true;

        }
        private bool validateForm()
        {
            bool good = true;

            if (txtEmail.Text == "")
            {
                emailError.Text = "Email is Reuired";
                good = false;

            }
            else
                emailError.Visible = false;

            if (txtPassword.Text == "")
            {
                passwordError.Text = "Password is Reuired";
                good = false;

            }
            else
                passwordError.Visible = false;

            if (custRadio.Checked == false && salesRadio.Checked == false)
            {
                typeError.Text = "Account type is Reuired";
                good = false;

            }
            else
                typeError.Visible = false;


            return good;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if (salesRadio.Checked)
                {
                    try
                    {
                        seller seller = db.sellers.Where(s => s.email == txtEmail.Text && s.password == txtPassword.Text).FirstOrDefault();
                        SellerForm salesForm = new SellerForm(seller.id);
                        this.Hide();
                        salesForm.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Wrong Email Or password");
                    }
                }
                else if (custRadio.Checked)
                {
                    try
                    {
                        customer customer = db.customers.Where(s => s.email == txtEmail.Text && s.password == txtPassword.Text).FirstOrDefault();
                        CustomerForm customerForm = new CustomerForm(customer.id);
                        this.Hide();
                        customerForm.Show();
                    }
                
                    catch
                    {
                        MessageBox.Show("Wrong Email Or password");
                    }
                }
            }
            
        }
    }
}
