using bytebank_ADM.Sistema_Interno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteContas : FuncionarioAutentivavel
    {
        public GerenteContas(string cpf) : base(cpf, 4000)
        {
        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

    }
}
