using System;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------- ClassConta -------------------------
            // public int numeroDaConta;
            // public double saldo;
            // public double limite;
            // public bool contaespecial;
            // public Movimentacao[] movimentacoes = new Movimentacao[10];
            // ------------------ ClassMovimentacao ----------------------
            // public double valor;
            // public TipoMovimentacao tipo;
            // -----------------------------------------------------------
            Conta ContaDoTales = new Conta();
            ContaDoTales.numeroDaConta = 1;
            ContaDoTales.saldo = 1100000;
            ContaDoTales.limite = 100000;
            ContaDoTales.contaespecial = true;
            ContaDoTales.titular.nome = "Tales Reig Cordova";
            ContaDoTales.titular.cpf = "111.111.111-11";
            ContaDoTales.Sacar(1000);
            ContaDoTales.Sacar(1000);
            ContaDoTales.Depositar(300000);
            ContaDoTales.VisualizarSaldo();
            ContaDoTales.VisualizarExtrato();
            ContaDoTales.titular.nome = "Tales Reig Cordova";
            ContaDoTales.titular.cpf = "111.111.111-11";
            Console.ReadLine();
            Console.Clear();

            Conta ContaDoRech = new Conta();
            ContaDoRech.numeroDaConta = 2;
            ContaDoRech.saldo = 100000000;
            ContaDoRech.limite = 1000000;
            ContaDoRech.contaespecial = true;
            ContaDoRech.titular.nome = "Alexandre Rech";
            ContaDoRech.titular.cpf = "222.222.222-22";

            ContaDoRech.Sacar(1000);
            ContaDoRech.Sacar(1000);
            ContaDoRech.Depositar(300000);
            ContaDoRech.VisualizarSaldo();
            ContaDoRech.VisualizarExtrato();
            Console.ReadLine();
            Console.Clear();
            ContaDoRech.Transferir(10000, ContaDoTales);
            ContaDoTales.VisualizarSaldo();



        }
    }
}
