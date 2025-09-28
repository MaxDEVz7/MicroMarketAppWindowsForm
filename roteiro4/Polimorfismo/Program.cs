using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro4
{
    public class ProgramPolimorfismo
    {
        public static void Main(string[] args)
        {
            CartaoDeCredito cartao = new CartaoDeCredito();
            Array array = Array.CreateInstance(typeof(Pagamentos), 3);

            array.SetValue(new CartaoDeCredito(), 0);
            array.SetValue(new Pix(), 1);
            array.SetValue(new BoletoBancario(), 2);

            for (int i = 0; i < array.Length; i++)
            {
                Pagamentos pagamento = (Pagamentos)array.GetValue(i);
                pagamento.processarPagamento();
            }
        }
    }
}
