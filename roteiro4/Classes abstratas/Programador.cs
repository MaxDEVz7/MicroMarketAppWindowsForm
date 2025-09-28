using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro4
{
    public class Programador : Funcionario
    {
        double salario;
        public override double CalcularSalario()
        {
            this.salario = 2.0; 
            return this.salario;
        }
    }
}
