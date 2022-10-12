using BookTheShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookTheShowDAL.Repost
{
    public class UserRepost:IuserRepositry
    {
        MovieDBcontextv _movieDBcontextv;

        public UserRepost(MovieDBcontextv movieDBcontextv)
        {
            _movieDBcontextv = movieDBcontextv;
        }

        public void AddUser(Userv userv)
        {

            _movieDBcontextv.userv.Add(userv);
            _movieDBcontextv.SaveChanges();
        }

       

        public void DeleteUser(int userId)
        {
            var userv = _movieDBcontextv.userv.Find(userId);
            _movieDBcontextv.userv.Remove(userv);
            _movieDBcontextv.SaveChanges();
        }

        public Userv GetUserById(int userId)
        {
            return _movieDBcontextv.userv.Find(userId);
        }

        public IEnumerable<Userv> GetUsers() // ucan give lis
        {
            return _movieDBcontextv.userv.ToList();
        }



        public void UpdateUser(Userv userv)
        {
            _movieDBcontextv.Entry(userv).State = EntityState.Modified;
            _movieDBcontextv.SaveChanges();
        }
    }
}
