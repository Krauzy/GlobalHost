using System;

namespace GlobalHost.Modelo
{
    class Pedido
    {
        private int id;
        private DateTime data;
        private string modalidade;
        private string origem;
        private string destino;
        private string despachante;
        private string situacao;
        private Cliente cliente;
        private Funcionario funcionario;
        private Remessa remessa;

        public Pedido(int id, DateTime data, string modalidade, string origem, string destino, string despachante, string situacao, Cliente cliente, Funcionario funcionario, Remessa remessa)
        {
            this.id = id;
            this.data = data;
            this.modalidade = modalidade;
            this.origem = origem;
            this.destino = destino;
            this.despachante = despachante;
            this.situacao = situacao;
            this.cliente = cliente;
            this.funcionario = funcionario;
            this.remessa = remessa;
        }

        public Pedido(DateTime data, string modalidade, string origem, string destino, string despachante, string situacao, Cliente cliente, Funcionario funcionario, Remessa remessa)
        {
            this.data = data;
            this.modalidade = modalidade;
            this.origem = origem;
            this.destino = destino;
            this.despachante = despachante;
            this.situacao = situacao;
            this.cliente = cliente;
            this.funcionario = funcionario;
            this.remessa = remessa;
        }

        public Pedido(int id, DateTime data, string modalidade, string origem, string destino, string despachante, string situacao, Cliente cliente, Funcionario funcionario)
        {
            this.id = id;
            this.data = data;
            this.modalidade = modalidade;
            this.origem = origem;
            this.destino = destino;
            this.despachante = despachante;
            this.situacao = situacao;
            this.cliente = cliente;
            this.funcionario = funcionario;
        }

        public Pedido(DateTime data, string modalidade, string origem, string destino, string despachante, string situacao, Cliente cliente, Funcionario funcionario)
        {
            this.data = data;
            this.modalidade = modalidade;
            this.origem = origem;
            this.destino = destino;
            this.despachante = despachante;
            this.situacao = situacao;
            this.cliente = cliente;
            this.funcionario = funcionario;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Modalidade { get => modalidade; set => modalidade = value; }
        public string Origem { get => origem; set => origem = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Despachante { get => despachante; set => despachante = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Funcionario Funcionario { get => funcionario; set => funcionario = value; }
        internal Remessa Remessa { get => remessa; set => remessa = value; }

        public override string ToString()
        {
            return this.id.ToString();
        }
    }
}
