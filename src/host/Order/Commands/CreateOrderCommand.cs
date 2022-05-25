using MediatR;

namespace Marco.Host.Order.Commands
{
    public sealed record CreateOrderCommand : INotification;
}
