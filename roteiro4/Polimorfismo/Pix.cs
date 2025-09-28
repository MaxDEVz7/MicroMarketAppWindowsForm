using System;

public class Pix : Pagamentos
{
	public Pix()
	{
	}

    public override void processarPagamento()
    {
        Console.WriteLine("Processando pagamento com PIX");
    }
}
