namespace PaymentSystem.Payments;

public sealed class PaymentService
    (IPaymentProviderFactory providerFactory)
{
    public void ProcessPayment(decimal amount, string cardNumber)
    {
        var logger = providerFactory.CreateLogger();
        var cardValidator = providerFactory.CreateCardValidator();
        if (!cardValidator.ValidateCard(cardNumber))
        {
            logger.Log("Cartão inválido!");
            return;
        }

        var processor = providerFactory.CreateProcessor();
        var paymentResult = processor.ProcessTransaction(amount, cardNumber);
        logger.Log($"Transação processada: {paymentResult}");
    }
}
