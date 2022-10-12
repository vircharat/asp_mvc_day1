using BookTheShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTheShowDAL.Repost
{
    public interface ImovieRepository
    {
        void AddMovie(Moviev movie);

        void UpdateMovie(Moviev movie);

        void DeleteMovie(int movieId);

        Moviev GetMovieById(int movieId);

        IEnumerable<Moviev> GetMovies();
    }
    


}
