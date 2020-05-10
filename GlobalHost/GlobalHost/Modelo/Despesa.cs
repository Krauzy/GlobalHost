using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Despesa
    {
        private int id;
        private string descricao;
        private string tipo;
        private string estado;

        public Despesa(int id, string descricao, string tipo, string estado)
        {
            this.id = id;
            this.descricao = descricao;
            this.tipo = tipo;
            this.estado = estado;
        }

        public Despesa(string descricao, string tipo, string estado)
        {
            //this.id = id;
            this.descricao = descricao;
            this.tipo = tipo;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
