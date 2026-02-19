namespace PaymentSystem.Payments;

public interface IPaymentProcessor
{
    string ProcessTransaction(decimal amount, string cardNumber);
}
