using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Market
{


    //TO DO
    // 1) Delete From my Products using the gridview
    public partial class SellerForm : Form
    {
        int currentSeller;
        public SellerForm(int id)
        {
            currentSeller = id;
            InitializeComponent();
        }
        OnlineMarketEntities db = new OnlineMarketEntities();

        private void bindGradeview()
        {
            myProductsGV.DataSource = db.products.Where(s => s.seller_id == currentSeller).ToList();

            myProductsGV.Columns[1].Visible = false;
            myProductsGV.Columns[4].Visible = false;
            myProductsGV.Columns[6].Visible = false;
            myProductsGV.Columns[9].Visible = false;
            myProductsGV.Columns[10].Visible = false;
            myProductsGV.Columns["category"].ReadOnly = true;
            myProductsGV.Columns["product_rate"].ReadOnly = true;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            bindGradeview();
            txtBalance.Text = db.sellers.Where(s => s.id == currentSeller).FirstOrDefault().balance.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                addProduct();
            }
            else
                Console.WriteLine(" ");
            
        }

        private void addProduct()
        {
            product newProduct = new product();
            newProduct.name = txtName.Text;
            newProduct.price = Convert.ToInt32(txtPrice.Text);
            newProduct.category = category.SelectedItem.ToString();
            newProduct.seller_id = currentSeller;
            newProduct.img = File.ReadAllBytes(txtPhoto.Text);
            newProduct.quantity = Convert.ToInt32(txtQuantity.Text);
            newProduct.product_rate = 0;
            db.products.Add(newProduct);
            db.SaveChanges();
            bindGradeview();
        }

        private bool validateForm()
        {

            Regex numberReg = new Regex(@"^\d");

            bool good = true;

            if (txtName.Text == "")
            {
                nameError.Text = "Name is Reuired";
                good = false;

            }
            else
                nameError.Visible = false;

            if (txtPrice.Text == "")
            {
                priceError.Text = "Price is Reuired";
                good = false;

            }
            
            else if (!(numberReg.IsMatch(txtPrice.Text)))
            {
                priceError.Text = "Price must be number";
                good = false;
            }
            
            else
                priceError.Visible = false;


            if (category.Text == "")
            {
                categoryError.Text = "Category is Reuired";
                good = false;

            }
            else
                categoryError.Visible = false;

            if (txtPhoto.Text == "")
            {
                imgError.Text = "Image is Reuired";
                good = false;

            }
            else
                imgError.Visible = false;

            if (txtQuantity.Text == "")
            {
                quantityError.Text = "Quantity is Reuired";
                good = false;

            }
            
            else if (!(numberReg.IsMatch(txtQuantity.Text)))
            {
                quantityError.Text = "Quantity must be number";
                good = false;
            }
            
            else
                quantityError.Visible = false;

            return good;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            txtPhoto.Text = ofd.FileName;
        }
        
        private void myProductsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowIndex = myProductsGV.CurrentCell.RowIndex;
            int colIndex = myProductsGV.CurrentCell.ColumnIndex;
            int id = Convert.ToInt32(myProductsGV.Rows[rowIndex].Cells["id"].Value);
            if (colIndex == 0)
            {
                product p = db.products.Where(pr => pr.id == id).FirstOrDefault();
                db.products.Remove(p);
                db.SaveChanges();
                bindGradeview();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login form = new Login();
            form.Show();
        }

        private void myProductsGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = myProductsGV.CurrentCell.RowIndex;
                int colIndex = myProductsGV.CurrentCell.ColumnIndex;
                int id = Convert.ToInt32(myProductsGV.Rows[rowIndex].Cells["id"].Value);
                product p = db.products.Where(pr => pr.id == id).FirstOrDefault();

                if (colIndex == 3 || colIndex == 8 || colIndex == 4)
                {
                    p.name = myProductsGV.Rows[rowIndex].Cells["name"].Value.ToString();
                    p.quantity = Convert.ToInt32(myProductsGV.Rows[rowIndex].Cells["quantity"].Value.ToString());
                    p.price = Convert.ToInt32(myProductsGV.Rows[rowIndex].Cells["price"].Value.ToString());
                    db.SaveChanges();
                    bindGradeview();
                }
            }
            catch
            {
                MessageBox.Show("Update one cell at a time");
            }
        }
    }
}
