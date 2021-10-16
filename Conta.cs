using System;
namespace ConsoleMyBankApp
{
    public abstract class Conta
    {
        public Cliente titular;
        public int agencia;
        public int conta;
        protected double saldo = 0.00;
        public double Depositar(double valor)
        {
            if(valor <= 0 ){
                return 0;
            } else {
                return this.saldo += valor;;
            }
        }

        public double Sacar(double valor)
        {
            if(valor > this.saldo){
                return 0;
            } else {
                return this.saldo -= valor;
            }
        }

        public double Pix(double valor, ContaCorrente contaTerceiro)
        {
            if(valor > this.saldo){
                return 0;
            } else {
                this.Sacar(valor);
                contaTerceiro.Depositar(valor);
            }
            
            return this.saldo;
        }

        public void AplicacaoPoupanca(double valor, Conta ContaPoupanca)
        {
            this.Sacar(valor);
            ContaPoupanca.Depositar(valor);
        }


        public Cliente getTitular()
        {
            return this.titular;
        }

        public void setTitular(Cliente titular)
        {
            this.titular = titular;
        }
        public int getAgencia() 
        {
            return this.agencia;
        }
        public void setAgencia(int agencia)
        {
            this.agencia = agencia;
        }
        public int getConta()
        {
            return this.conta;
        }
        public void setConta(int conta)
        {
            this.conta = conta;
        }

        public double getSaldo()
        {
            return this.saldo;
        }
    }
}
