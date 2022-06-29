using bytebank;
using bytebank.Titular;

/// Nas últimas atualizações do .NET, mais precisamente na versão 9 do C#, 
/// foram introduzidos alguns recursos novos com o objetivo de aumentar a produtividade e reduzir o esforço de quem utiliza a linguagem.
/// 
/// E uma dessas novidades são as instruções de nível superior (top level statements). 
/// 
/// Com ela, posso inserir direto o código, sem a necessidade de inseri-lo dentro de um namespace, class Program e função Main. Pois o 
/// compilador já consegue identificar.
/// 
/// Entretanto o recurso apresenta uma restrição: só podemos ter um arquivo de código no projeto que utiliza instrução de nível superior.
/// 
/// https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/program-structure/top-level-statements
/// 

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ContaCorrente ContaCorrente1 = new ContaCorrente(0440, "10123-4")
            {
                Titular = new Cliente()
                {
                    Nome = "Matheus Garcia de Farias",
                    Cpf = "444.444.444-23",
                    Profissao = "TI",
                },
                NomeAgencia = "Agencia Central",
                Ativo = true,
            };

            ContaCorrente ContaCorrente2 = new ContaCorrente(2123, "23132-2")
            {
                Titular = new Cliente()
                {
                    Nome = "Bruno Garcia de Farias",
                    Cpf = "444.444.444-24",
                    Profissao = "TI",
                },
                NomeAgencia = "Agencia Leste",
                Ativo = false,
            };

            ContaCorrente ContaCorrente3 = new ContaCorrente(2125, "23132-4")
            {
                Titular = new Cliente()
                {
                    Nome = "Elisangela Garcia de Farias",
                    Cpf = "444.444.444-25",
                    Profissao = "Comerciante",
                },
                NomeAgencia = "Agencia Norte",
                Ativo = true,
            };

            ContaCorrente1.Depositar(3219.94);
            ContaCorrente2.Depositar(599.00);
            ContaCorrente3.Depositar(4339.00);

            ///Alterando a referência da ContaCorrente1 para ContaCorrente 2
            ContaCorrente2 = ContaCorrente1;

            ContaCorrente1.Conta = "3333";


            Console.WriteLine("Titular: " + ContaCorrente1.Titular.Nome);
            Console.WriteLine("Conta: " + ContaCorrente1.Conta);
            Console.WriteLine("Número Agencia: " + ContaCorrente1.NumeroAgencia);
            Console.WriteLine("Nome Agencia: " + ContaCorrente1.NomeAgencia);
            Console.WriteLine("Saldo: " + ContaCorrente1.Saldo);

            ContaCorrente1.Sacar(100);

            Console.WriteLine("Saldo Conta 1: " + ContaCorrente1.Saldo);

            ContaCorrente1.Depositar(200);

            Console.WriteLine("Saldo Conta 1: " + ContaCorrente1.Saldo);

            Console.WriteLine("Saldo Conta 3: " + ContaCorrente3.Saldo);

            ContaCorrente1.Transferir(200, ContaCorrente3);

            Console.WriteLine("Transferindo 200 de 1 para 3");

            Console.WriteLine("Saldo Conta 1: " + ContaCorrente1.Saldo);

            Console.WriteLine("Saldo Conta 3: " + ContaCorrente3.Saldo);
            Console.WriteLine("Saldo Conta 2: " + ContaCorrente2.Saldo);






            Console.ReadKey();

        }
    }
}

