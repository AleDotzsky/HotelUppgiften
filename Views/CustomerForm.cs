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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            GetAllCustomers();
        }

        private void GetAllCustomers()
        {
            CustomerRepo repo = new CustomerRepo();
            dataGridViewCustomers.DataSource = repo.GetAllCustomers();
            dataGridViewCustomers.Columns[0].Visible = false;
            dataGridViewCustomers.Columns[5].Visible = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterCustomerForm frm = new RegisterCustomerForm();
            frm.ShowDialog();
            GetAllCustomers();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateCustomerForm frm = new UpdateCustomerForm(
                dataGridViewCustomers.SelectedRows[0].Cells[0].Value.ToString(),
                dataGridViewCustomers.SelectedRows[0].Cells[1].Value.ToString(),
                dataGridViewCustomers.SelectedRows[0].Cells[2].Value.ToString(),
                dataGridViewCustomers.SelectedRows[0].Cells[3].Value.ToString(),
                dataGridViewCustomers.SelectedRows[0].Cells[4].Value.ToString());
            frm.ShowDialog();
            GetAllCustomers();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            CustomerRepo repo = new CustomerRepo();
            repo.RemoveCustomer(int.Parse(dataGridViewCustomers.SelectedRows[0].Cells[0].Value.ToString()));
            GetAllCustomers();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            CustomerRepo repo = new CustomerRepo();
            dataGridViewCustomers.DataSource = repo.SearchCustomers(textBoxSearch.Text);
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
