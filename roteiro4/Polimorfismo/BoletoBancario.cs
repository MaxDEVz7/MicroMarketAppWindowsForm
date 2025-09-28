using System;

public class BoletoBancario : Pagamentos
{
	public BoletoBancario()
	{
	}

    public override void processarPagamento()
    {
        Console.WriteLine("Processando pagamento com Boleto");
    }
}
