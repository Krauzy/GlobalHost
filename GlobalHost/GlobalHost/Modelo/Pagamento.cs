using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Pagamento
    {
        private int id;
        private double valor;
        private string tipo;
        private string situacao;
        private Frete frete;
        private Despesa despesa;

        public Pagamento(int id, double valor, string tipo, string situacao, Frete frete, Despesa despesa)
        {
            this.id = id;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            this.frete = frete;
            this.despesa = despesa;
        }

        public Pagamento(double valor, string tipo, string situacao, Frete frete, Despesa despesa)
        {
            //this.id = id;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            this.frete = frete;
            this.despesa = despesa;
        }

        public Pagamento(int id, double valor, string tipo, string situacao, Frete frete)
        {
            this.id = id;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            this.frete = frete;
            //this.despesa = despesa;
        }

        public Pagamento(double valor, string tipo, string situacao, Frete frete)
        {
            //this.id = id;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            this.frete = frete;
            //this.despesa = despesa;
        }

        public Pagamento(int id, double valor, string tipo, string situacao, Despesa despesa)
        {
            this.id = id;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            //this.frete = frete;
            this.despesa = despesa;
        }

        public Pagamento(double valor, string tipo, string situacao, Despesa despesa)
        {
            //this.id = id;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            //this.frete = frete;
            this.despesa = despesa;
        }

        public int Id { get => id; set => id = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public Frete Frete { get => frete; set => frete = value; }
        public Despesa Despesa { get => despesa; set => despesa = value; }
    }
}
