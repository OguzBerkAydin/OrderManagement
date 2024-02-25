using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RestaurantTableController : ControllerBase
	{
		private readonly IRestaurantTableService _restaurantTableService;

		public RestaurantTableController(IRestaurantTableService restaurantTableService)
		{
			_restaurantTableService = restaurantTableService;
		}

		[HttpGet("TotalTableCount")]
		public IActionResult TotalTableCount()
		{
			return Ok(_restaurantTableService.TTotalTableCount());
		}
	}
}
