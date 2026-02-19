using PaymentSystem.Payments;

namespace PaymentSystem.PagSeguro;

public sealed class PagSeguroLogger
    : IPaymentLogger
{
    public void Log(string message)
        => Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
}
