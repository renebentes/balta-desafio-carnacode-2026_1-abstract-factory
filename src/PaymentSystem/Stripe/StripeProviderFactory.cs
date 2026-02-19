using PaymentSystem.Payments;

namespace PaymentSystem.Stripe;

public sealed class StripeProviderFactory
    : IPaymentProviderFactory
{
    public IPaymentValidator CreateCardValidator()
        => new StripeValidator();

    public IPaymentLogger CreateLogger()
        => new StripeLogger();

    public IPaymentProcessor CreateProcessor()
        => new StripeProcessor();
}
