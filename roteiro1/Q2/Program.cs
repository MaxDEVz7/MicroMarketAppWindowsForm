using System;

namespace Q2
{
public class Program
{
    public static void Main()
    {
        Fantasminhas fantasminha = new Fantasminhas();
        fantasminha.nick = "Vinicius";
        fantasminha.habilidade = "Morrer";
        fantasminha.cor = "Amarelo";
        fantasminha.gerarFantasma();
        fantasminha.mover("COZINHA");
    }
}
}