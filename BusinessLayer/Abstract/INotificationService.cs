﻿using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface INotificationService : IGenericService<Notification>
	{
		int TNotificationCount(bool status);
		List<Notification> TGetAllNotifications(bool status);
		void TNotificationStatusChange(bool status, int id);
	}
}
