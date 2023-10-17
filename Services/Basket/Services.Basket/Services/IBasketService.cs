using Services.Basket.Dtos;
using Shared.Dtos;

namespace Services.Basket.Services
{
    public interface IBasketService
    {      
        Task<Response<BasketDto>> GetBasketAsync(string userId);
        Task<Response<bool>> SaveOrUpdateAsync(BasketDto basketDto);
        Task<Response<bool>> DeleteAsync(string userId);
    }
}
