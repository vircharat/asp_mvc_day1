using BookTheShowDAL.Repost;
using BookTheShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTheShowBLL.services
{
    public class TheatreService
    {
        ItheatreRepositry _itheatreRepositry;
        public TheatreService(ItheatreRepositry itheatreRepositry)
        {
            _itheatreRepositry = itheatreRepositry;
        }

        public void AddTheatre(Theatrev theatrev)
        {
           _itheatreRepositry.AddTheatre(theatrev);
        }

        public void UpdateTheatre(Theatrev theatrev)
        {
           _itheatreRepositry.UpdateTheatre(theatrev);
        }

        public void DeleteTheatre(int theatreId)
        {
           _itheatreRepositry.DeleteTheatre(theatreId);
        }

        public void GetTheatrebyId(int theatreId)
        {
            _itheatreRepositry.GetTheatreById(theatreId);
        }

        public IEnumerable<Theatrev> GetTheatres()
        {
            return _itheatreRepositry.GetTheatres();
        }
    }
}
