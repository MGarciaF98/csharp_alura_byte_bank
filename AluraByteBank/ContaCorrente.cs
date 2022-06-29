using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        public double saldo;
        public bool ativo;

        public bool Sacar(double valor)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public bool Depositar(double valor)
        {
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo += valor;
                return true;
            }
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Sacar(valor))
            {
                contaDestino.Depositar(valor);
                return true;
            }
            else
                return false;
        }
    }
}
