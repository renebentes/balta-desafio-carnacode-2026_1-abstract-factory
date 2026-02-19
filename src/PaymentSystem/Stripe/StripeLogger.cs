using PaymentSystem.Payments;

namespace PaymentSystem.Stripe;

public sealed class StripeLogger
    : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");
    }
}
