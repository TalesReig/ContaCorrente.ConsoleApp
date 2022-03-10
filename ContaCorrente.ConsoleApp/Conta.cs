using System;

namespace ContaCorrente.ConsoleApp
{
    internal class Conta
    {
        public int numeroDaConta;
        public double saldo;
        public double limite;
        public bool contaespecial;
        public Movimentacao[] movimentacoes = new Movimentacao[10];
        public Cliente titular = new Cliente();

        public void VisualizarSaldo()
        {
            //não esquecer de preparar uma tabela de output
            if (saldo > 0)
            {
                Console.WriteLine(titular.nome +" seu saldo atual é de: " + saldo+" Dolares");
            }
            else
            {
                Console.WriteLine("Seu saldo atual é de: " + saldo);
            }
        }
        public void VisualizarExtrato()
        {
            //não esquecer de preparar uma tabela de output
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("|{0,-25}|{1,-25}|", "Tipo Da Movimentação", "Valor Da Movimentação");
            Console.WriteLine("-----------------------------------------------------");

            for (int i = 0; i < this.movimentacoes.Length; i++)
            { 
                if(movimentacoes[i] != null)
                {
                    Console.WriteLine("|{0,-25}|{1,-25}|", movimentacoes[i].tipo, movimentacoes[i].valor);
                }
            }
            Console.WriteLine("-----------------------------------------------------");

        }

        public void Sacar(double valor)
        {
            if (valor < limite)
            {
                Movimentacao novaMovimentacao = new Movimentacao();
                novaMovimentacao.valor = - valor;
                novaMovimentacao.tipo = TipoMovimentacao.Debito;
                saldo = saldo + valor;
                for(int i = 0; i < movimentacoes.Length; i++)
                {
                    if(movimentacoes[i] == null)
                    {
                        movimentacoes[i] = novaMovimentacao;
                        break;
                    }
                }
                 
            }
            else
            {
                Console.WriteLine("Você não possui limite para isso !");
            }
        }
        public void Depositar(double valor)
        {
            Movimentacao novaMovimentacao = new Movimentacao();
            novaMovimentacao.valor = valor;
            novaMovimentacao.tipo = TipoMovimentacao.Debito;
            saldo = saldo + valor;
            for (int i = 0; i < movimentacoes.Length; i++)
            {
                if (movimentacoes[i] == null)
                {
                    movimentacoes[i] = novaMovimentacao;
                    break;
                }
            }
        }

        public void Transferir(double valor, Conta conta)
        {
            Sacar(valor);
            conta.Depositar(valor);
        }
        //Esse aqui vai da trampo
        //void TransferenciaEntreContas()
        //{
        // tem que descontar de um e somar na outra ( como saber associar com a conta de destino )
        // - procurar para ver se o número da conta existe ( for )
        // - se existir desconta e envia para a outra
        // - caso não ache retorna a mensagem de que a conta de destino não existe.
        //}
    }
}