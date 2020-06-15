using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
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

        public bool Insert (object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Orcamento))
            {
                Orcamento o = (Orcamento)obj;
                string SQL = @"INSERT INTO Carga (valor, data, validade, pedido, transportadora) VALUES (@valor, @data, @validade, @pedido, @transportadora)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@valor", o.Valor, "@data", o.Data, "@validade", o.Vencimento, "@pedido", o.Pedido.Id, "@transportadora", o.Transportadora.Id);
                banco.Disconnect();
            }
            return result;
        }

        public bool Delete (int id)
        {
            string SQL = @"DELETE FROM Orcamento WHERE id = " + id;
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL);
            banco.Disconnect();
            return result;
        }

        public bool Update (object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Orcamento))
            {
                Orcamento o = (Orcamento)obj;
                string SQL = @"UPDATE Orcamento SET valor = @valor, data = @data, validade = @validade, pedido = @pedido, transportadora = @transportadora WHERE id = " + o.Id;
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@valor", o.Valor, "@data", o.Data, "@validade", o.Vencimento, "@pedido", o.Pedido.Id, "@transportadora", o.Transportadora.Id);
                banco.Disconnect();
            }
            return result;
        }

        public Orcamento get (int id)
        {
            DataTable dt = new DataTable();
            PedidoDB pedidos = new PedidoDB();
            TransportadoraDB transportadoras = new TransportadoraDB();
            Orcamento orc = null;
            string SQL = @"SELECT * FROM Orcamento WHERE id = " + id;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0 )
            {
                orc = new Orcamento((int)dt.Rows[0]["id"],
                        Convert.ToDouble(dt.Rows[0]["id"]),
                      Convert.ToDateTime(dt.Rows[0]["id"]),
                      Convert.ToDateTime(dt.Rows[0]["id"]),
                        pedidos.get((int)dt.Rows[0]["id"]),
                transportadoras.get((int)dt.Rows[0]["id"]));
            }
            banco.Disconnect();
            return orc;
        }

        public List<object> getList(string op)
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            PedidoDB pedidos = new PedidoDB();
            TransportadoraDB transportadoras = new TransportadoraDB();
            string SQL = @"SELECT * FROM Orcamento WHERE " + op;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Orcamento orc = new Orcamento((int)dt.Rows[i]["id"],
                                      Convert.ToDouble(dt.Rows[i]["id"]),
                                    Convert.ToDateTime(dt.Rows[i]["id"]),
                                    Convert.ToDateTime(dt.Rows[i]["id"]),
                                      pedidos.get((int)dt.Rows[i]["id"]),
                              transportadoras.get((int)dt.Rows[i]["id"]));
                    list.Add(orc);
                }
            }
            banco.Disconnect();
            return list;
        }

        public List<object> getAll()
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            PedidoDB pedidos = new PedidoDB();
            TransportadoraDB transportadoras = new TransportadoraDB();
            string SQL = @"SELECT * FROM Orcamento";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Orcamento orc = new Orcamento((int)dt.Rows[i]["id"],
                                      Convert.ToDouble(dt.Rows[i]["id"]),
                                    Convert.ToDateTime(dt.Rows[i]["id"]),
                                    Convert.ToDateTime(dt.Rows[i]["id"]),
                                      pedidos.get((int)dt.Rows[i]["id"]),
                              transportadoras.get((int)dt.Rows[i]["id"]));
                    list.Add(orc);
                }
            }
            banco.Disconnect();
            return list;
        }
    }
}
