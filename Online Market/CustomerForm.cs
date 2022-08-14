using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Market
{
    

    public partial class CustomerForm : Form
    {
        int currentCustomer;
        int total = 0;
        OnlineMarketEntities db = new OnlineMarketEntities();
        Dictionary<int, int> originalQuantity = new Dictionary<int, int>();

        public CustomerForm(int id)
        {
            currentCustomer = id; 
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            originalQuantity = db.products.ToDictionary(x => x.id, x => x.quantity);
            bindProductsGV();
        }

        private void bindProductsGV()
        { 
            productsGV.ForeColor = System.Drawing.Color.Black;
            productsGV.DataSource = db.products.ToList();
            productsGV.Columns[2].Visible = false;
            productsGV.Columns[5].Visible = false;
            productsGV.Columns[7].Visible = false;
            productsGV.Columns[10].Visible = false;
            productsGV.Columns[11].Visible = false;
            productsGV.Columns[3].ReadOnly = true;
            productsGV.Columns[4].ReadOnly = true;
            productsGV.Columns[6].ReadOnly = true;
            productsGV.Columns[8].ReadOnly = true;
            productsGV.Columns[9].ReadOnly = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login form = new Login();
            form.Show();
        }

        private void productsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = productsGV.CurrentCell.RowIndex;
            int colIndex = productsGV.CurrentCell.ColumnIndex;
            int id = Convert.ToInt32(productsGV.Rows[rowIndex].Cells["id"].Value);
            if (colIndex != 0 && colIndex != 1)
            {
                product p = db.products.Where(x => x.id == id).FirstOrDefault();
                MemoryStream ms = new MemoryStream((byte[])p.img);
                pictureBox1.Image = new Bitmap(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (colIndex == 0)
            { 
                add(rowIndex, id);

            }   
        }
        private void add(int rowIndex, int id)
        {
            if (db.products.Where(p => p.id == id).FirstOrDefault().quantity > 0)
            {
                cart_items item = new cart_items()
                {
                    item_name = productsGV.Rows[rowIndex].Cells["name"].Value.ToString(),
                    item_price = Convert.ToInt32(productsGV.Rows[rowIndex].Cells["price"].Value.ToString()),
                    qunatity = 1
                };

                cart_items temp = db.customers.Where(c => c.id == currentCustomer).FirstOrDefault().cart.cart_items.
                        Where(x => x.item_name == item.item_name).FirstOrDefault();

                if (temp != null)
                {
                    db.customers.Where(c => c.id == currentCustomer).FirstOrDefault().cart.cart_items.
                        Where(x => x.item_name == item.item_name).FirstOrDefault().qunatity += 1;

                }
                else
                    db.customers.Where(c => c.id == currentCustomer).FirstOrDefault().cart.cart_items.Add(item);

                total += (item.qunatity * item.item_price);
                txtTotal.Text = total.ToString();
                db.products.Where(p => p.id == id).FirstOrDefault().quantity -= 1;
                db.SaveChanges();
                bindMyCart();
                bindProductsGV();

            }
            else
            {
                MessageBox.Show("Item out of stock");
            }    
                
        

        }
        private void bindMyCart()
        {
            myCartGV.ForeColor = System.Drawing.Color.Black;
            myCartGV.DataSource = db.customers.Where(c => c.id == currentCustomer).FirstOrDefault().cart.cart_items
                .Select(x=>  new {ItemName = x.item_name, ItemPrice = x.item_price,Quantity = x.qunatity }).ToList();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && comboCategory.Text != "")
            {
                productsGV.DataSource = (from products in db.products
                                         where products.category == comboCategory.Text
                                         select products).ToList();
            }
            else if (txtName.Text != "" && comboCategory.Text == "")
            {
                productsGV.DataSource = (from products in db.products
                                         where products.name.Contains(txtName.Text)
                                         select products).ToList();
            }
            else if (txtName.Text != "" && comboCategory.Text != "")
            {
                productsGV.DataSource = (from products in db.products
                                         where products.name.Contains(txtName.Text) && products.category == comboCategory.Text
                                         select products).ToList();
            }
            else
            {
                MessageBox.Show("Enter values to search with");
                bindProductsGV();
            }

        }
        private void clear()
        {
            var itemes = db.cart_items.Where(i => i.cart_id == currentCustomer);
            foreach (var i in itemes)
                db.cart_items.Remove(i);
            db.customers.Where(c => c.id == currentCustomer).FirstOrDefault().cart.cart_items.Clear();
                foreach (var q in originalQuantity)
                {
                    db.products.Where(p => p.id == q.Key).FirstOrDefault().quantity = q.Value;
                }
            
            db.SaveChanges();
            bindMyCart();
            bindProductsGV();
            total = 0;
            txtTotal.Text = "";

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<cart_items> items = db.customers.Where(c => c.id == currentCustomer).FirstOrDefault().cart.cart_items.ToList();
            foreach(cart_items item in items)
            {
                product p = db.products.Where(x => x.name == item.item_name).FirstOrDefault();
                p.seller.balance += item.qunatity * p.price;
                
            }
            db.SaveChanges();
            originalQuantity = db.products.ToDictionary(x => x.id, x => x.quantity);
            db.SaveChanges();
            txtTotal.Text = "";
            MessageBox.Show("Purchase Completed");
            clear();
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            clear();
        }

        private void productsGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = productsGV.CurrentCell.RowIndex;
            int colIndex = productsGV.CurrentCell.ColumnIndex;
            int id = Convert.ToInt32(productsGV.Rows[rowIndex].Cells["id"].Value);
           
            if (colIndex == 1)
            {
                rating myRate = new rating()
                {
                    customer_id = currentCustomer,
                    product_id = id,
                    rate = 0
                };
                rating temp = db.ratings.Where(r => r.customer_id == myRate.customer_id && r.product_id == myRate.product_id).FirstOrDefault();
                if (temp == null)
                {
                    myRate.rate = Convert.ToInt32(productsGV.Rows[rowIndex].Cells[1].Value);
                    db.ratings.Add(myRate);
                    db.SaveChanges();
                }
                else
                {
                   temp.rate = Convert.ToInt32(productsGV.Rows[rowIndex].Cells[1].Value);
                    db.SaveChanges();

                }
                double avg = Math.Round(db.ratings.Where(r => r.product_id == id).Select(x => x.rate).Average(), 2);
                db.products.Where(p => p.id == id).FirstOrDefault().product_rate = avg;
                try
                {
                    bindProductsGV();

                }
                catch
                {
                    MessageBox.Show("Rate one product at a time");
                }


            }
            
        }
    }
}
