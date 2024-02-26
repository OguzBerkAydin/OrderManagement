using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.SignalR;

namespace SignalRApi.Hubs
{
	public class SignalRHub : Hub
	{
		private readonly ICategoryService _categoryService;
		private readonly IProductService _productService;

		public SignalRHub(ICategoryService categoryService, IProductService productService)
		{
			_categoryService = categoryService;
			_productService = productService;
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
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value);
        }
    }
}
