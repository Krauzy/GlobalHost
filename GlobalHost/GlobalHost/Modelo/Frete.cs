using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Frete
    {
        private int id;
        private double total;
        private string situacao;
        private Orcamento orcamento;
        private Remessa remessa;

        public Frete ()
        {}

        public Frete(int id, double total, string situacao, Orcamento orcamento, Remessa remessa)
        {
            this.id = id;
            this.total = total;
            this.situacao = situacao;
            this.orcamento = orcamento;
            this.remessa = remessa;
        }

        public Frete(double total, string situacao, Orcamento orcamento, Remessa remessa)
        {
            //this.id = id;
            this.total = total;
            this.situacao = situacao;
            this.orcamento = orcamento;
            this.remessa = remessa;
        }

        public int Id { get => id; set => id = value; }
        public double Total { get => total; set => total = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public Orcamento Orcamento { get => orcamento; set => orcamento = value; }
        public Remessa Remessa { get => remessa; set => remessa = value; }
    }
}
