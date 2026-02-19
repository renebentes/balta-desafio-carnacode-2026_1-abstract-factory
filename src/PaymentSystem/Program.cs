using PaymentSystem.MercadoPago;
using PaymentSystem.PagSeguro;
using PaymentSystem.Payments;

Console.WriteLine("=== Sistema de Pagamentos ===\n");

var pagSeguroService = new PaymentService(
    BuildFactory(PaymentProvider.PagSeguro));
pagSeguroService.ProcessPayment(150.00m, "1234567890123456");

Console.WriteLine();

var mercadoPagoService = new PaymentService(
    BuildFactory(PaymentProvider.MercadoPago));
mercadoPagoService.ProcessPayment(200.00m, "5234567890123456");

Console.WriteLine();

static IPaymentProviderFactory BuildFactory(PaymentProvider paymentProvider)
{
    return paymentProvider switch
    {
        PaymentProvider.PagSeguro => new PagSeguroProviderFactory(),
        PaymentProvider.MercadoPago => new MercadoPagoProviderFactory(),
        _ => throw new NotSupportedException($"O Provider {paymentProvider} não é suportado!")
    };
}
