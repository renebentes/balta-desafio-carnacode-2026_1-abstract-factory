namespace PaymentSystem.Payments;

public interface IPaymentValidator
{
    bool ValidateCard(string cardNumber);
}
