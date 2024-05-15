using BusinessLayer.Abstract;
using DtoLayer.RestaurantTableDto;
using EntityLayer.Entities;
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

		[HttpGet]
		public IActionResult RestaurantTableList()
		{
			var values = _restaurantTableService.TGetAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateRestaurantTable(CreateRestaurantTableDto createRestaurantTableDto)
		{
			RestaurantTable restaurantTable = new RestaurantTable()
			{
				Name = createRestaurantTableDto.Name,
				Status = false
			};
			_restaurantTableService.TAdd(restaurantTable);
			return Ok("Masa eklendi.");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteRestaurantTable(int id)
		{
			var value = _restaurantTableService.TGet(id);
			_restaurantTableService.TDelete(value);
			return Ok("Masa Silindi.");
		}
		[HttpPut]
		public IActionResult UpdateRestaurantTable(UpdateRestaurantTableDto updateRestaurantTableDto)
		{
			RestaurantTable restaurantTable = new RestaurantTable()
			{
				RestaurantTableId = updateRestaurantTableDto.RestaurantTableId,
				Name = updateRestaurantTableDto.Name,
				Status = false
			};
			_restaurantTableService.TUpdate(restaurantTable);
			return Ok("Masa Güncellendi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetRestaurantTable(int id)
		{
			var value = _restaurantTableService.TGet(id);
			return Ok(value);
		}
	}
}
