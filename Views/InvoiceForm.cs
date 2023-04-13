using Inlamning2DatabasTeknik.Model;
using Inlamning2DatabasTeknik.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlamning2DatabasTeknik.Views
{
    public partial class InvoiceForm : Form
    {
        public static int CustomerID;
        public InvoiceForm()
        {
            InitializeComponent();
        }
        private void buttonChooseCustomer_Click(object sender, EventArgs e)
        {
            CustomerInvoiceForm frm = new CustomerInvoiceForm();
            frm.ShowDialog();
            CustomerRepo repo = new CustomerRepo();
            Customer customer = new Customer();
            customer = repo.GetCustomer(CustomerID);
            textBoxFirstname.Text = customer.FirstName;
            textBoxLastname.Text = customer.LastName;
            textBoxEmail.Text = customer.Email;
            textBoxPhone.Text = customer.Phone;
        }

        private void buttonSeeAllInvoices_Click(object sender, EventArgs e)
        {
            GetAllInvoices();
        }
        public void GetAllInvoices()
        {
            InvoiceRepo repo = new InvoiceRepo();
            var allInvoices = repo.GetAllInvoices();
            dataGridViewInvoices.DataSource = allInvoices.Select(invoice=> new
            { invoice.InvoiceID, invoice.Booking.Customer.FirstName, invoice.Booking.Customer.LastName, invoice.AmountToPay, invoice.PaymentStatus, invoice.InvoiceDate, invoice.DueDate }).ToList();
            for (int i = 0; i < dataGridViewInvoices.Columns.Count; i++)
            {
                dataGridViewInvoices.Columns[i].Visible = false;
            }
            dataGridViewInvoices.Columns["FirstName"].HeaderText = "Förnamn";
            dataGridViewInvoices.Columns["FirstName"].Visible = true;
            dataGridViewInvoices.Columns["LastName"].HeaderText = "Efternamn";
            dataGridViewInvoices.Columns["LastName"].Visible = true;
            dataGridViewInvoices.Columns["AmountToPay"].HeaderText = "Att betala";
            dataGridViewInvoices.Columns["AmountToPay"].Visible = true;
            dataGridViewInvoices.Columns["PaymentStatus"].HeaderText = "Betalstatus";
            dataGridViewInvoices.Columns["PaymentStatus"].Visible = true;
            dataGridViewInvoices.Columns["InvoiceDate"].HeaderText = "Registrerat datum";
            dataGridViewInvoices.Columns["InvoiceDate"].Visible = true;
            dataGridViewInvoices.Columns["DueDate"].HeaderText = "Betaldatum";
            dataGridViewInvoices.Columns["DueDate"].Visible = true;
        }

        private void buttonSeeCustomerInvoices_Click(object sender, EventArgs e)
        {
            InvoiceRepo repo = new InvoiceRepo();
            var custInvoices = repo.GetOneCustomersInvoices(CustomerID);
            dataGridViewInvoices.DataSource = custInvoices.Select(invoice => new
            { invoice.InvoiceID, invoice.Booking.Customer.FirstName, invoice.Booking.Customer.LastName, invoice.AmountToPay, invoice.PaymentStatus, invoice.InvoiceDate, invoice.DueDate }).ToList();
            for (int i = 0; i < dataGridViewInvoices.Columns.Count; i++)
            {
                dataGridViewInvoices.Columns[i].Visible = false;
            }
            dataGridViewInvoices.Columns["FirstName"].HeaderText = "Förnamn";
            dataGridViewInvoices.Columns["FirstName"].Visible = true;
            dataGridViewInvoices.Columns["LastName"].HeaderText = "Efternamn";
            dataGridViewInvoices.Columns["LastName"].Visible = true;
            dataGridViewInvoices.Columns["AmountToPay"].HeaderText = "Att betala";
            dataGridViewInvoices.Columns["AmountToPay"].Visible = true;
            dataGridViewInvoices.Columns["PaymentStatus"].HeaderText = "Betalstatus";
            dataGridViewInvoices.Columns["PaymentStatus"].Visible = true;
            dataGridViewInvoices.Columns["InvoiceDate"].HeaderText = "Registrerat datum";
            dataGridViewInvoices.Columns["InvoiceDate"].Visible = true;
            dataGridViewInvoices.Columns["DueDate"].HeaderText = "Betaldatum";
            dataGridViewInvoices.Columns["DueDate"].Visible = true;
        }

        private void buttonRegisterPay_Click(object sender, EventArgs e)
        {
            InvoiceRepo repo = new InvoiceRepo();
            repo.PayInvoice((int)dataGridViewInvoices.SelectedRows[0].Cells[0].Value);
            GetAllInvoices();
        }

        private void buttonRemoveInvoice_Click(object sender, EventArgs e)
        {
            InvoiceRepo repo = new InvoiceRepo();
            repo.DeleteInvoice(repo.GetInvoiceId((int)dataGridViewInvoices.SelectedRows[0].Cells[0].Value));
            GetAllInvoices();
        }
    }
}
