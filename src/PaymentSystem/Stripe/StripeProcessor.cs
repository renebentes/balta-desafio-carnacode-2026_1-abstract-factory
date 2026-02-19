using PaymentSystem.Payments;

namespace PaymentSystem.Stripe;

public sealed class StripeProcessor
    : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"Stripe: Processando ${amount}...");
        return $"STRIPE-{Guid.NewGuid().ToString()[..8]}";
    }
}
