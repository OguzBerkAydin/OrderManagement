using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface INotificationDal : IGenericDal<Notification>
	{
		int NotificationCount(bool status);
		List<Notification> GetAllNotifications(bool status);
		void NotificationStatusChange(bool status, int id);
	}
}
