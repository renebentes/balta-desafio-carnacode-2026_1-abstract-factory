using PaymentSystem.Payments;

namespace PaymentSystem.MercadoPago;

public sealed class MercadoPagoProviderFactory
    : IPaymentProviderFactory
{
    public IPaymentValidator CreateCardValidator()
        => new MercadoPagoValidator();

    public IPaymentLogger CreateLogger()
        => new MercadoPagoLogger();

    public IPaymentProcessor CreateProcessor()
        => new MercadoPagoProcessor();
}
