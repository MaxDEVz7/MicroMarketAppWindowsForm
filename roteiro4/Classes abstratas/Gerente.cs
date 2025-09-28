using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro4
{
    public class Gerente : Funcionario
    {
        private double salario;
        public override double CalcularSalario()
        {
            double comissao = 2000.00;
            this.salario = 5000.00 + comissao;
            return this.salario;
        }
    }
}
