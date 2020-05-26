using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class ContaAPagar
    {
        private int id;
        private double valor;
        private string tipo;
        private string situacao;
        private int frete;
        private int despesa;

        public ContaAPagar(int id, double valor, string tipo, string situacao)
        {
            this.Id = id;
            this.Valor = valor;
            this.Tipo = tipo;
            this.Situacao = situacao;
            frete = -1;
            despesa = -1;
        }

        public ContaAPagar(double valor, string tipo, string situacao, object frete, object despesa)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            if(frete.GetType() == typeof(int))
                this.frete = (int)frete;
            if(despesa.GetType() == typeof(int))
                this.despesa = (int)despesa;
        }

        public ContaAPagar(int id, double valor, string tipo, string situacao, object frete, object despesa)
        {
            this.id = id;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            if (frete.GetType() == typeof(int))
                this.frete = (int)frete;
            if (despesa.GetType() == typeof(int))
                this.despesa = (int)despesa;
        }

        public int Id { get => id; set => id = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public int Frete { get => frete; set => frete = value; }
        public int Despesa { get => despesa; set => despesa = value; }
    }
}
