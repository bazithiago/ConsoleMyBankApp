using System;
namespace ConsoleMyBankApp
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;

        public Cliente(string nome, string cpf, string profissao)
        {
            this.setNome(nome);
            this.setCPF(cpf);
            this.setProfissao(profissao);
        }

        public virtual string getNome() 
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCPF()
        {
            return this.cpf;
        }
        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }
        public string getProfissao()
        {
            return this.profissao;
        }
        public void setProfissao(string profissao)
        {
            this.profissao = profissao;
        }
    }
}
