using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
   class Pessoa
    {
        public string nome;
        public int idade;
        public string cargo;

        public void apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {nome} e tenho {idade}.");
        }

        public void apresentarSalario(double salario)
        {
            Console.WriteLine($"Ola, meu nome é {nome} e tenho {idade} e tenho salario de: {salario}");
        }
    }

}
