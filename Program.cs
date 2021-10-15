using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Thiago", "000.000.000-00", "desenvolvedor");
            // cliente.setNome("Thiago");
            // cliente.setCPF("000.000.000-00");
            // cliente.setProfissao("desenvolvedor");

            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);
            // conta.titular = cliente;
            // conta.agencia = 01;
            // conta.conta = 0001;
            
            Console.WriteLine($"Titular: {conta.getTitular().getNome()}");
            Console.WriteLine($"Profissao: {conta.getTitular().getProfissao()}");
            Console.WriteLine($"Agência: {conta.getAgencia()}");
            Console.WriteLine($"Conta corrente: {conta.getConta()}");
            Console.WriteLine($"Saldo: {conta.getSaldo()},00 reais");

            double valorDepositado = 1;
            conta.Depositar(valorDepositado);

            double valorSaque = 1;
            conta.Sacar(valorSaque);

            Console.WriteLine($"Seu saldo é de {conta.getSaldo()},00 reais");

            Cliente clienteSilvia = new Cliente("Silvia", "000.000.000-00", "administradora");
            ContaCorrente contaSilvia = new ContaCorrente(clienteSilvia, 01, 0002);

            conta.Pix(50, contaSilvia);
            Console.WriteLine($"Seu novo saldo é de {conta.getSaldo()},00 reais");
            Console.WriteLine($"Saldo da Silvia é de = {contaSilvia.getSaldo()},00 reais");


        }
    }
}
