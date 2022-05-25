using Marco.Host.Order.Commands;
using MediatR;

namespace Marco.Host.Order.Handlers
{
    public class OrderRequestHandler
        : INotificationHandler<CreateOrderCommand>
    {
        public Task Handle(CreateOrderCommand notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
