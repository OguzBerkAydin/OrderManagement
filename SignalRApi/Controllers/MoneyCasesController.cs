using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MoneyCasesController : ControllerBase
	{
		private readonly IMoneyCaseService _moneyCaseService;

		public MoneyCasesController(IMoneyCaseService moneyCaseService)
		{
			_moneyCaseService = moneyCaseService;
		}

		[HttpGet("TotalAmountOfMoneyCase")]
		public IActionResult TotalAmountOfMoneyCase()
		{
			return Ok(_moneyCaseService.TTotalAmountOfMoneyCase());
		}
	}
}
