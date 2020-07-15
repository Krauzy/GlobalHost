using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Persistencia
{
    class DespesaDB
    {
        private readonly Banco banco;

        public DespesaDB()
        {
            banco = new Banco();
        }
        public bool Insert(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Despesa))
            {
                Despesa d = (Despesa)obj;
                string SQL = @"INSERT INTO Despesa (descricao, tipo, estado) VALUES (@descricao, @tipo, @estado)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL,"@descricao",d.Descricao,"@tipo",d.Tipo,"@estado",d.Estado);
                banco.Disconnect();
            }
            return result;
        }
        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Despesa WHERE id = @id";
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL, "@id", id);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Despesa))
            {
                Despesa d = (Despesa)obj;
<<<<<<< HEAD
                string SQL = @"UPDATE Cliente SET descricao=@descricao, tipo=@tipo, estado=@estado";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@descricao", d.Descricao, "@tipo", d.Tipo, "@estado", d.Estado);
=======
                string SQL = @"UPDATE Despesa SET descricao=@descricao, tipo=@tipo, estado=@estado where ID=@ID";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@descricao", d.Descricao, "@tipo", d.Tipo, "@estado", d.Estado,"@ID",d.Id);
>>>>>>> old-state
            }
            return result;
        }

        public Despesa get(int id)
        {
            DataTable dt = new DataTable();
            Despesa d = null;
            string SQL = @"SELECT * FROM Despesa WHERE id = @id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt, "@id", id);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    d = new Despesa((int)dt.Rows[i]["id"],
                                    dt.Rows[i]["descricao"].ToString(),
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["estado"].ToString());
                }
            }
            banco.Disconnect();
            return d;
        }
<<<<<<< HEAD

=======
>>>>>>> old-state
        public List<object> getAll()
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Despesa";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Despesa d;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    d = new Despesa((int)dt.Rows[i]["id"],
                                    dt.Rows[i]["descricao"].ToString(),
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["estado"].ToString());
                    list.Add(d);
                }
            }
            banco.Disconnect();
            return list;
        }
<<<<<<< HEAD
=======
        public List<object> getNotPaga()
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Despesa WHERE estado <> 'PAGO'";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Despesa d;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    d = new Despesa((int)dt.Rows[i]["id"],
                                    dt.Rows[i]["descricao"].ToString(),
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["estado"].ToString());
                    list.Add(d);
                }
            }
            banco.Disconnect();
            return list;
        }
        public int getIdentity()
        {
            string SQL = @"SELECT IDENT_CURRENT('Despesa')";
            DataTable dt = new DataTable();
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            banco.Disconnect();
            return Convert.ToInt32(dt.Rows[0][0]);
        }
>>>>>>> old-state
    }
}
