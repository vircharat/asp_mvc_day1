using BookTheShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTheShowDAL.Repost
{
    public interface ItheatreRepositry
    {
        void AddTheatre(Theatrev theatre);

        void UpdateTheatre(Theatrev theatre);

        void DeleteTheatre(int theatreId);

        Theatrev GetTheatreById(int theatreId);

        IEnumerable<Theatrev> GetTheatres();
    }
}
