
namespace Online_Market
{
    partial class SellerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.myProductsGV = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.category = new System.Windows.Forms.ComboBox();
            this.nameError = new System.Windows.Forms.Label();
            this.priceError = new System.Windows.Forms.Label();
            this.imgError = new System.Windows.Forms.Label();
            this.categoryError = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quantityError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myProductsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Seller Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(262, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(262, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(262, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(262, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Image";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(403, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(403, 193);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(228, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(403, 321);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.ReadOnly = true;
            this.txtPhoto.Size = new System.Drawing.Size(228, 22);
            this.txtPhoto.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(446, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.Black;
            this.btnUpload.Location = new System.Drawing.Point(637, 321);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(87, 27);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(12, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "My Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(12, 574);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(171, 22);
            this.txtBalance.TabIndex = 14;
            // 
            // myProductsGV
            // 
            this.myProductsGV.AllowUserToAddRows = false;
            this.myProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myProductsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.myProductsGV.Location = new System.Drawing.Point(31, 669);
            this.myProductsGV.Name = "myProductsGV";
            this.myProductsGV.RowHeadersWidth = 51;
            this.myProductsGV.RowTemplate.Height = 24;
            this.myProductsGV.Size = new System.Drawing.Size(904, 162);
            this.myProductsGV.TabIndex = 16;
            this.myProductsGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myProductsGV_CellClick);
            this.myProductsGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.myProductsGV_CellEndEdit);
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Tech",
            "Food",
            "Furniture",
            "Tools"});
            this.category.Location = new System.Drawing.Point(403, 264);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(226, 24);
            this.category.TabIndex = 17;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(359, 145);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(12, 17);
            this.nameError.TabIndex = 18;
            this.nameError.Text = " ";
            // 
            // priceError
            // 
            this.priceError.AutoSize = true;
            this.priceError.ForeColor = System.Drawing.Color.Red;
            this.priceError.Location = new System.Drawing.Point(359, 215);
            this.priceError.Name = "priceError";
            this.priceError.Size = new System.Drawing.Size(12, 17);
            this.priceError.TabIndex = 19;
            this.priceError.Text = " ";
            // 
            // imgError
            // 
            this.imgError.AutoSize = true;
            this.imgError.ForeColor = System.Drawing.Color.Red;
            this.imgError.Location = new System.Drawing.Point(359, 347);
            this.imgError.Name = "imgError";
            this.imgError.Size = new System.Drawing.Size(12, 17);
            this.imgError.TabIndex = 20;
            this.imgError.Text = " ";
            // 
            // categoryError
            // 
            this.categoryError.AutoSize = true;
            this.categoryError.ForeColor = System.Drawing.Color.Red;
            this.categoryError.Location = new System.Drawing.Point(359, 291);
            this.categoryError.Name = "categoryError";
            this.categoryError.Size = new System.Drawing.Size(12, 17);
            this.categoryError.TabIndex = 21;
            this.categoryError.Text = " ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(401, 393);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(228, 22);
            this.txtQuantity.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(262, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Quantity";
            // 
            // quantityError
            // 
            this.quantityError.AutoSize = true;
            this.quantityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityError.ForeColor = System.Drawing.Color.Red;
            this.quantityError.Location = new System.Drawing.Point(358, 418);
            this.quantityError.Name = "quantityError";
            this.quantityError.Size = new System.Drawing.Size(0, 17);
            this.quantityError.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(415, 646);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "My Products";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 26;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(961, 966);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantityError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.categoryError);
            this.Controls.Add(this.imgError);
            this.Controls.Add(this.priceError);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.category);
            this.Controls.Add(this.myProductsGV);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPhoto);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seller";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myProductsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.DataGridView myProductsGV;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label priceError;
        private System.Windows.Forms.Label imgError;
        private System.Windows.Forms.Label categoryError;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label quantityError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}