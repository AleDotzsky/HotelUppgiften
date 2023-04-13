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
    public partial class ChooseCustomerForm : Form
    {
        public ChooseCustomerForm()
        {
            InitializeComponent();
            GetAllCustomers();
        }

        private void GetAllCustomers()
        {
            CustomerRepo repo = new CustomerRepo();
            dataGridViewChoose.DataSource = repo.GetAllCustomers();
            dataGridViewChoose.Columns[0].Visible = false;
            dataGridViewChoose.Columns[5].Visible = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            CustomerRepo repo = new CustomerRepo();
            dataGridViewChoose.DataSource = repo.SearchCustomers(textBoxSearch.Text);
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            BookingForm.CustomerID = int.Parse(dataGridViewChoose.SelectedRows[0].Cells[0].Value.ToString());
            this.Close();
        }
    }
}
