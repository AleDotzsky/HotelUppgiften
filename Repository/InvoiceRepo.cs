using Inlamning2DatabasTeknik.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning2DatabasTeknik.Repository
{
    public class InvoiceRepo
    {
        private HotelDatabase _dbConnection;
        public InvoiceRepo()
        {
            _dbConnection = new HotelDatabase();
        }
        public List<Invoice> GetAllInvoices()
        {
            return _dbConnection.Invoices.ToList();
        }
        public List<Invoice> GetOneCustomersInvoices(int customerID)
        {
            return _dbConnection.Invoices.Where(invoice=> invoice.Booking.CustomerID == customerID).ToList();
        }
        public void PayInvoice(int invoiceID)
        {
            Invoice invoice = GetInvoiceId(invoiceID);
            invoice.PaymentStatus = true;
            _dbConnection.SaveChanges();
        }
        public void CreateNewInvoice(Invoice invoice)
        {
            _dbConnection.Invoices.Add(invoice);
            _dbConnection.SaveChanges();
        }
        public Invoice GetInvoice(int bookingID)
        {
            return _dbConnection.Invoices.Single(invoice => invoice.BookingID == bookingID);
        
        }
        public Invoice GetInvoiceId(int invoiceID)
        {
            return _dbConnection.Invoices.Find(invoiceID);
        }
        public void DeleteInvoice(Invoice invoice)
        {
            _dbConnection.Invoices.Remove(invoice);
            _dbConnection.SaveChanges();
        }
        public void UpdateInvoice(Invoice newInvoice, int bookingID)
        {
            Invoice orgInvoice = GetInvoice(bookingID);
            newInvoice.InvoiceID = orgInvoice.InvoiceID;
            _dbConnection.Entry(orgInvoice).CurrentValues.SetValues(newInvoice);

            _dbConnection.SaveChanges();
        }
    }
}
