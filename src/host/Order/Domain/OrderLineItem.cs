namespace Marco.Host.Order.Domain;

public abstract class OrderLineItem
{
    public OrderLineItem(string Id)
    {
        this.Id = Id;
    }
    public string Id { set; get; }
}

public class FlightLineItem : OrderLineItem
{
    public FlightLineItem(string Id) : base(Id)
    {
    }
}