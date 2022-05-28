namespace Marco.Host.Order.Domain
{
    public sealed record OrderId(Guid Id);

    public enum OrderStatus
    {
        Draft,
        AwaitingConfirm,
        Confirmed,

        AwaitPayment,

        Paid,

        Canceled
    }
    public sealed class Order
    {
        public Order(OrderId id)
        {
        }
        
        public OrderId Id { get; }

        public OrderStatus Status { get; }
    }
}
