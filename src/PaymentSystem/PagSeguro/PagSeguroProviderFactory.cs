using PaymentSystem.Payments;

namespace PaymentSystem.PagSeguro;

public sealed class PagSeguroProviderFactory
    : IPaymentProviderFactory
{
    public IPaymentValidator CreateCardValidator()
        => new PagSeguroCardValidator();

    public IPaymentLogger CreateLogger()
        => new PagSeguroLogger();

    public IPaymentProcessor CreateProcessor()
        => new PagSeguroProcessor();
}
