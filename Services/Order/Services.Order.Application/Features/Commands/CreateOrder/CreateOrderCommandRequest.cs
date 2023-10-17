using MediatR;
using Services.Order.Application.Dtos;
using Shared.Dtos;

namespace Services.Order.Application.Features.Commands.CreateOrder
{
    public class CreateOrderCommandRequest : IRequest<Response<CreatedOrderDto>>
    {
        public string BuyerId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
        public AddressDto Address { get; set; }
    }
}
