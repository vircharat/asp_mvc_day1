using BookTheShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTheShowDAL.Repost
{
    public interface IshowTimeRepositry
    {
        void AddShow(ShowTimev showTimev);

        void UpdateShow(ShowTimev showTimev);

        void DeleteShow(int showId);

        ShowTimev GetShowById(int showId);

        IEnumerable<ShowTimev> GetShows();


    }
}
