
namespace Online_Market
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.headinglbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.custRadio = new System.Windows.Forms.RadioButton();
            this.salesRadio = new System.Windows.Forms.RadioButton();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.LinkLabel();
            this.emailError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.typeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headinglbl
            // 
            this.headinglbl.AutoSize = true;
            this.headinglbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.headinglbl.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headinglbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.headinglbl.Location = new System.Drawing.Point(113, 9);
            this.headinglbl.Name = "headinglbl";
            this.headinglbl.Size = new System.Drawing.Size(690, 65);
            this.headinglbl.TabIndex = 0;
            this.headinglbl.Text = "Weclome to Online Shopping";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(232, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(232, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(366, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(366, 247);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(217, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // custRadio
            // 
            this.custRadio.AutoSize = true;
            this.custRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custRadio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.custRadio.Location = new System.Drawing.Point(366, 321);
            this.custRadio.Name = "custRadio";
            this.custRadio.Size = new System.Drawing.Size(111, 24);
            this.custRadio.TabIndex = 7;
            this.custRadio.TabStop = true;
            this.custRadio.Text = "Customer";
            this.custRadio.UseVisualStyleBackColor = true;
            // 
            // salesRadio
            // 
            this.salesRadio.AutoSize = true;
            this.salesRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesRadio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.salesRadio.Location = new System.Drawing.Point(366, 361);
            this.salesRadio.Name = "salesRadio";
            this.salesRadio.Size = new System.Drawing.Size(142, 24);
            this.salesRadio.TabIndex = 8;
            this.salesRadio.TabStop = true;
            this.salesRadio.Text = "Sales Person";
            this.salesRadio.UseVisualStyleBackColor = true;
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.Black;
            this.loginbtn.Location = new System.Drawing.Point(404, 436);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(93, 31);
            this.loginbtn.TabIndex = 9;
            this.loginbtn.Text = "Log in";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(361, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register";
            // 
            // registerLabel
            // 
            this.registerLabel.ActiveLinkColor = System.Drawing.Color.MediumPurple;
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.LinkColor = System.Drawing.Color.Red;
            this.registerLabel.Location = new System.Drawing.Point(458, 530);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(55, 25);
            this.registerLabel.TabIndex = 11;
            this.registerLabel.TabStop = true;
            this.registerLabel.Text = "here";
            this.registerLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLabel_LinkClicked);
            // 
            // emailError
            // 
            this.emailError.AutoSize = true;
            this.emailError.ForeColor = System.Drawing.Color.Red;
            this.emailError.Location = new System.Drawing.Point(367, 196);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(16, 17);
            this.emailError.TabIndex = 12;
            this.emailError.Text = "  ";
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(367, 272);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(16, 17);
            this.passwordError.TabIndex = 14;
            this.passwordError.Text = "  ";
            // 
            // typeError
            // 
            this.typeError.AutoSize = true;
            this.typeError.ForeColor = System.Drawing.Color.Red;
            this.typeError.Location = new System.Drawing.Point(367, 388);
            this.typeError.Name = "typeError";
            this.typeError.Size = new System.Drawing.Size(16, 17);
            this.typeError.TabIndex = 15;
            this.typeError.Text = "  ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(897, 645);
            this.Controls.Add(this.typeError);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.emailError);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.salesRadio);
            this.Controls.Add(this.custRadio);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.headinglbl);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headinglbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton custRadio;
        private System.Windows.Forms.RadioButton salesRadio;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel registerLabel;
        private System.Windows.Forms.Label emailError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label typeError;
    }
}

