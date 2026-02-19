using PaymentSystem.Payments;

namespace PaymentSystem.PagSeguro;

public sealed class PagSeguroCardValidator
    : ICardValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("PagSeguro: Validando cartão...");
        return cardNumber.Length == 16;
    }
}
