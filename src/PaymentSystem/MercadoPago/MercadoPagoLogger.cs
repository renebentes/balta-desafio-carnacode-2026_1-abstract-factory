using PaymentSystem.Payments;

namespace PaymentSystem.MercadoPago;

public sealed class MercadoPagoLogger
    : IPaymentLogger
{
    public void Log(string message)
        => Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {message}");
}
