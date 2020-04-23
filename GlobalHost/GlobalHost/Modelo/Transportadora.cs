using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Transportadora
    {
        private int id;
        private string nome;
        private double valor;
        private int max_carga;
        private string endereco;
        private string contato;
        private string telefone;
        private string email;
        private string cnpj;
        private Tipo_Transporte tipo;

        public Transportadora(int id, string nome, double valor, int max_carga, string endereco, string contato, string telefone, string email, string cnpj, Tipo_Transporte tipo)
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
            this.max_carga = max_carga;
            this.endereco = endereco;
            this.contato = contato;
            this.telefone = telefone;
            this.email = email;
            this.cnpj = cnpj;
            this.tipo = tipo;
        }

        public Transportadora(string nome, double valor, int max_carga, string endereco, string contato, string telefone, string email, string cnpj, Tipo_Transporte tipo)
        {
            //this.id = id;
            this.nome = nome;
            this.valor = valor;
            this.max_carga = max_carga;
            this.endereco = endereco;
            this.contato = contato;
            this.telefone = telefone;
            this.email = email;
            this.cnpj = cnpj;
            this.tipo = tipo;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Max_carga { get => max_carga; set => max_carga = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Contato { get => contato; set => contato = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        internal Tipo_Transporte Tipo { get => tipo; set => tipo = value; }
    }
}
