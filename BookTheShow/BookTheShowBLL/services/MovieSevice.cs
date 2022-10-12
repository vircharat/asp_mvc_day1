using BookTheShowDAL.Repost;
using BookTheShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTheShowBLL.services
{
    public class MovieSevice
    {
        ImovieRepository _movieRepository;
        public MovieSevice(ImovieRepository imovieRepository)
        {
            _movieRepository = imovieRepository;
        }

        public void AddMovie(Moviev moviev)
        {
            _movieRepository.AddMovie(moviev);
        }

        public void UpdateMovie(Moviev moviev)
        {
            _movieRepository.UpdateMovie(moviev);
        }

        public void DeleteMovie(int movieId)
        {
            _movieRepository.DeleteMovie(movieId);
        }

        public void GetMoviebyId(int movieId)
        {
            _movieRepository.GetMovieById(movieId);
        }

        public IEnumerable<Moviev> GetMovies()
        {
            return _movieRepository.GetMovies();
        }
    }
}
