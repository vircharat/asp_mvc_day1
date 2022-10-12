using BookTheShowDAL.Repost;
using BookTheShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTheShowBLL.services
{
    public class ShowTimeService
    {
        IshowTimeRepositry _showTimeRepositry;
        public ShowTimeService(IshowTimeRepositry showTimeRepositry)
        {
            _showTimeRepositry =showTimeRepositry;
        }

        public void AddShowTime(ShowTimev ShowTimev)
        {
            _showTimeRepositry.AddShow(ShowTimev);
        }

        public void UpdateShowTime(ShowTimev ShowTimev)
        {
            _showTimeRepositry.UpdateShow(ShowTimev);
        }

        public void DeleteShowTime(int ShowTimeId)
        {
           _showTimeRepositry.DeleteShow(ShowTimeId);
        }

        public void GetShowTimebyId(int ShowTimeId)
        {
            _showTimeRepositry.GetShowById(ShowTimeId);
        }

        public IEnumerable<ShowTimev> GetShowTimes()
        {
            return _showTimeRepositry.GetShows();
        }
    }
}
