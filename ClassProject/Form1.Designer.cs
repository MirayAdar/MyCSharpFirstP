
namespace ClassProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgrwCustomers = new System.Windows.Forms.DataGridView();
            this.tbxCustomerId = new System.Windows.Forms.TextBox();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.tbxCustomerSurname = new System.Windows.Forms.TextBox();
            this.tbxCustomerCity = new System.Windows.Forms.TextBox();
            this.tbxCustomerEmail = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerSurname = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrwCustomers
            // 
            this.dgrwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrwCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgrwCustomers.Name = "dgrwCustomers";
            this.dgrwCustomers.RowTemplate.Height = 25;
            this.dgrwCustomers.Size = new System.Drawing.Size(800, 179);
            this.dgrwCustomers.TabIndex = 0;
            // 
            // tbxCustomerId
            // 
            this.tbxCustomerId.Location = new System.Drawing.Point(344, 232);
            this.tbxCustomerId.Name = "tbxCustomerId";
            this.tbxCustomerId.Size = new System.Drawing.Size(179, 23);
            this.tbxCustomerId.TabIndex = 1;
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.Location = new System.Drawing.Point(344, 261);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(179, 23);
            this.tbxCustomerName.TabIndex = 2;
            // 
            // tbxCustomerSurname
            // 
            this.tbxCustomerSurname.Location = new System.Drawing.Point(344, 290);
            this.tbxCustomerSurname.Name = "tbxCustomerSurname";
            this.tbxCustomerSurname.Size = new System.Drawing.Size(179, 23);
            this.tbxCustomerSurname.TabIndex = 3;
            // 
            // tbxCustomerCity
            // 
            this.tbxCustomerCity.Location = new System.Drawing.Point(344, 320);
            this.tbxCustomerCity.Name = "tbxCustomerCity";
            this.tbxCustomerCity.Size = new System.Drawing.Size(179, 23);
            this.tbxCustomerCity.TabIndex = 4;
            // 
            // tbxCustomerEmail
            // 
            this.tbxCustomerEmail.Location = new System.Drawing.Point(344, 350);
            this.tbxCustomerEmail.Name = "tbxCustomerEmail";
            this.tbxCustomerEmail.Size = new System.Drawing.Size(179, 23);
            this.tbxCustomerEmail.TabIndex = 5;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(245, 264);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(29, 15);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "İsim";
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.AutoSize = true;
            this.lblCustomerSurname.Location = new System.Drawing.Point(245, 293);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(48, 15);
            this.lblCustomerSurname.TabIndex = 7;
            this.lblCustomerSurname.Text = "Soyisim";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(245, 322);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 15);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "Şehir";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(245, 352);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(36, 15);
            this.lblCustomerEmail.TabIndex = 9;
            this.lblCustomerEmail.Text = "Email";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(245, 235);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(17, 15);
            this.lblCustomerId.TabIndex = 10;
            this.lblCustomerId.Text = "Id";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(447, 401);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 11;
            this.btnAddCustomer.Text = "Ekle";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCustomerSurname);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.tbxCustomerEmail);
            this.Controls.Add(this.tbxCustomerCity);
            this.Controls.Add(this.tbxCustomerSurname);
            this.Controls.Add(this.tbxCustomerName);
            this.Controls.Add(this.tbxCustomerId);
            this.Controls.Add(this.dgrwCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrwCustomers;
        private System.Windows.Forms.TextBox tbxCustomerId;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.TextBox tbxCustomerSurname;
        private System.Windows.Forms.TextBox tbxCustomerCity;
        private System.Windows.Forms.TextBox tbxCustomerEmail;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerSurname;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Button btnAddCustomer;
    }
}

