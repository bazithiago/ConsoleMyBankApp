using System;
namespace ConsoleMyBankApp
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente titular, int agencia, int conta)
        {
            this.setTitular(titular);
            this.setAgencia(agencia);
            this.setConta(conta);
        }
    }
}
