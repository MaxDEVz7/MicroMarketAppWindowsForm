using System;

public class CartaoDeCredito : Pagamentos
{
    public CartaoDeCredito()
    {}
    public override void processarPagamento()
    {
        Console.WriteLine("Processando pagamento com cartão de crédito");
    }
}
