using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Funcionario
    {
        private int id;
        private string nome;
        private DateTime dtnascimento;
        private string cpf;
        private double salario;
        private string endereco;
        private DateTime dtadmissao;
        private DateTime dtdemissao;
        private string telefone;
        private string email;
        private Login login;

        public Funcionario()
        {
        }

        public Funcionario(int id, string nome, DateTime dtnascimento, string cpf, double salario, string endereco, DateTime dtadmissao, DateTime dtdemissao, string telefone, string email, Login login)
        {
            this.id = id;
            this.nome = nome;
            this.dtnascimento = dtnascimento;
            this.cpf = cpf;
            this.salario = salario;
            this.endereco = endereco;
            this.dtadmissao = dtadmissao;
            this.dtdemissao = dtdemissao;
            this.telefone = telefone;
            this.email = email;
            this.login = login;
        }

        public Funcionario(string nome, DateTime dtnascimento, string cpf, double salario, string endereco, DateTime dtadmissao, DateTime dtdemissao, string telefone, string email, Login login)
        {
            this.nome = nome;
            this.dtnascimento = dtnascimento;
            this.cpf = cpf;
            this.salario = salario;
            this.endereco = endereco;
            this.dtadmissao = dtadmissao;
            this.dtdemissao = dtdemissao;
            this.telefone = telefone;
            this.email = email;
            this.login = login;
        }
        public Funcionario(string nome, DateTime dtnascimento, string cpf, double salario, string endereco, DateTime dtadmissao,  string telefone, string email, Login login)
        {
            this.nome = nome;
            this.dtnascimento = dtnascimento;
            this.cpf = cpf;
            this.salario = salario;
            this.endereco = endereco;
            this.dtadmissao = dtadmissao;
            this.telefone = telefone;
            this.email = email;
            this.login = login;
        }
        public Funcionario(int id, string nome, DateTime dtnascimento, string cpf, double salario, string endereco, DateTime dtadmissao, string telefone, string email, Login login)
        {
            this.id = id;
            this.nome = nome;
            this.dtnascimento = dtnascimento;
            this.cpf = cpf;
            this.salario = salario;
            this.endereco = endereco;
            this.dtadmissao = dtadmissao;
            this.telefone = telefone;
            this.email = email;
            this.login = login;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Dtnascimento { get => dtnascimento; set => dtnascimento = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public DateTime Dtadmissao { get => dtadmissao; set => dtadmissao = value; }
        public DateTime Dtdemissao { get => dtdemissao; set => dtdemissao = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public Login Login { get => login; set => login = value; }

        public override string ToString()
        {
            return this.nome;
        }
    }
}
