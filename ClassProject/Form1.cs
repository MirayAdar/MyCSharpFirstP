using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            dgrwCustomers.DataSource = customerService.GetAll();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(tbxCustomerId.Text);
            customer.FirstName = tbxCustomerName.Text;
            customer.LastName = tbxCustomerSurname.Text;
            customer.City = tbxCustomerCity.Text;
            customer.Email = tbxCustomerEmail.Text;

            CustomerService customerService = new CustomerService();
            customerService.AddCustomer(customer);
            dgrwCustomers.DataSource = null;
            dgrwCustomers.DataSource = customerService.GetAll();

        }
    }
}
