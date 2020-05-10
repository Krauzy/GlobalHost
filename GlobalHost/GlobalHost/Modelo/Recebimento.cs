using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Recebimento
    {
        private int id;
        private string tipo;
        private double valor;

        public Recebimento(int id, string tipo, double valor)
        {
            this.id = id;
            this.tipo = tipo;
            this.valor = valor;
        }

        public Recebimento(string tipo, double valor)
        {
            this.tipo = tipo;
            this.valor = valor;
        }

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
