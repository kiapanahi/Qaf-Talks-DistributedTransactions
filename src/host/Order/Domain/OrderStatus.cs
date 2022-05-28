namespace Marco.Host.Order.Domain;

public enum OrderStatus
{
    Draft,
    AwaitingConfirm,
    Confirmed,
    AwaitPayment,
    Paid,
    Canceled
}