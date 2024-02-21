﻿using SSHotelApp.DataAccessLayer.Abstract;
using SSHotelApp.DataAccessLayer.Concrete;
using SSHotelApp.DataAccessLayer.Repositories;
using SSHotelApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.DataAccessLayer.EntityFramework
{
    public class EfMessageCategoryDal: GenericRepository<MessageCategory> , IMessageCategoryDal
    {
        public EfMessageCategoryDal(Context context) : base(context)
        {
            
        }
    }
}
