using BookTheShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//implementation of interface

namespace BookTheShowDAL.Repost
{
    public class MovieRepost : ImovieRepository
    {
        MovieDBcontextv _movieDBcontextv;

        public MovieRepost(MovieDBcontextv movieDBcontextv)
        {
           _movieDBcontextv = movieDBcontextv;
        }

        public void AddMovie(Moviev movie)
        {
            
            _movieDBcontextv.moviesv.Add(movie);
            _movieDBcontextv.SaveChanges();
        }

        public void DeleteMovie(int movieId)
        {
           var movie=_movieDBcontextv.moviesv.Find(movieId);
            _movieDBcontextv.moviesv.Remove(movie);
            _movieDBcontextv.SaveChanges();
        }

        public Moviev GetMovieById(int movieId)
        {
            return _movieDBcontextv.moviesv.Find(movieId);
        }

        public IEnumerable<Moviev> GetMovies() // ucan give lis
        {
            return _movieDBcontextv.moviesv.ToList();
        }

    

        public void UpdateMovie(Moviev movie)
        {
            _movieDBcontextv.Entry(movie).State = EntityState.Modified;
            _movieDBcontextv.SaveChanges();
        }
    }
}
