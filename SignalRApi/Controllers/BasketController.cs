using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalRApi.Models;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public IActionResult GetBasketByRestaurantTableID(int id)
        {var values = _basketService.TGetBasketByRestaurantTableNumber(id);
            return Ok(values);
        }

        [HttpGet("BasketListByRestaurantTableWithProductName")]
        public IActionResult BasketListByRestaurantTableWithProductName(int id)
        {
            using var context = new SignalRContext();
            var values = context.Baskets.Include(x => x.Product).Where(y => y.RestaurantTableId == id).Select(z => new RsultBasketListWithProducts()
            {
                BasketID = z.BasketID,
                Count = z.Count,
                Price = z.Price,
                ProductId = z.ProductId,
                ProductName = z.Product.ProductName,
                RestaurantTableId = id,
                TotalPrice = z.TotalPrice
            }).ToList();
            return Ok(values);
        }

    }
}
