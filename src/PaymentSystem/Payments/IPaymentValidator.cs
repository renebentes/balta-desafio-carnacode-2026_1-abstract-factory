namespace PaymentSystem.Payments;

public interface ICardValidator
{
    bool ValidateCard(string cardNumber);
}
