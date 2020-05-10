using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Carga
    {
        private int id;
        private string descricao;
        private int volume;
        private double peso;
        private string dimensoes;
        private double valor_Unitario;
        private double valor;
        private Tipo_Carga tipo;
        private Pedido pedido;

        public Carga(int id, string descricao, int volume, double peso, string dimensoes, double valor_Unitario, double valor, Tipo_Carga tipo, Pedido pedido)
        {
            this.id = id;
            this.descricao = descricao;
            this.volume = volume;
            this.peso = peso;
            this.dimensoes = dimensoes;
            this.valor_Unitario = valor_Unitario;
            this.valor = valor;
            this.tipo = tipo;
            this.pedido = pedido;
        }

        public Carga(string descricao, int volume, double peso, string dimensoes, double valor_Unitario, double valor, Tipo_Carga tipo, Pedido pedido)
        {
            //this.id = id;
            this.descricao = descricao;
            this.volume = volume;
            this.peso = peso;
            this.dimensoes = dimensoes;
            this.valor_Unitario = valor_Unitario;
            this.valor = valor;
            this.tipo = tipo;
            this.pedido = pedido;
        }

        public Carga(int id, string descricao, int volume, double peso, string dimensoes, double valor_Unitario, double valor, Tipo_Carga tipo)
        {
            this.id = id;
            this.descricao = descricao;
            this.volume = volume;
            this.peso = peso;
            this.dimensoes = dimensoes;
            this.valor_Unitario = valor_Unitario;
            this.valor = valor;
            this.tipo = tipo;
            //this.pedido = pedido;
        }

        public Carga(string descricao, int volume, double peso, string dimensoes, double valor_Unitario, double valor, Tipo_Carga tipo)
        {
            //this.id = id;
            this.descricao = descricao;
            this.volume = volume;
            this.peso = peso;
            this.dimensoes = dimensoes;
            this.valor_Unitario = valor_Unitario;
            this.valor = valor;
            this.tipo = tipo;
            //this.pedido = pedido;
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Volume { get => volume; set => volume = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Dimensoes { get => dimensoes; set => dimensoes = value; }
        public double Valor_Unitario { get => valor_Unitario; set => valor_Unitario = value; }
        public double Valor { get => valor; set => valor = value; }
        internal Tipo_Carga Tipo { get => tipo; set => tipo = value; }
        internal Pedido Pedido { get => pedido; set => pedido = value; }
    }
}
