using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.SignalR;

namespace SignalRApi.Hubs
{
	public class SignalRHub : Hub
	{
		private readonly ICategoryService _categoryService;
		private readonly IProductService _productService;
		private readonly IOrderService _orderService;
		private readonly IMoneyCaseService _moneyCaseService;
		private readonly IRestaurantTableService _restaurantTableService;

		public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IRestaurantTableService restaurantTableService)
		{
			_categoryService = categoryService;
			_productService = productService;
			_orderService = orderService;
			_moneyCaseService = moneyCaseService;
			_restaurantTableService = restaurantTableService;
		}

		public async Task SendCategoryCount()
		{
			var value = _categoryService.TCategoryCount();
			await Clients.All.SendAsync("ReceiveCategoryCount", value);
		}
		public async Task SendProductCount()
		{
			var value = _productService.TProductCount();
			await Clients.All.SendAsync("ReceiveProductCount", value);
		}
		public async Task SendActiveCategoryCount()
		{
			var value = _categoryService.TActiveCategoryCount();
			await Clients.All.SendAsync("ReceiveActiveCategoryCount", value);
		}
		public async Task SendPassiveCategoryCount()
		{
			var value = _categoryService.TPassiveCategoryCount();
			await Clients.All.SendAsync("ReceivePassiveCategoryCount", value);
		}
		public async Task SendDrinkCount()
		{
			var value = _productService.TProductCountByCategoryName("icecek");
			await Clients.All.SendAsync("ReceiveDrinkCount", value);
		}
		public async Task SendDessertCount()
		{
			var value = _productService.TProductCountByCategoryName("tatlı");
			await Clients.All.SendAsync("ReceiveDessertCount", value);
		}
        public async Task SendProductPriceAvg()
        {
            var value = _productService.TProductPriceAvg();
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value.ToString("0.00") + "₺");
        }
		public async Task SendMostExpensiveProduct()
		{
			var value = _productService.TProductNameByMaxPrice();
			await Clients.All.SendAsync("ReceiveMostExpensiveProduct", value);
		}
		public async Task SendCheapestProduct()
		{
			var value = _productService.TProductNameByMinPrice();
			await Clients.All.SendAsync("ReceiveCheapestProduct", value);
		}
		public async Task SendDessertProductAvg()
		{
			var value = _productService.TProductPriceAvg("tatlı");
			await Clients.All.SendAsync("ReceiveDessertProductAvg", value.ToString("0.00") + "₺");
		}
		public async Task SendTotalOrderCount()
		{
			var value = _orderService.TTotalOrderCount();
			await Clients.All.SendAsync("ReceiveTotalOrderCount", value);
		}
		public async Task SendActiveOrderCount()
		{
			var value = _orderService.TActiveOrderCount();
			await Clients.All.SendAsync("ReceiveActiveOrderCount", value);
		}
		public async Task SendLastOrderTotalPrice()
		{
			var value = _orderService.TLastOrderPrice();
			await Clients.All.SendAsync("ReceiveLastOrderTotalPrice", value.ToString("0.00") + "₺");
		}
		public async Task SendTotalAmountOfMoneyCase()
		{
			var value = _moneyCaseService.TTotalAmountOfMoneyCase();
			await Clients.All.SendAsync("ReceiveTotalAmountOfMoneyCase", value.ToString("0.00") + "₺");
		}
		public async Task SendTodayTotalPrice()
		{
			var value = _orderService.TTotayTotalPrice();
			await Clients.All.SendAsync("ReceiveTodayTotalPrice", value.ToString("0.00") + "₺");
		}
		public async Task SendTotalTableCount()
		{
			var value = _restaurantTableService.TTotalTableCount();
			await Clients.All.SendAsync("ReceiveTotalTableCount", value);
		} 
	}
}
