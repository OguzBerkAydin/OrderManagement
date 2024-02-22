﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfOrderDal : GenericRepository<Order>, IOrderDal
	{
		public EfOrderDal(SignalRContext context) : base(context)
		{
		}

		public int ActiveOrderCount()
		{
			var context = new SignalRContext();
			return context.Orders.Count(p => p.Description == "Müşteri Masada");
		}

		public int TotalOrderCount()
		{
			var context = new SignalRContext();
			return context.Orders.Count();
		}
	}
}
