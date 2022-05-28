using Marco.Host.Order.Commands;
using Marco.Host.Order.Domain;
using MediatR;

namespace Marco.Host.Order
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMediator _mediator;

        public OrderService(IOrderRepository orderRepository, IMediator mediator)
        {
            _orderRepository = orderRepository;
            _mediator = mediator;
        }

        // 1. assume there are some orders with draft/initialzed status already in place
        // 2. accept one of those here, and raise a Reserve event with that order's line items
        // 3. goto: order event handlers :D
        public async Task<OrderReservationResult> ReserveOrderAsync(OrderReserveInput input, CancellationToken cancellation = default)
        {
            var order = await _orderRepository.FindOrderById(input.Id);

            if (order.Status != OrderStatus.Draft)
            {
                throw new InvalidOperationException($"could not reserve order because status was: {order.Status}");
            }

            await _mediator.Publish(new ReserveOrderCommand(Guid.NewGuid().ToString("N"), order));
            return OrderReservationResult.Submitted;
        }
    }


    public sealed record OrderReserveInput(OrderId Id);
    public sealed record OrderReservationResult
    {
        public static readonly OrderReservationResult Submitted = new();
    };
}
