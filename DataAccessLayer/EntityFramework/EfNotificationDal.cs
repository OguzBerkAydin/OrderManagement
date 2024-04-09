using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Migrations;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
	{
		public EfNotificationDal(SignalRContext context) : base(context)
		{
		}

		public List<Notification> GetAllNotifications(bool status)
		{
			using (var context = new SignalRContext())
			{
				return context.Notifications.Where(notification => notification.Status == status).ToList();
			}
		}

		public int NotificationCount(bool status)
		{
			using var context = new SignalRContext();
			return context.Notifications.Count(notification => notification.Status == status);
		}
	}
}
