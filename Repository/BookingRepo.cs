using Inlamning2DatabasTeknik.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning2DatabasTeknik.Repository
{
    public class BookingRepo
    {
        private HotelDatabase _dbConnection;

        public BookingRepo()
        {
            _dbConnection = new HotelDatabase();
        }

        public List<Room> SeeAvailableRooms(DateTime startDate, DateTime endDate, int peopleStaying)
        {
            var rooms = _dbConnection.Rooms
                .Include("RoomType")
                .AsNoTracking()
                .Where(room=> !room.Bookings
                .Any(booking=>
            (booking.StartDate <= startDate && booking.EndDate >= startDate) ||
            (booking.StartDate <= endDate && booking.EndDate >= endDate) ||
            (booking.StartDate >= startDate && booking.EndDate <= endDate)
            )).ToList();
            rooms = rooms.Where(room => room.RoomType.Beds + room.RoomType.ExtraBeds >= peopleStaying).ToList();
            return rooms;
        }
        public List<Room> SeeAvailableRooms(DateTime startDate, DateTime endDate, int peopleStaying, Booking updateBooking)
        {
            var rooms = _dbConnection.Rooms
                .Include("RoomType")
                .AsNoTracking()
                .Where(room => !room.Bookings
                .Where(booking=> booking.BookingID != updateBooking.BookingID)
                .Any(booking => (booking.StartDate <= startDate && booking.EndDate >= startDate) ||
            (booking.StartDate <= endDate && booking.EndDate >= endDate) ||
            (booking.StartDate >= startDate && booking.EndDate <= endDate)))
                .ToList();
            rooms = rooms.Where(room => room.RoomType.Beds + room.RoomType.ExtraBeds >= peopleStaying).ToList();
            return rooms;
        }
        public int InsertNewBooking(Booking booking)
        {
            _dbConnection.Bookings.Add(booking);
            _dbConnection.SaveChanges();
            return booking.BookingID;
            
        }
        public List<Booking> GetAllBookings()
        {
            return _dbConnection.Bookings.AsNoTracking().ToList();
        }
        public List<Booking> GetOneCustomersBookings(int customerID)
        {
            return _dbConnection.Bookings.AsNoTracking().Where(booking => booking.Customer.CustomerID == customerID).ToList();
        }
        public Booking GetBooking(int bookingID)
        {
            return _dbConnection.Bookings.Find(bookingID);
        }
        public void RemoveBooking(int bookingID)
        {
            InvoiceRepo repo = new InvoiceRepo();
            Invoice invoice = repo.GetInvoice(bookingID);
            repo.DeleteInvoice(invoice);
            _dbConnection.Bookings.Remove(GetBooking(bookingID));
            _dbConnection.SaveChanges();
        }
        public void UpdateBooking(Booking newBooking, Invoice newInvoice)
        {
            Booking orgBooking = GetBooking(newBooking.BookingID);
            _dbConnection.Entry(orgBooking).CurrentValues.SetValues(newBooking);

            InvoiceRepo repo = new InvoiceRepo();
            repo.UpdateInvoice(newInvoice, newBooking.BookingID);

            _dbConnection.SaveChanges();
        }
    }
}
