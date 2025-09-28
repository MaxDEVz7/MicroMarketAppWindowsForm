class Program
{
    public static void Main()
    {
        Carro c = new Carro("Ferrari");
        c.acelerar(50);
        Console.WriteLine(c.getVelocidadeAtual()); // Deve exibir 50
        c.frear(30);
        Console.WriteLine(c.getVelocidadeAtual()); // Deve exibir 20
        c.frear(50); // Não pode ficar negativo, deve exibir 0
        Console.WriteLine(c.getVelocidadeAtual()); // Deve exibir 0
    }
}
