using MediatR;
using Microsoft.AspNetCore.Mvc;
using Services.Order.Application.Features.Commands.CreateOrder;
using Services.Order.Application.Features.Queries.GetOrdersByUserId;
using Shared.ControllerBases;
using Shared.Services;

namespace Services.Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : CustomBaseController
    {
        private readonly IMediator _mediator;
        private readonly ISharedIdentityService _sharedIdentityService;

        public OrdersController(IMediator mediator, ISharedIdentityService sharedIdentityService)
        {
            _mediator = mediator;
            _sharedIdentityService = sharedIdentityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrdersByUserId()
        {
            var response = await _mediator.Send(new GetOrdersByUserIdQueryRequest { UserId = _sharedIdentityService.GetUserId });

            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderCommandRequest createOrderCommandRequest)
        {
            var response = await _mediator.Send(createOrderCommandRequest);

            return CreateActionResultInstance(response);
        }
    }
}
