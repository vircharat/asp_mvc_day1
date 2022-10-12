using BookTheShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookTheShowDAL.Repost
{
    public class TheatreeRepost:ItheatreRepositry
    {
        MovieDBcontextv _movieDBcontextv;
        public TheatreeRepost(MovieDBcontextv movieDBcontextv)
        {
            _movieDBcontextv = movieDBcontextv;
        }

        public void AddTheatre(Theatrev theatrev)
        {
            _movieDBcontextv.theatresv.Add(theatrev);
            _movieDBcontextv.SaveChanges();
        }

        public void DeleteTheatre(int theatreId)
        {
            var theatrev = _movieDBcontextv.theatresv.Find(theatreId);
            _movieDBcontextv.theatresv.Remove(theatrev);
            _movieDBcontextv.SaveChanges();

        }

        public Theatrev GetTheatreById(int TheatreId)
        {
            return _movieDBcontextv.theatresv.Find(TheatreId);
        }

        public IEnumerable<Theatrev> GetTheatres()
        {
            return _movieDBcontextv.theatresv.ToList();
        }

        public void UpdateTheatre(Theatrev theatrev)
        {
            _movieDBcontextv.Entry(theatrev).State = EntityState.Modified;
            _movieDBcontextv.SaveChanges();
        }
    }
}
