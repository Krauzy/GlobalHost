using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Persistencia
{
    class ContaAPagarDB
    {
        private readonly Banco banco;

        public ContaAPagarDB()
        {
            this.banco = new Banco();
        }

        public bool Insert(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(ContaAPagar))
            {
                ContaAPagar c = (ContaAPagar)obj;
                string SQL = @"INSERT INTO Contas_Pagar (valor, tipo, situacao, frete, despesa) VALUES (@valor, @tipo, @situacao, @frete, @despesa)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@valor", c.Valor, "@tipo", c.Tipo, "@situacao", c.Situacao, "@frete", c.Frete, "@despesa", c.Despesa);
                banco.Disconnect();
            }
            return result;
        }

        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Contas_Pagar WHERE id = " + id;
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(ContaAPagar))
            {
                ContaAPagar c = (ContaAPagar)obj;
                string SQL = @"UPDATE Contas_Pagar SET valor = @valor, tipo = @tipo, situacao = @situacao, frete = @frete, despesa = @despesa";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@valor", c.Valor, "@tipo", c.Tipo, "@situacao", c.Situacao, "@frete", c.Frete, "@despesa", c.Despesa);
                banco.Disconnect();
            }
            return result;
        }

        public ContaAPagar get(int id)
        {
            DataTable dt = new DataTable();
            ContaAPagar c = null;
            string SQL = @"SELECT * FROM Contas_Pagar WHERE id = " + id;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                c = new ContaAPagar((int)dt.Rows[0]["id"],
                                Convert.ToDouble(dt.Rows[0]["valor"]),
                                dt.Rows[0]["tipo"].ToString(),
                                dt.Rows[0]["situacao"].ToString(),
                                Convert.ToInt32(dt.Rows[0]["frete"]), 
                                Convert.ToInt32(dt.Rows[0]["despesa"]));
            }
            banco.Disconnect();
            return c;
        }

        public List<object> get(string op)
        {
            DataTable dt = new DataTable();
            List<object> lista = new List<object>();
            ContaAPagar c = null;
            string SQL = @"SELECT * FROM Contas_Pagar WHERE id = " + op;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    c = new ContaAPagar((int)dt.Rows[0]["id"],
                                Convert.ToDouble(dt.Rows[0]["valor"]),
                                dt.Rows[0]["tipo"].ToString(),
                                dt.Rows[0]["situacao"].ToString(),
                                Convert.ToInt32(dt.Rows[0]["frete"]),
                                Convert.ToInt32(dt.Rows[0]["despesa"]));
                    lista.Add(c);
                }

            }
            banco.Disconnect();
            return lista;
        }

        public List<object> getAll()
        {
            DataTable dt = new DataTable();
            List<object> lista = new List<object>();
            ContaAPagar c = null;
            string SQL = @"SELECT * FROM Contas_Pagar ORDER BY id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    c = new ContaAPagar((int)dt.Rows[0]["id"],
                                Convert.ToDouble(dt.Rows[0]["valor"]),
                                dt.Rows[0]["tipo"].ToString(),
                                dt.Rows[0]["situacao"].ToString(),
                                Convert.ToInt32(dt.Rows[0]["frete"]),
                                Convert.ToInt32(dt.Rows[0]["despesa"]));
                    lista.Add(c);
                }

            }
            banco.Disconnect();
            return lista;
        }
    }
}
