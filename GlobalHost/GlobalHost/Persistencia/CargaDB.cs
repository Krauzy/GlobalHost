using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Persistencia
{
    class CargaDB
    {
        private readonly Banco banco;

        public CargaDB () {
            this.banco = new Banco();
        }

        public bool Insert(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Carga))
            {
                Carga c = (Carga)obj;
                string SQL = @"INSERT INTO Carga (descricao, volume, peso, dimensoes, valor_unitario, valor, tipo, pedido) VALUES (@desc, @vol, @peso, @dim, @unit, @tot, @tipo, @ped)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@desc", c.Descricao, "@vol", c.Volume, "@peso", c.Peso, "@dim", c.Dimensoes, "@unit", c.Valor_Unitario, "@tot", c.Valor, "@tipo", c.Tipo, "@ped", c.Pedido);
                banco.Disconnect();
            }
            return result;
        }

        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Carga WHERE id = " + id;
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Carga))
            {
                Carga c = (Carga)obj;
                string SQL = @"UPDATE Carga SET descricao = @desc, volume = @vol, peso = @peso, dimensoes = @dim, valor_unitario = @unit, valor = @tot, tipo = @tipo, pedido = @ped WHERE id = " + c.Id;
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@desc", c.Descricao, "@vol", c.Volume, "@peso", c.Peso, "@dim", c.Dimensoes, "@unit", c.Valor_Unitario, "@tot", c.Valor, "@tipo", c.Tipo, "@ped", c.Pedido);
                banco.Disconnect();
            }
            return result;
        }

        public Carga get(int id)
        {
            DataTable dt = new DataTable();
            Tipo_CargaDB tipos = new Tipo_CargaDB();
            PedidoDB pedidos = new PedidoDB();
            Carga c = null;
            string SQL = @"SELECT * FROM Carga WHERE id = " + id;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                c = new Carga((int)dt.Rows[0]["id"],
                                dt.Rows[0]["descricao"].ToString(),
                                (int)dt.Rows[0]["volume"],
                                Convert.ToDouble(dt.Rows[0]["peso"]),
                                dt.Rows[0]["dimensoes"].ToString(),
                                Convert.ToDouble(dt.Rows[0]["valor_unitario"]),
                                Convert.ToDouble(dt.Rows[0]["valor"]),
                                tipos.get((int)dt.Rows[0]["tipo"]),
                                pedidos.get((int)dt.Rows[0]["pedido"]));
            }
            banco.Disconnect();
            return c;
        }

        public List<object> get(string op)
        {
            DataTable dt = new DataTable();
            Tipo_CargaDB tipos = new Tipo_CargaDB();
            PedidoDB pedidos = new PedidoDB();
            List<object> lista = new List<object>();

            string SQL = @"SELECT * FROM Carga WHERE " + op;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Carga c = new Carga((int)dt.Rows[0]["id"],
                                dt.Rows[0]["descricao"].ToString(),
                                (int)dt.Rows[0]["volume"],
                                Convert.ToDouble(dt.Rows[0]["peso"]),
                                dt.Rows[0]["dimensoes"].ToString(),
                                Convert.ToDouble(dt.Rows[0]["valor_unitario"]),
                                Convert.ToDouble(dt.Rows[0]["valor"]),
                                tipos.get((int)dt.Rows[0]["tipo"]),
                                pedidos.get((int)dt.Rows[0]["pedido"]));
                    lista.Add(c);
                }
                
            }
            banco.Disconnect();
            return lista;
        }

        public List<object> getAll()
        {
            DataTable dt = new DataTable();
            Tipo_CargaDB tipos = new Tipo_CargaDB();
            PedidoDB pedidos = new PedidoDB();
            List<object> lista = new List<object>();

            string SQL = @"SELECT * FROM Carga ORDER BY id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Carga c = new Carga((int)dt.Rows[0]["id"],
                                dt.Rows[0]["descricao"].ToString(),
                                (int)dt.Rows[0]["volume"],
                                Convert.ToDouble(dt.Rows[0]["peso"]),
                                dt.Rows[0]["dimensoes"].ToString(),
                                Convert.ToDouble(dt.Rows[0]["valor_unitario"]),
                                Convert.ToDouble(dt.Rows[0]["valor"]),
                                tipos.get((int)dt.Rows[0]["tipo"]),
                                pedidos.get((int)dt.Rows[0]["pedido"]));
                    lista.Add(c);
                }

            }
            banco.Disconnect();
            return lista;
        }
    }
}
