namespace PaymentSystem.Payments;

public interface IPaymentProviderFactory
{
    IPaymentValidator CreateCardValidator();
    IPaymentProcessor CreateProcessor();
    IPaymentLogger CreateLogger();
}
