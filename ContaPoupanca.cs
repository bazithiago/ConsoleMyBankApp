using System;
namespace ConsoleMyBankApp
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(Cliente titular, int agencia, int conta)
        {
            this.setTitular(titular);
            this.setAgencia(agencia);
            this.setConta(conta);
        }
    }
}
