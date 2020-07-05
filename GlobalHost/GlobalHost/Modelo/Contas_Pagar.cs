using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Contas_Pagar
    {
        private int Id;
        private double valor;
        private string tipo;
        private string situacao;
        private int frete;
        private int despesa;

        public Contas_Pagar(int iD, double valor, string tipo, string situacao)
        {
            this.Id = iD;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
        }
        public Contas_Pagar(int iD, double valor, string tipo, string situacao, int frete, int despesa)
        {
            this.Id = iD;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            this.frete = frete;
            this.despesa = despesa;
        }
        public Contas_Pagar(double valor, string tipo, string situacao)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
        }
        public Contas_Pagar(double valor, string tipo, string situacao, int frete, int despesa)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            this.frete = frete;
            this.despesa = despesa;
        }

        public int ID { get => ID; set => ID = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public int Frete { get => frete; set => frete = value; }
        public int Despesa { get => despesa; set => despesa = value; }
    }
}
