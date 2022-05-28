namespace Marco.Host.Order.Domain
{
    public sealed record OrderId(Guid Id);

    public sealed class Order
    {
        public Order(OrderId id)
        {
            LineItems = new List<OrderLineItem>()
            {
               new FlightLineItem("69563dc5-b0ed-4207-900e-1492d680e05f")
            };
        }

        public OrderId Id { get; }

        public OrderStatus Status { get; }

        public List<OrderLineItem> LineItems { get; }
    }
}
