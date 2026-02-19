using PaymentSystem.Payments;

namespace PaymentSystem.MercadoPago;

public sealed class MercadoPagoProcessor
    : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"MercadoPago: Processando R$ {amount}...");
        return $"MP-{Guid.NewGuid().ToString()[..8]}";
    }
}
