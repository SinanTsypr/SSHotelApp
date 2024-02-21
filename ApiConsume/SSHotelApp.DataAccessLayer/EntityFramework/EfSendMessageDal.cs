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
    public class EfSendMessageDal : GenericRepository<SendMessage> , ISendMessageDal
    {
        public EfSendMessageDal(Context context) : base(context)
        {
            
        }

        public int GetSendMessageCount()
        {
            var context = new Context();
            return context.SendMessages.Count();
        }
    }
}
