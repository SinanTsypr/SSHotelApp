using SSHotelApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void BookingStatusChangeApproved(Booking booking);
        void BookingStatusChangeApproved2(int id);
        int GetBookingCount();
        List<Booking> Last6Bookings();
        void BookingStatusChangeApproved3(int id);
        void BookingStatusChangeReject(int id);
        void BookingStatusChangePending(int id);
    }
}
