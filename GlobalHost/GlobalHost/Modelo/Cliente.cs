using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Cliente
    {
        private int id;
        private string nome;
        private string endereco;
        private DateTime dtnascimento;
        private string cpf_cnpj;
        private string cep;
        private string email;
        private string telefone;
        public Cliente()
        {
        }
        //Sem id
        //Sem endereço e Telefone
        public Cliente(string nome, DateTime dtnascimento, string cpf_cnpj, string cep, string email)
        {
            this.nome = nome;
            this.endereco = null;
            this.dtnascimento = dtnascimento;
            this.cpf_cnpj = cpf_cnpj;
            this.cep = cep;
            this.email = email;
            this.telefone = null;
        }
        //Com endereço e telefone
        public Cliente(string nome, string endereco, DateTime dtnascimento, string cpf_cnpj, string cep, string email, string telefone)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.dtnascimento = dtnascimento;
            this.cpf_cnpj = cpf_cnpj;
            this.cep = cep;
            this.email = email;
            this.telefone = telefone;
        }
        //Com id
        //Sem endereço e Telefone
        public Cliente(int id,string nome, DateTime dtnascimento, string cpf_cnpj, string cep, string email)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = null;
            this.dtnascimento = dtnascimento;
            this.cpf_cnpj = cpf_cnpj;
            this.cep = cep;
            this.email = email;
            this.telefone = null;
        }
        //Com endereço e telefone
        public Cliente(int id,string nome, string endereco, DateTime dtnascimento, string cpf_cnpj, string cep, string email, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.dtnascimento = dtnascimento;
            this.cpf_cnpj = cpf_cnpj;
            this.cep = cep;
            this.email = email;
            this.telefone = telefone;
        }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public DateTime Dtnascimento { get => dtnascimento; set => dtnascimento = value; }
        public string Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
