using BusinessLayer.Abstract;
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

		public int TNotificationCount(bool status)
		{
			return _notificationDal.NotificationCount(status);
		}

		public void TUpdate(Notification entity)
		{
			_notificationDal.Update(entity);
		}
	}
}
