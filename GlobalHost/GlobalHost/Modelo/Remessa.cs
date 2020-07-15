using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Remessa
    {
        private int id;
        private string descricao;
        private string origem;
        private string destino;
        private DateTime saida;
        private DateTime previsao;
        private DateTime requerimento;
        private Transportadora transportadora;

        public Remessa(int id)
        {
            this.id = id;
        }

        public Remessa(int id, string descricao, string origem, string destino, DateTime saida, DateTime previsao, DateTime requerimento, Transportadora transportadora)
        {
            this.id = id;
            this.descricao = descricao;
            this.origem = origem;
            this.destino = destino;
            this.saida = saida;
            this.previsao = previsao;
            this.requerimento = requerimento;
            this.transportadora = transportadora;
        }

        public Remessa(string descricao, string origem, string destino, DateTime saida, DateTime previsao, DateTime requerimento, Transportadora transportadora)
        {
            //this.id = id;
            this.descricao = descricao;
            this.origem = origem;
            this.destino = destino;
            this.saida = saida;
            this.previsao = previsao;
            this.requerimento = requerimento;
            this.transportadora = transportadora;
        }

        public Remessa(int id, string descricao, string origem, string destino, DateTime saida, DateTime previsao, Transportadora transportadora)
        {
            this.id = id;
            this.descricao = descricao;
            this.origem = origem;
            this.destino = destino;
            this.saida = saida;
            this.previsao = previsao;
            //this.requerimento = requerimento;
            this.transportadora = transportadora;
        }

        public Remessa(string descricao, string origem, string destino, DateTime saida, DateTime previsao, Transportadora transportadora)
        {
            //this.id = id;
            this.descricao = descricao;
            this.origem = origem;
            this.destino = destino;
            this.saida = saida;
            this.previsao = previsao;
            //this.requerimento = requerimento;
            this.transportadora = transportadora;
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Origem { get => origem; set => origem = value; }
        public string Destino { get => destino; set => destino = value; }
        public DateTime Saida { get => saida; set => saida = value; }
        public DateTime Previsao { get => previsao; set => previsao = value; }
        public DateTime Requerimento { get => requerimento; set => requerimento = value; }
        public Transportadora Transportadora { get => transportadora; set => transportadora = value; }

        public override string ToString()
        {
            return this.descricao;
        }
    }
}
