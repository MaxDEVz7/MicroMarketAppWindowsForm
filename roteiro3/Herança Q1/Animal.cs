using System;

public class Animal
{
    private string nome;

    public virtual void emitirSom()
    {
        Console.WriteLine("Som genérico do animal.");
    }
}
