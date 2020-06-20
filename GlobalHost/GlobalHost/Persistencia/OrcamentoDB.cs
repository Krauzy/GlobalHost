using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalHost.Persistencia
{
    class OrcamentoDB
    {
        private readonly Banco banco;

        public OrcamentoDB ()
        {
            this.banco = new Banco();
        }

        //public bool Insert (object obj)
        //{
        //    bool result = false;
        //    if(obj.GetType() == typeof(Orcamento))
        //    {
        //        Orcamento o = (Orcamento)obj;
        //        string SQL = @"INSERT INTO Carga (valor, data, validade, pedido, transportadora) VALUES (@valor, @data, @validade, @pedido, @transportadora)";
        //        banco.Connect();
        //        banco.ExecuteNonQuery(SQL, "@valor", o.Valor, "@data", o.Data, "@validade", o.Vencimento)
        //    }
        //}
    }
}
