using BookTheShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookTheShowDAL.Repost
{
    public class BookingRepost:IbookingRepositry
    {
        MovieDBcontextv _movieDBcontextv;

        public BookingRepost(MovieDBcontextv movieDBcontextv)
        {
            _movieDBcontextv = movieDBcontextv;
        }

        public void AddBooking(Booking booking)
        {

            _movieDBcontextv.bookings.Add(booking);
            _movieDBcontextv.SaveChanges();
        }

        public void DeleteBooking(int bookingId)
        {
            var booking = _movieDBcontextv.bookings.Find(bookingId);
            _movieDBcontextv.bookings.Remove(booking);
            _movieDBcontextv.SaveChanges();
        }

        public Booking GetbookingById(int bookingId)
        {
            return _movieDBcontextv.bookings.Find(bookingId);
        }


        public IEnumerable<Booking> Getbookings()
        {
            return _movieDBcontextv.bookings.ToList();
        }

        public void UpdateBooking(Booking booking)
        {
            _movieDBcontextv.Entry(booking).State = EntityState.Modified;
            _movieDBcontextv.SaveChanges();
        }

        

    }
}
