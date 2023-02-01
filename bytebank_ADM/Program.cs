using bytebank_ADM.Funcionarios;
using bytebank_ADM.Sistema_Interno;
using bytebank_ADM.Utilitario;

 #region
//Funcionario pedro = new Funcionario("123456776",2000);
//pedro.Nome = "Pedrinho Bala";


//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());
//gerenciador.Registrar(pedro);

//Diretor Raquel = new Diretor("123456776"  )
//{
//    Nome = "Raquel Boladona",
    
//};
//Console.WriteLine(value: Raquel.Nome);
//Console.WriteLine(Raquel.Salario);
//gerenciador.Registrar(Raquel);


//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de Funcionários na empresa: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//Raquel.AumentarSalario();

//Console.WriteLine("Pedro " + pedro.Salario);
//Console.WriteLine("Raquel " + Raquel.Salario);
#endregion

//CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer geraldinho = new Designer("123132321");
    geraldinho.Nome = "Geraldinho Souza";

    Diretor paula = new Diretor("121321233");
    paula.Nome = "Paula Tejano";

    Auxiliar gorge = new Auxiliar("4545646");
    gorge.Nome = "Gorginho da 12";

    GerenteContas fernando = new GerenteContas("489489489");
    fernando.Nome = "Fernandinho Julio";

    gerenciador.Registrar(geraldinho);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(gorge);
    gerenciador.Registrar(fernando);

    Console.WriteLine("Total de Bonificação = "+ gerenciador.TotalDeBonificacao);

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor Manoel = new Diretor("8789545");
    Manoel.Nome = "Manoel Gomes";
    Manoel.Senha = "1234";

    GerenteContas Ricardinho = new GerenteContas("465465");
    Ricardinho.Nome = "Ricardo Giroscopio";
    Ricardinho.Senha = "566";

    //Auxiliar Erick = new Auxiliar("465464");
    //Erick.Nome = "Erick Mimo";
    //Erick.Senha = "852";

    //Designer Relogio = new Designer("123123");
    //Relogio.Nome = "Relogio da Silva";
    //Relogio.Senha = "333";


    sistema.Logar(Ricardinho, "566");
    sistema.Logar(Manoel, "1231");
    //sistema.Logar(Erick, "4564");
    //sistema.Logar(Relogio, "4564");
}


    