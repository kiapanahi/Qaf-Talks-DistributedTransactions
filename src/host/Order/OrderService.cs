using Marco.Host.Order.Domain;

namespace Marco.Host.Order
{
    public class OrderService
    {

        public async Task<OrderReservationResult> ReserveOrderAsync(OrderReserveInput input, CancellationToken cancellation = default)
        {

            // 1. assume there are some orders with draft/initialzed status already in place
            // 2. accept one of those here, and raise a Reserve event with that order's line items
            // 3. goto: order event handlers :D
            return OrderReservationResult.Submitted;
        }
    }


    public sealed record OrderReserveInput(OrderId Id);
    public sealed record OrderReservationResult
    {
        public static readonly OrderReservationResult Submitted = new();
    };
}
