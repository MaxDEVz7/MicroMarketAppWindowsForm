using System;

namespace InterfacesQ3;
public class Program
{
    public static void Main(string[] args)
    {
        IVeiculo carro = new Carro();
        IVeiculo bicicleta = new Bicicleta();
        carro.Mover();
        bicicleta.Mover();
    }
}