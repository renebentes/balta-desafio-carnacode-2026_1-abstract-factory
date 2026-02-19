using PaymentSystem.Payments;

namespace PaymentSystem.PagSeguro;

public sealed class PagSeguroProviderFactory
    : IPaymentProviderFactory
{
    public ICardValidator CreateCardValidator()
        => new PagSeguroCardValidator();

    public IPaymentLogger CreateLogger()
        => new PagSeguroLogger();

    public IPaymentProcessor CreateProcessor()
        => new PagSeguroProcessor();
}
