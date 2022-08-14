using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Market
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        OnlineMarketEntities db = new OnlineMarketEntities();

        private void Register_Load(object sender, EventArgs e)
        {
           
        }

        private bool validateForm()
        {
            Regex phone = new Regex(@"^\d");
            Regex email = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");

            bool good = true;
            if (txtName.Text == "")
            {
                nameError.Text = "Name is Reuired";
                good = false;

            }
            else
                nameError.Visible = false;
         
            if (txtEmail.Text == "")
            {
                emailError.Text = "Email is Reuired";
                good = false;

            }
            else if (!(email.IsMatch(txtEmail.Text)))
            {
                emailError.Text = "Invalid Email format";
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
            
            if (txtPhone.Text == "")
            {
                phoneError.Text = "Phone Number is Reuired";
                good = false;

            }
            else if (!(phone.IsMatch(txtPhone.Text)))
            {
                phoneError.Text = "Invalid Phone number format";
                good = false;
            }
            else
                phoneError.Visible = false;
      
            
            if (custRadio.Checked == false && salesRadio.Checked== false)
            {
                typeError.Text = "Account type is Reuired";
                good = false;

            }
            else
                typeError.Visible = false;

            if (txtAddress.Text == "" && custRadio.Checked)
            {
                addressError.Text = "Address is Reuired";
                good = false;

            }
            else
                addressError.Visible = false;

            return good;


        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (validateForm())
            {
                if (salesRadio.Checked)
                {
                    seller newSeller = new seller();
                    newSeller.name = txtName.Text;
                    newSeller.email = txtEmail.Text;
                    newSeller.password = txtPassword.Text;
                    newSeller.phone = Convert.ToInt32(txtPhone.Text);
                    newSeller.balance = 0;
                    db.sellers.Add(newSeller);
                    db.SaveChanges();
                    SellerForm salesForm = new SellerForm(newSeller.id);
                    this.Hide();
                    salesForm.Show();
                }
                else if (custRadio.Checked)
                {
                    customer newCustomer = new customer();
                    newCustomer.name = txtName.Text;
                    newCustomer.email = txtEmail.Text;
                    newCustomer.password = txtPassword.Text;
                    newCustomer.phone = Convert.ToInt32(txtPhone.Text);
                    newCustomer.address = txtAddress.Text;
                    cart newCart = new cart();
                    newCustomer.cart = newCart;
                    db.customers.Add(newCustomer);
                    db.carts.Add(newCart);
                    db.SaveChanges();
                    CustomerForm customerForm = new CustomerForm(newCustomer.id);
                    this.Hide();
                    customerForm.Show();
                }
            }
            
                        
        }

        private void salesRadio_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress.Enabled = false;
            addressError.Visible = false;
        }

        private void custRadio_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress.Enabled = true;
        }
    }
}
