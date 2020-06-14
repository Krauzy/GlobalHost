using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Orcamento
    {
        private int id;
        private double valor;
        private DateTime data;
        private DateTime vencimento;
        private Pedido pedido;
        private Transportadora transportadora;

        public Orcamento(int id, double valor, DateTime data, DateTime vencimento, Pedido pedido, Transportadora transportadora)
        {
            this.id = id;
            this.valor = valor;
            this.data = data;
            this.vencimento = vencimento;
            this.pedido = pedido;
            this.transportadora = transportadora;
        }

        public Orcamento(double valor, DateTime data, DateTime vencimento, Pedido pedido, Transportadora transportadora)
        {
            this.valor = valor;
            this.data = data;
            this.vencimento = vencimento;
            this.pedido = pedido;
            this.transportadora = transportadora;
        }

        public int Id { get => id; set => id = value; }
        public double Valor { get => valor; set => valor = value; }
        public DateTime Data { get => data; set => data = value; }
        public DateTime Vencimento { get => vencimento; set => vencimento = value; }
        public Pedido Pedido { get => pedido; set => pedido = value; }
        public Transportadora Transportadora { get => transportadora; set => transportadora = value; }
    }
}
