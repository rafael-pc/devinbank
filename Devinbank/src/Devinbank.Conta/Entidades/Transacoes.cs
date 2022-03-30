namespace Devinbank.Contas.Entidades
{
    public class Transacoes : Conta
    {  
        public DateTime dataTransacao;
        public double transacoes;

        public Transacoes(string nome, double transacoes, DateTime dataTransacao) : base(nome, transacoes)
        {
            name = nome;
            this.transacoes = transacoes;
            this.dataTransacao = dataTransacao;
        }
    }
}
