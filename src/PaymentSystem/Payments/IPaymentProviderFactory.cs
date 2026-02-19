namespace PaymentSystem.Payments;

public interface IPaymentProviderFactory
{
    ICardValidator CreateCardValidator();
    IPaymentProcessor CreateProcessor();
    IPaymentLogger CreateLogger();
}
