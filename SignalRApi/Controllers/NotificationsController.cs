using BusinessLayer.Abstract;
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

	}
}
