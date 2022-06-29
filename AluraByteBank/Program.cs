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

            ContaCorrente contaCorrente1 = new ContaCorrente()
            {
                titular = new Cliente()
                {
                    nome = "Matheus Garcia de Farias",
                    cpf = "444.444.444-23",
                    profissao = "TI",
                },
                conta = "10123-4",
                numeroAgencia = 0440,
                nomeAgencia = "Agencia Central",
                saldo = 3219.94,
                ativo = true,
            };

            ContaCorrente contaCorrente2 = new ContaCorrente()
            {
                titular = new Cliente()
                {
                    nome = "Bruno Garcia de Farias",
                    cpf = "444.444.444-24",
                    profissao = "TI",
                },
                conta = "23132-2",
                numeroAgencia = 2123,
                nomeAgencia = "Agencia Leste",
                saldo = 3999.00,
                ativo = false,
            };

            ContaCorrente contaCorrente3 = new ContaCorrente()
            {
                titular = new Cliente()
                {
                    nome = "Elisangela Garcia de Farias",
                    cpf = "444.444.444-25",
                    profissao = "Comerciante",
                },
                conta = "23132-4",
                numeroAgencia = 2125,
                nomeAgencia = "Agencia Norte",
                saldo = 3339.00,
                ativo = true,
            };

            ///Alterando a referência da contaCorrente1 para contaCorrente 2
            contaCorrente2 = contaCorrente1;

            contaCorrente1.conta = "3333";


            Console.WriteLine("Titular: " + contaCorrente1.titular.nome);
            Console.WriteLine("Conta: " + contaCorrente1.conta);
            Console.WriteLine("Número Agencia: " + contaCorrente1.numeroAgencia);
            Console.WriteLine("Nome Agencia: " + contaCorrente1.nomeAgencia);
            Console.WriteLine("Saldo: " + contaCorrente1.saldo);

            contaCorrente1.Sacar(100);

            Console.WriteLine("Saldo Conta 1: " + contaCorrente1.saldo);

            contaCorrente1.Depositar(200);

            Console.WriteLine("Saldo Conta 1: " + contaCorrente1.saldo);

            Console.WriteLine("Saldo Conta 3: " + contaCorrente3.saldo);

            contaCorrente1.Transferir(200, contaCorrente3);

            Console.WriteLine("Transferindo 200 de 1 para 3");

            Console.WriteLine("Saldo Conta 1: " + contaCorrente1.saldo);

            Console.WriteLine("Saldo Conta 3: " + contaCorrente3.saldo);






            Console.ReadKey();

        }
    }
}

