using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesQ3
{
    public class Bicicleta : IVeiculo
    {
        public void Mover()
        {
            Console.WriteLine("A bicicleta está se movendo.");
        }
    }
}
