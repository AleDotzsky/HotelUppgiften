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
using Inlamning2DatabasTeknik.Model;
using System.Drawing.Text;
using System.Runtime.InteropServices.ComTypes;

namespace Inlamning2DatabasTeknik.Views
{
    public partial class BookingForm : Form
    {
        public static int CustomerID;
        public BookingForm()
        {
            InitializeComponent();
            comboBoxPeople.SelectedIndex = 0;
        }

        private void buttonChooseCustomer_Click(object sender, EventArgs e)
        {
            ChooseCustomerForm frm = new ChooseCustomerForm();
            frm.ShowDialog();
            CustomerRepo repo = new CustomerRepo();
            Customer customer = new Customer();
            customer = repo.GetCustomer(CustomerID);
            textBoxFirstname.Text = customer.FirstName;
            textBoxLastname.Text = customer.LastName;
            textBoxEmail.Text = customer.Email;
            textBoxPhone.Text = customer.Phone;
        }

        private void buttonCheckAvailability_Click(object sender, EventArgs e)
        {
            CheckAvailableRooms();
        }
        public void CheckAvailableRooms()
        {
            if (dateTimePickerArrival.Value < dateTimePickerDeparture.Value)
            {
                BookingRepo repo = new BookingRepo();
                var availableRooms = repo.SeeAvailableRooms(dateTimePickerArrival.Value, dateTimePickerDeparture.Value, int.Parse(comboBoxPeople.Text));
                dataGridViewAvailableRooms.DataSource = availableRooms.Select(room => new
                { room.RoomID, room.RoomName, room.CostPerNight, room.RoomTypeID, room.RoomType.TypeOfRoom,room.RoomType.Beds, room.RoomType.ExtraBeds }).ToList();

                for (int i = 0; i < dataGridViewAvailableRooms.Columns.Count; i++)
                {
                    dataGridViewAvailableRooms.Columns[i].Visible = false;      
                }
                dataGridViewAvailableRooms.Columns["RoomName"].HeaderText = "Rumsnamn";
                dataGridViewAvailableRooms.Columns["RoomName"].Visible = true;
                dataGridViewAvailableRooms.Columns["CostPerNight"].HeaderText = "Kostnad per natt";
                dataGridViewAvailableRooms.Columns["CostPerNight"].Visible = true;
                dataGridViewAvailableRooms.Columns["TypeOfRoom"].HeaderText = "Rumstyp";
                dataGridViewAvailableRooms.Columns["TypeOfRoom"].Visible = true;
                dataGridViewAvailableRooms.Columns["Beds"].HeaderText = "Sängar";
                dataGridViewAvailableRooms.Columns["Beds"].Visible = true;
                dataGridViewAvailableRooms.Columns["ExtraBeds"].HeaderText = "Extrasängar";
                dataGridViewAvailableRooms.Columns["ExtraBeds"].Visible = true;

            }
            else
                MessageBox.Show("Ditt incheckningsdatum måste vara innan ditt utcheckningsdatum.");
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            if (textBoxFirstname.Text != "" && dataGridViewAvailableRooms.SelectedRows.Count > 0)
            {
                BookingRepo bookingRepo = new BookingRepo();
                Booking booking = new Booking();
                booking.StartDate = dateTimePickerArrival.Value;
                booking.EndDate = dateTimePickerDeparture.Value;
                booking.RoomID = int.Parse(dataGridViewAvailableRooms.SelectedRows[0].Cells[0].Value.ToString());
                booking.CustomerID = CustomerID;
                booking.TotalBeds = int.Parse(dataGridViewAvailableRooms.SelectedRows[0].Cells[5].Value.ToString()) +
                    int.Parse(dataGridViewAvailableRooms.SelectedRows[0].Cells[6].Value.ToString());
                int newBookingId = bookingRepo.InsertNewBooking(booking);
                Invoice newInvoice = CreateInvoice(newBookingId);
                InvoiceRepo invoiceRepo = new InvoiceRepo();
                invoiceRepo.CreateNewInvoice(newInvoice);
                MessageBox.Show("Den önskade bokningen är genomförd och en faktura har skapats för berörd kund");
                ShowSelectedCustomerBookings();
            }
            else
                MessageBox.Show("Du måste välja en kund och ett rum");

        }
        public Invoice CreateInvoice(int newBookingId)
        {
            BookingRepo repo = new BookingRepo();
            double bookingCost = 0;
            if (dataGridViewAvailableRooms.SelectedRows.Count > 0)
            {
                bookingCost = double.Parse(
                dataGridViewAvailableRooms.SelectedRows[0].Cells[2].Value.ToString()) *
                (dateTimePickerDeparture.Value - dateTimePickerArrival.Value).TotalDays;
            }
            else
            {
                Booking booking = repo.GetBooking(newBookingId);
                bookingCost = double.Parse(booking.Room.CostPerNight.ToString()) * (dateTimePickerDeparture.Value - dateTimePickerArrival.Value).TotalDays;
            }
            
            Invoice invoice = new Invoice();
            invoice.AmountToPay = decimal.Parse(bookingCost.ToString());
            invoice.PaymentStatus = false;
            invoice.BookingID = newBookingId;
            invoice.InvoiceDate = DateTime.Now;
            //invoice.InvoiceDate = DateTime.Parse("2022-11-9");
            invoice.DueDate = invoice.InvoiceDate.AddDays(10);
            return invoice;
        }
        private void buttonSeeBookings_Click(object sender, EventArgs e)
        {
            SeeAllBookings();
        }
        public void SeeAllBookings()
        {
            BookingRepo repo = new BookingRepo();
            dataGridViewBookings.DataSource = repo.GetAllBookings().Select(booking => new
            { booking.BookingID, booking.RoomID, booking.Customer.FirstName, 
                booking.Customer.LastName, booking.StartDate, booking.EndDate, booking.Room.RoomName, booking.TotalBeds }).ToList();
            for (int i = 0; i < dataGridViewBookings.Columns.Count; i++)
            {
                dataGridViewBookings.Columns[i].Visible = false;
            }
            dataGridViewBookings.Columns["FirstName"].HeaderText = "Förnamn";
            dataGridViewBookings.Columns["FirstName"].Visible = true;
            dataGridViewBookings.Columns["LastName"].HeaderText = "Efternamn";
            dataGridViewBookings.Columns["LastName"].Visible = true;
            dataGridViewBookings.Columns["StartDate"].HeaderText = "Incheckning";
            dataGridViewBookings.Columns["StartDate"].Visible = true;
            dataGridViewBookings.Columns["EndDate"].HeaderText = "Utcheckning";
            dataGridViewBookings.Columns["EndDate"].Visible = true;
            dataGridViewBookings.Columns["RoomName"].HeaderText = "Rum";
            dataGridViewBookings.Columns["RoomName"].Visible = true;
            dataGridViewBookings.Columns["TotalBeds"].HeaderText = "Sängar";
            dataGridViewBookings.Columns["TotalBeds"].Visible = true;
            //dataGridViewBookings.Columns[0].Visible = false;
            //dataGridViewBookings.Columns[1].Visible = false;
        }

