class Program
{
    public static void Main()
    {
        Elevador e = new Elevador(10); // 10 andares
        e.subir();
        e.subir();
        Console.WriteLine(e.getAndarAtual()); // Deve exibir 2
        e.descer();
        Console.WriteLine(e.getAndarAtual()); // Deve exibir 1
        e.descer();
        Console.WriteLine(e.getAndarAtual()); // Deve exibir 0
        e.descer(); // Deve continuar em 0
        Console.WriteLine(e.getAndarAtual()); // Deve exibir 0
    }
}
