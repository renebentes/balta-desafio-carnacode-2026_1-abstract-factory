using PaymentSystem.Payments;

namespace PaymentSystem.PagSeguro;

public sealed class PagSeguroProcessor
    : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
        return $"PAGSEG-{Guid.NewGuid().ToString()[..8]}";
    }
}
