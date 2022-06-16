using bytebank;

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

            ContaCorrente contaCorrente1 = new ContaCorrente();

            contaCorrente1.titular = "Matheus Garcia de Farias";
            contaCorrente1.conta = "10123-4";
            contaCorrente1.numeroAgencia = 0440;
            contaCorrente1.nomeAgencia = "Agencia Central";
            contaCorrente1.saldo = 19.94;



            Console.WriteLine("Titular: " + contaCorrente1.titular);
            Console.WriteLine("Conta: " + contaCorrente1.conta);
            Console.WriteLine("Número Agencia: " + contaCorrente1.numeroAgencia);
            Console.WriteLine("Nome Agencia: " + contaCorrente1.nomeAgencia);
            Console.WriteLine("Saldo: " + contaCorrente1.saldo);

            Console.ReadKey();

        }
    }
}

