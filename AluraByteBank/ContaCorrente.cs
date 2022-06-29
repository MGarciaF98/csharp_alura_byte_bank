using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public string Conta { get; set; }
        public string NomeAgencia { get; set; }

        public int _numeroAgencia;
        public int NumeroAgencia { 
            get
            {
                return _numeroAgencia;
            }
            set
            {
                if(value > 0)
                {
                    _numeroAgencia = value;
                }
            }
        }
        public bool Ativo { get; set; }

        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
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
                _saldo += valor;
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

        public ContaCorrente(int numeroAgencia, string conta)
        {
            NumeroAgencia = numeroAgencia;
            Conta = conta;
        }
    }

    
}
