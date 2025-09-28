using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao_Q2
{
    public class Item
    {
        private string nomeItem { get; set; }

        public Item(string nomeItem)
        {
            this.nomeItem = nomeItem;
        }

        public string getNomeItem()
        {
            return this.nomeItem;
        }
    }

}
