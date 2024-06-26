﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
	public class NotificatonManager : INotificationService
	{
		private readonly INotificationDal _notificationDal;

		public NotificatonManager(INotificationDal notificationDal)
		{
			_notificationDal = notificationDal;
		}

		public void TAdd(Notification entity)
		{
			_notificationDal.Add(entity);
		}

		public void TDelete(Notification entity)
		{
			_notificationDal.Delete(entity);
		}

		public Notification TGet(int id)
		{
			return _notificationDal.Get(id);
		}

		public List<Notification> TGetAll()
		{
			return _notificationDal.GetAll();
		}

		public List<Notification> TGetAllNotifications(bool status)
		{
			return _notificationDal.GetAllNotifications(status);
		}

		public int TNotificationCount(bool status)
		{
			return _notificationDal.NotificationCount(status);
		}

		public void TNotificationStatusChange(bool status, int id)
		{
			_notificationDal.NotificationStatusChange(status, id);
		}

		public void TUpdate(Notification entity)
		{
			_notificationDal.Update(entity);
		}
	}
}
