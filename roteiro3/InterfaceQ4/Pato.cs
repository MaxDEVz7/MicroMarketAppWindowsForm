using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceQ4
{
    public class Pato : IVoar, INadar
    {
        public void Voar()
        {
            Console.WriteLine("O pato está voando.");
        }
        public void Nadar()
        {
            Console.WriteLine("O pato está nadando.");
        }
    }  
}
