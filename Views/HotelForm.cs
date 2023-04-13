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
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
            RemoveUnpaidBookings();
        }
        public void RemoveUnpaidBookings()
        {
            BookingRepo bookingRepo = new BookingRepo();
            InvoiceRepo repo = new InvoiceRepo();
            var allInvoices = repo.GetAllInvoices();
            var bookingsToRemove = allInvoices.Where(i => i.DueDate < DateTime.Now && i.PaymentStatus == false).ToList();
            foreach (var booking in bookingsToRemove)
            {
                bookingRepo.RemoveBooking(booking.BookingID);
            }
        }
        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm frm = new CustomerForm();
            frm.ShowDialog();
        }

        private void buttonBookings_Click(object sender, EventArgs e)
        {
            BookingForm frm = new BookingForm();
            frm.ShowDialog();
        }

        private void buttonInvoices_Click(object sender, EventArgs e)
        {
            InvoiceForm frm = new InvoiceForm();
            frm.ShowDialog();
        }
    }
}
