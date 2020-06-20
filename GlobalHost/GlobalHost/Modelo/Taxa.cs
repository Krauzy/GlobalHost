using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Taxa
    {
        private int id;
        private string descricao;
        private double valor;
        private Orcamento orcamento;

        public Taxa(string descricao, double valor, Orcamento orcamento)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.orcamento = orcamento;
        }

        public Taxa(int id, string descricao, double valor, Orcamento orcamento)
        {
            this.id = id;
            this.descricao = descricao;
            this.valor = valor;
            this.orcamento = orcamento;
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => valor = value; }
        public Orcamento Orcamento { get => orcamento; set => orcamento = value; }

        public override string ToString()
        {
            return this.descricao;
        }
    }
}
