using Q1;

class Program
{
    public static void Main()
    {
        Produto p = new Produto("Celular", 1500);
        p.exibirDetalhes();
        p.setPreco(-200); // Deve exibir uma mensagem de erro
    }
}
