using BookTheShowDAL.Repost;
using BookTheShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTheShowBLL.services
{
    public class BookingService
    {
        IbookingRepositry _ibookingRepositry;
        public BookingService(IbookingRepositry ibookingRepositry)
        {
            _ibookingRepositry = ibookingRepositry;
        }

        public void AddBooking(Booking booking)
        {
            _ibookingRepositry.AddBooking(booking);
        }

        public void UpdateBooking(Booking booking)
        {
            _ibookingRepositry.UpdateBooking(booking);
        }

        public void DeleteBooking(int bookingId)
        {
            _ibookingRepositry.DeleteBooking(bookingId);
        }

        public void GetBookingbyId(int bookingId)
        {
            _ibookingRepositry.GetbookingById(bookingId);
        }

        public IEnumerable<Booking> GetBookings()
        {
            return _ibookingRepositry.Getbookings();
        }

    }
}
