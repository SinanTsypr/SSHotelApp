using SSHotelApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.BusinessLayer.Abstract
{
    public interface IRoomService : IGenericService<Room>
    {
        int TRoomCount();
    }
}
