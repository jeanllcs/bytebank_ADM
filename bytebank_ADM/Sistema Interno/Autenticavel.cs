using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Sistema_Interno
{
    public interface  Autenticavel
    {
        public string Senha { get; set; }
        public abstract bool Autenticar(string senha);

    }
}
