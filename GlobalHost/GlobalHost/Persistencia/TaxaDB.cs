using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;

namespace GlobalHost.Persistencia
{
    class TaxaDB
    {
        private readonly Banco banco;

        public TaxaDB()
        {
            this.banco = new Banco();
        }

        public bool Insert (object obj)
        {
            bool result = false;
            if(obj.GetType() == typeof(Taxa))
            {
                Taxa tx = (Taxa)obj;
                string SQL = @"INSERT INTO Taxa (descricao, valor, orcamento) values (@desc, @valor, @orc)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@desc", tx.Descricao, "@valor", tx.Valor, "@orc", tx.Orcamento.Id);
                banco.Disconnect();
            }
            return result;
        }

        public bool Delete (int id)
        {
            string SQL = @"DELETE FROM Taxa WHERE id = " + id;
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL);
            banco.Disconnect();
            return result;
        }

        public bool Update (object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Taxa))
            {
                Taxa tx = (Taxa)obj;
                string SQL = @"UPDATE Taxa SET descricao = @desc, valor = @valor, orcamento = @orc WHERE id = " + tx.Id;
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@desc", tx.Descricao, "@valor", tx.Valor, "@orc", tx.Orcamento.Id);
                banco.Disconnect();
            }
            return result;
        }

        public Taxa get (int id)
        {
            DataTable dt = new DataTable();
            Taxa x = null;
            OrcamentoDB DB = new OrcamentoDB();
            string SQL = @"SELECT * FROM Taxa WHERE id = " + id;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                x = new Taxa((int)dt.Rows[0]["id"],
                                  dt.Rows[0]["descricao"].ToString(),
                 Convert.ToDouble(dt.Rows[0]["valor"]),
                      DB.get((int)dt.Rows[0]["orcamento"]));
            }
            banco.Disconnect();
            return x;
        }

        public List<object> getList (string op)
        {
            DataTable dt = new DataTable();
            OrcamentoDB DB = new OrcamentoDB();
            List<object> list = new List<object>();
            string SQL = @"SELECT * FROM Taxa WHERE " + op;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Taxa x = new Taxa((int)dt.Rows[i]["id"],
                                           dt.Rows[i]["descricao"].ToString(),
                          Convert.ToDouble(dt.Rows[i]["valor"]),
                               DB.get((int)dt.Rows[i]["orcamento"]));
                    list.Add(x);
                }                
            }
            banco.Disconnect();
            return list;
        }

        public List<object> getAll ()
        {
            DataTable dt = new DataTable();
            OrcamentoDB DB = new OrcamentoDB();
            List<object> list = new List<object>();
            string SQL = @"SELECT * FROM Taxa";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Taxa x = new Taxa((int)dt.Rows[i]["id"],
                                           dt.Rows[i]["descricao"].ToString(),
                          Convert.ToDouble(dt.Rows[i]["valor"]),
                               DB.get((int)dt.Rows[i]["orcamento"]));
                    list.Add(x);
                }
            }
            banco.Disconnect();
            return list;
        }
    }
}
