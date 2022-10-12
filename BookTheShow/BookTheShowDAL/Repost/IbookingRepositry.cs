using BookTheShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTheShowDAL.Repost
{
    public interface IbookingRepositry
    {
        void AddBooking(Booking booking);

        void UpdateBooking(Booking booking);

        void DeleteBooking(int bookingId);

        Booking GetbookingById(int bookingId);

        IEnumerable<Booking> Getbookings();
    }
}
