using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Tipo_Transporte
    {
        private int id;
        private string descricao;
        private double max_peso;
        private string dimensoes;        

        public Tipo_Transporte(int id, string descricao, double max_peso, string dimensoes)
        {
            this.id = id;
            this.descricao = descricao;
            this.max_peso = max_peso;
            this.dimensoes = dimensoes;
        }

        public Tipo_Transporte(string descricao, double max_peso, string dimensoes)
        {
            //this.id = id;
            this.descricao = descricao;
            this.max_peso = max_peso;
            this.dimensoes = dimensoes;
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Max_peso { get => max_peso; set => max_peso = value; }
        public string Dimensoes { get => dimensoes; set => dimensoes = value; }

        public override string ToString()
        {
            return this.descricao;
        }
    }
}
