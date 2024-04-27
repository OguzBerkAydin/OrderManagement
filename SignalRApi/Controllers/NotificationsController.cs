using BusinessLayer.Abstract;
using DtoLayer.NotificationDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NotificationsController : ControllerBase
	{
		private readonly INotificationService _notificationService;

		public NotificationsController(INotificationService notificationService)
		{
			_notificationService = notificationService;
		}
		[HttpGet]
		public IActionResult NotificationsList()
		{
			return Ok(_notificationService.TGetAll());
		}

		[HttpGet("NotificationCount")]
		public IActionResult NotificationCount(bool status)
		{
			return Ok(_notificationService.TNotificationCount(status));
		}
		[HttpGet("GetAllNotifications")]
		public IActionResult GetAllNotifications(bool status)
		{
			return Ok(_notificationService.TGetAllNotifications(status));
		}
		[HttpPost]
		public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
		{
			Notification notification = new()
			{
				Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
				Description = createNotificationDto.Description,
				Icon = createNotificationDto.Icon,
				Status = false,
				Type = createNotificationDto.Type
			};
			_notificationService.TAdd(notification);
			return Ok("Ekleme işlemi Başarıyla Yapıldı");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteNotification(int id)
		{
			var value = _notificationService.TGet(id);
			_notificationService.TDelete(value);
			return Ok("Bildirim Silindi");
		}
		[HttpGet("{id}")]
		public IActionResult GetNotification(int id)
		{
			return Ok(_notificationService.TGet(id));
			
		}
		[HttpGet("NotificationStatusChange/{id}")]
		public IActionResult NotificationStatusChange(bool status, int id)
		{
			_notificationService.TNotificationStatusChange(status, id);
			return Ok("Durum Değiştirildi");

		}
		[HttpPut]
		public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
		{
			Notification notification = new()
			{
				NotificationId = updateNotificationDto.NotificationId,
				Date = updateNotificationDto.Date,
				Description = updateNotificationDto.Description,
				Icon = updateNotificationDto.Icon,
				Status = updateNotificationDto.Status,
				Type = updateNotificationDto.Type
			};
			_notificationService.TUpdate(notification);
			return Ok("Güncelleme İşlemi Başarıyla Yapıldı");
		}

	}
}
