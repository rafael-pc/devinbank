
namespace Devinbank.Contas.Entidades
{
    public class Conta
    {
        public string name;
        public string cpf;
        public string endereco;
        public double rendaMensal;
        public int numConta;
        public string agencia;
        public double saldo = 0;
        public double transacao;
        public double saque;

        public Conta(int numConta, string name, string cpf, string endereco, string agencia, double rendaMensal, double primeiroDeposito)
        {
            this.numConta = numConta;
            this.name = name;
            this.cpf = cpf;
            this.endereco = endereco;
            this.agencia = agencia;
            this.rendaMensal = rendaMensal;            
            saldo += primeiroDeposito;
        }
   
        public Conta(string nome, double transacao)
        {
            name = nome;
            this.transacao = transacao;
        }

        public void Depositar(double deposito)
        {
            saldo += deposito;
        }

        public bool Sacar(double saque)
        {
            bool chk = true;
            if (saque <= saldo)
            {
                saldo -= saque;
            }
            else if (saque > saldo)
            {
                chk = false;
            }
            return chk;
        }

        public double JurosCompostos(int mes)
        {
            double juros = 0.01 * 0.52;
            double valor = saldo;
            double saldoJuros;
            for (int i = 1; i <= mes; i++)
            {
                saldoJuros = valor * juros;
                valor += saldoJuros;
            }
            return valor;
        }
    }
}