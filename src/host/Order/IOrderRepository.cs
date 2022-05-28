namespace Marco.Host.Order;
using System.Threading.Tasks;
using Marco.Host.Order.Domain;

public interface IOrderRepository
{
    Task<Order> FindOrderById(OrderId orderId);
}


public class InMemoryOrderRepository : IOrderRepository
{
    private readonly static List<Order> orders = new()
    {
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e581"))) ,
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e582"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e583"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e584"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e585"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e586"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e587"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e588"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e589"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e580"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e511"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e522"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e533"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e544"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e555"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e566"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e577"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e088"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e599"))),
        new Order(new OrderId(Guid.Parse("b13652b5-a60a-4672-a9bd-cde04e97e500")))
    };

    public Task<Order> FindOrderById(OrderId orderId)
    {
        return Task.FromResult(orders.FirstOrDefault(x => x.Id == orderId));
    }
}