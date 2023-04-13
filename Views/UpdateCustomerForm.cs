using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inlamning2DatabasTeknik.Model;
using Inlamning2DatabasTeknik.Repository;

namespace Inlamning2DatabasTeknik.Views
{
    public partial class UpdateCustomerForm : Form
    {
        public UpdateCustomerForm(string customerID, string customerFirstname, string customerLastname, string customerEmail, string customerPhone)
        {
            InitializeComponent();
            textBoxCustomerID.Text = customerID;
            textBoxFirstname.Text = customerFirstname;
            textBoxLastname.Text = customerLastname;
            textBoxEmail.Text = customerEmail;
            textBoxPhone.Text = customerPhone;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int supplierID = int.Parse(textBoxCustomerID.Text);
            CustomerRepo repo = new CustomerRepo();
            Customer customer = new Customer();
            customer.CustomerID = supplierID;
            customer.FirstName = textBoxFirstname.Text;
            customer.LastName = textBoxLastname.Text;
            customer.Email = textBoxEmail.Text;
            customer.Phone = textBoxPhone.Text;
            repo.UpdateCustomer(supplierID, customer);
            this.Close();
        }
    }
}
