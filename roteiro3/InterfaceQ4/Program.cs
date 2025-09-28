using System;

namespace InterfaceQ4;

public class program
{
    public static void Main(string[] args)
    {
        Pato pato = new Pato();
        pato.Voar();
        pato.Nadar();
        Aguia aguia = new Aguia();
        aguia.Voar();
        Peixe peixe = new Peixe();
        peixe.Nadar();
    }
}