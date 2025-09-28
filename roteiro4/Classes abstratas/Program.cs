using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Gerente gerente = new Gerente();
            Console.WriteLine("salario gerente: " + gerente.CalcularSalario());
            Programador programador = new Programador();
            Console.WriteLine("salario programador: " + programador.CalcularSalario());
        }
    }
}
