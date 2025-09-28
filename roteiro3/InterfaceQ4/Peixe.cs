using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceQ4
{
    public class Peixe : INadar
    {
        public void Nadar()
        {
            Console.WriteLine("O peixe está nadando.");
        }
    }
}
