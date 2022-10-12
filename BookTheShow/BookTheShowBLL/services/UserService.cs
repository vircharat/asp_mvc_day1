using BookTheShowDAL.Repost;
using BookTheShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTheShowBLL.services
{
    public class UserService
    {
        IuserRepositry _iuserRepositry;
        public UserService(IuserRepositry iuserRepositry)
        {
            _iuserRepositry = iuserRepositry;
        }

        public void AddUser(Userv userv)
        {
            _iuserRepositry.AddUser(userv);
        }

        public void UpdateUser(Userv userv)
        {
            _iuserRepositry.UpdateUser(userv);
        }

        public void DeleteUser(int userId)
        {
            _iuserRepositry.DeleteUser(userId);
        }

        public void GetUserbyId(int userId)
        {
            _iuserRepositry.GetUserById(userId);
        }

        public IEnumerable<Userv> GetUsers()
        {
            return _iuserRepositry.GetUsers();
        }
    }
}
