using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao_Q2
{
    public class Pedido
    {
        private Item item;

        public Pedido()
        {
            item = new Item("ITEM X DO PEDIDO");
        }

        public void exibirItem()
        {
            Console.WriteLine(item.getNomeItem());
        }
    }
}
