
using BookTheShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookTheShowDAL.Repost
{
    public class ShowTimeRepost : IshowTimeRepositry
    {
        MovieDBcontextv _movieDBcontextv;
        public ShowTimeRepost(MovieDBcontextv movieDBcontextv)
        {
            _movieDBcontextv = movieDBcontextv;
        }

        public void AddShow(ShowTimev showTimev)
        {
            _movieDBcontextv.showtimingsv.Add(showTimev);
            _movieDBcontextv.SaveChanges();
        }

        public void DeleteShow(int showId)
        {
            var showTimev = _movieDBcontextv.showtimingsv.Find(showId);
            _movieDBcontextv.showtimingsv.Remove(showTimev);
            _movieDBcontextv.SaveChanges();

        }

        public ShowTimev GetShowById(int showId)
        {
            return _movieDBcontextv.showtimingsv.Find(showId);
        }

        public IEnumerable<ShowTimev> GetShows()
        {
            return _movieDBcontextv.showtimingsv.ToList();
        }

        public void UpdateShow(ShowTimev showTimev)
        {
            _movieDBcontextv.Entry(showTimev).State = EntityState.Modified;
            _movieDBcontextv.SaveChanges();
        }
    }
}
