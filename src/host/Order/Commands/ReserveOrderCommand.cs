using Marco.Host.Order.Domain;
using MediatR;

namespace Marco.Host.Order.Commands
{
    public sealed record ReserveOrderCommand(string Id, Domain.Order order) : INotification;
}
