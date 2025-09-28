using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesQ3
{
    public class Carro : IVeiculo
    {
        public void Mover()
        {
            Console.WriteLine("O carro está se movendo.");
        }
    }
}
