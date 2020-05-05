using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Tipo_Carga
    {
        private int id;
        private string descricao;
        private double peso;
        private string dimensoes; // L;A;C -> "10;22;45"

        public Tipo_Carga(int id, string descricao, double peso, string dimensoes)
        {
            this.id = id;
            this.descricao = descricao;
            this.peso = peso;
            this.dimensoes = dimensoes;
        }

        public Tipo_Carga(string descricao, double peso, string dimsensoes)
        {
            this.descricao = descricao;
            this.peso = peso;
            this.dimensoes = dimsensoes;
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Dimensoes { get => dimensoes; set => dimensoes = value; }
    }
}
