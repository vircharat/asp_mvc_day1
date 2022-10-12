using BookTheShowDAL;
using BookTheShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTheShowBLL
{
    public class ShowTimeBLL
    {

        /*ShowTimeOperationv ShowTimeOperationv = new ShowTimeOperationv();*/
        ShowTimeOperationv showTimeOperationv = null;
        public ShowTimeBLL(ShowTimeOperationv showTimeOperationv)
        {
            this.showTimeOperationv = showTimeOperationv;
        }

        public string AddshowtimevBLL(ShowTimev showtimev)
        {
            string msg = "";
            msg = showTimeOperationv.AddShow(showtimev);
            return msg;
        }

        public string DeleteshowtimevBLL(int showtimevId)
        {
            string msg = "";
            msg = showTimeOperationv.DeleteShow(showtimevId);
            return msg;

        }

        public string UpdateTheatreBLL(ShowTimev showtimev)
        {
            string msg = "";
            msg = showTimeOperationv.UpdateShow(showtimev);
            return msg;

        }
        public List<ShowTimev> showallBLL()
        {

            List<ShowTimev> showtimevs = showTimeOperationv.ShowAll();
            return showtimevs;

        }
    }
}
