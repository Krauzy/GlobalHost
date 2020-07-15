using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Contas_Pagar
    {
<<<<<<< HEAD
        private int Id;
=======
        private int id;
>>>>>>> old-state
        private double valor;
        private string tipo;
        private string situacao;
        private int frete;
        private int despesa;
<<<<<<< HEAD

        public Contas_Pagar(int iD, double valor, string tipo, string situacao)
        {
            this.Id = iD;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
        }
        public Contas_Pagar(int iD, double valor, string tipo, string situacao, int frete, int despesa)
        {
            this.Id = iD;
=======
        private DateTime dt_emissao;
        private DateTime dt_vencimento;
        private DateTime dt_pagto;
        private double pago;
        
        public Contas_Pagar(int id, double valor, string tipo, string situacao, int frete, int despesa)
        {
            this.id = id;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            this.frete = frete;
            this.despesa = despesa;
        }
        public Contas_Pagar(double valor, string tipo, string situacao)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
        }
        public Contas_Pagar(double valor, string tipo, string situacao, int despesa)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            this.despesa = despesa;
        }
        public Contas_Pagar(double valor, string tipo, string situacao, int frete, int despesa)
        {
>>>>>>> old-state
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            this.frete = frete;
            this.despesa = despesa;
        }
<<<<<<< HEAD
        public Contas_Pagar(double valor, string tipo, string situacao)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
        }
        public Contas_Pagar(double valor, string tipo, string situacao, int frete, int despesa)
=======

        public Contas_Pagar(int id, double valor, string tipo, string situacao, int frete, int despesa, DateTime dt_emissao, DateTime dt_vencimento, DateTime dt_pagto, double pago)
        {
            this.id = id;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            this.frete = frete;
            this.despesa = despesa;
            this.Dt_emissao = dt_emissao;
            this.Dt_vencimento = dt_vencimento;
            this.Dt_pagto = dt_pagto;
            this.Pago = pago;
        }
        public Contas_Pagar(double valor, string tipo, string situacao, int frete, int despesa, DateTime dt_emissao, DateTime dt_vencimento, DateTime dt_pagto, double pago)
>>>>>>> old-state
        {
            this.valor = valor;
            this.tipo = tipo;
            this.situacao = situacao;
            this.frete = frete;
            this.despesa = despesa;
<<<<<<< HEAD
        }

        public int ID { get => ID; set => ID = value; }
=======
            this.Dt_emissao = dt_emissao;
            this.Dt_vencimento = dt_vencimento;
            this.Dt_pagto = dt_pagto;
            this.Pago = pago;
        }

        public int ID { get => id; set => id = value; }
>>>>>>> old-state
        public double Valor { get => valor; set => valor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public int Frete { get => frete; set => frete = value; }
        public int Despesa { get => despesa; set => despesa = value; }
<<<<<<< HEAD
=======
        public DateTime Dt_emissao { get => dt_emissao; set => dt_emissao = value; }
        public DateTime Dt_vencimento { get => dt_vencimento; set => dt_vencimento = value; }
        public DateTime Dt_pagto { get => dt_pagto; set => dt_pagto = value; }
        public double Pago { get => pago; set => pago = value; }
>>>>>>> old-state
    }
}
