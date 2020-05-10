using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Transporte
    {
        private int id;
        private string situacao;
        private int etapas;
        private Remessa remessa;

        public Transporte(int id, string situacao, int etapas, Remessa remessa)
        {
            this.id = id;
            this.situacao = situacao;
            this.etapas = etapas;
            this.remessa = remessa;
        }

        public Transporte(string situacao, int etapas, Remessa remessa)
        {
            //this.id = id;
            this.situacao = situacao;
            this.etapas = etapas;
            this.remessa = remessa;
        }

        public int Id { get => id; set => id = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public int Etapas { get => etapas; set => etapas = value; }
        public Remessa Remessa { get => remessa; set => remessa = value; }
    }
}
