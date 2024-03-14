using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DtoLayer.BasketDto;
using EntityLayer.Entities;
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
        [HttpPost("AddBasket")]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            using var context = new SignalRContext();
            _basketService.TAdd(new Basket()
            {
                ProductId = createBasketDto.ProductId,
                Count = 1,
                RestaurantTableId = 4,
                Price = context.Products.Where(x => x.ProductId == createBasketDto.ProductId).Select(y => y.Price).FirstOrDefault(),
                TotalPrice = 0,

            });
            return Ok();

        }

    }
}
