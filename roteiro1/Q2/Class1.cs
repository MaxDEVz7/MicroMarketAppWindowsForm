using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class Fantasminhas
    {
        public string nick;
        public string habilidade;
        public string cor;

        public void gerarFantasma()
        {
            Console.WriteLine($"{nick}, {habilidade}, {cor}");
        }

        public void mover(string local)
        {
            Console.WriteLine($"O Fantasminha: {nick} moveu para o local: {local}");
        }
    }


}
