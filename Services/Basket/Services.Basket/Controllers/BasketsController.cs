using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Basket.Dtos;
using Services.Basket.Services;
using Shared.ControllerBases;
using Shared.Services;

namespace Services.Basket.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : CustomBaseController
    {
        private readonly IBasketService _basketService;
        private readonly ISharedIdentityService _sharedIdentityService;

        public BasketsController(IBasketService basketService, ISharedIdentityService sharedIdentityService)
        {
            _basketService = basketService;
            _sharedIdentityService = sharedIdentityService;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetBasket()
        {
            var basketDto = new BasketDto { UserId = "a", DiscountCode = "x", DiscountRate = 99 };
            await _basketService.SaveOrUpdateAsync(basketDto);
            return CreateActionResultInstance(await _basketService.GetBasketAsync(_sharedIdentityService.GetUserId));
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrUpdateBasket(BasketDto basketDto)
        {
            basketDto.UserId = _sharedIdentityService.GetUserId;
            var response = await _basketService.SaveOrUpdateAsync(basketDto);

            return CreateActionResultInstance(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBasket()
        {
            return CreateActionResultInstance(await _basketService.DeleteAsync(_sharedIdentityService.GetUserId));
        }
    }
}
