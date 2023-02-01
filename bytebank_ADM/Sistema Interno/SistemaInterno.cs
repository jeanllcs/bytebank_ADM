using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Sistema_Interno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario,string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas Vindas ao nosso sistema.");
                return true;
            }
            else {
                Console.WriteLine("Senha incorreta!");
                return false; }
        }

    }
}