        private void buttonSelectedCustomerBookings_Click(object sender, EventArgs e)
        {
            ShowSelectedCustomerBookings();
        }
        public void ShowSelectedCustomerBookings()
        {
            BookingRepo repo = new BookingRepo();
            dataGridViewBookings.DataSource = repo.GetOneCustomersBookings(CustomerID).Select(booking => new
            { booking.BookingID, booking.RoomID, booking.Customer.FirstName, 
                booking.Customer.LastName, booking.StartDate, booking.EndDate, booking.Room.RoomName, booking.TotalBeds }).ToList();
            dataGridViewBookings.Columns[0].Visible = false;
            dataGridViewBookings.Columns[1].Visible = false;
        }

        private void buttonRemoveBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                BookingRepo repo = new BookingRepo();
                repo.RemoveBooking(int.Parse(dataGridViewBookings.SelectedRows[0].Cells[0].Value.ToString()));
            }
            else
                MessageBox.Show("Du måste ha valt en bokning");
            SeeAllBookings();
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            BookingRepo repo = new BookingRepo();
            var oldBooking = repo.GetBooking((int)dataGridViewBookings.SelectedRows[0].Cells[0].Value);

            var roomAvailability = repo.SeeAvailableRooms(dateTimePickerArrival.Value, dateTimePickerDeparture.Value, int.Parse(comboBoxPeople.Text), oldBooking);

            if (roomAvailability.Any(room => room.RoomID == oldBooking.RoomID))
            {
                if (dataGridViewBookings.SelectedRows.Count > 0)
                {
                    Booking newBooking = new Booking();
                    newBooking.BookingID = int.Parse(dataGridViewBookings.SelectedRows[0].Cells[0].Value.ToString());
                    newBooking.StartDate = dateTimePickerArrival.Value;
                    newBooking.EndDate = dateTimePickerDeparture.Value;
                    if (dataGridViewAvailableRooms.SelectedRows.Count > 0)
                        newBooking.RoomID = int.Parse(dataGridViewAvailableRooms.SelectedRows[0].Cells[0].Value.ToString());
                    else
                        newBooking.RoomID = int.Parse(dataGridViewBookings.SelectedRows[0].Cells[1].Value.ToString());
                    newBooking.CustomerID = CustomerID;
                    if (dataGridViewAvailableRooms.SelectedRows.Count > 0)
                        newBooking.TotalBeds = int.Parse(dataGridViewAvailableRooms.SelectedRows[0].Cells[5].Value.ToString()) +
                            int.Parse(dataGridViewAvailableRooms.SelectedRows[0].Cells[6].Value.ToString());
                    else
                        newBooking.TotalBeds = (int)dataGridViewBookings.SelectedRows[0].Cells[7].Value;
                    Invoice newInvoice = CreateInvoice(newBooking.BookingID);
                    repo.UpdateBooking(newBooking, newInvoice);
                    SeeAllBookings();
                }
                else
                    MessageBox.Show("Du måste ha valt en bokning");
            }
            else
                MessageBox.Show("Rummet är inte ledigt på dina nya datum tyvärr");
        }

        private void buttonClearSelection_Click(object sender, EventArgs e)
        {
            dataGridViewAvailableRooms.ClearSelection();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
