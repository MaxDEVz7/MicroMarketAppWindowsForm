using System;

namespace Q1
{
    public class program
    {
        public static void Main()
        {
            Pessoa p1 = new Pessoa();
            p1.idade = 30;
            p1.nome = "Joao";
            p1.cargo = "GP";
            p1.apresentar();
            p1.apresentarSalario(99000);

            Pessoa p2 = new Pessoa();
            p2.idade = 30;
            p2.nome = "Max";
            p2.cargo = "Gerente";
            p2.apresentar();
            p2.apresentarSalario(10000);

            Pessoa p3 = new Pessoa();
            p3.idade = 30;
            p3.nome = "Vinicius";
            p3.cargo = "Estagiario";
            p3.apresentar();
            p3.apresentarSalario(100);

            Pessoa p4 = new Pessoa();
            p4.idade = 30;
            p4.nome = "Herison";
            p4.cargo = "Dev";
            p4.apresentar();
            p4.apresentarSalario(5000);
        }
    }
}