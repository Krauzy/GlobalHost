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
            this.banco = new Banco();
        }

        public bool Insert(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Despesa))
            {
                Despesa d = (Despesa)obj;
                string SQL = @"INSERT INTO Despesa (descricao, tipo, estado) VALUES (@descricao, @tipo, @estado)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "descricao",d.Descricao,"@tipo",d.Tipo,"@estado",d.Estado);
                banco.Disconnect();
            }
            return result;
        }
        public bool Insert(object obj, double valor, int parcelas)
        {
            bool result = false;
            if (obj.GetType() == typeof(Despesa))
            {
                Despesa d = (Despesa)obj;
                ContaAPagarDB cdb = new ContaAPagarDB();
                string SQL = @"INSERT INTO Despesa (descricao, tipo, estado) VALUES (@descricao, @tipo, @estado)";
                double restante = 0;
                if (valor % parcelas == 0)
                    valor = valor / parcelas;
                else
                {
                    restante = valor % parcelas;
                    valor = valor / parcelas;
                }
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "descricao", d.Descricao, "@tipo", d.Tipo, "@estado", d.Estado);
                for(int i =0; i < parcelas; i++)
                {
                    result = cdb.Insert(new ContaAPagar(valor, d.Tipo, "PENDENTE", null, d.Id));
                }
                if(restante == 0)
                    result = cdb.Insert(new ContaAPagar(restante, d.Tipo, "PENDENTE", null, d.Id));
                banco.Disconnect();
            }
            return result;
        }

        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Despesa WHERE id = " + id;
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Despesa))
            {
                Despesa d = (Despesa)obj;
                string SQL = @"UPDATE Despesa SET descricao = @descricao, tipo = @tipo, estado = @estado";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@descricao", d.Descricao, "@tipo", d.Tipo, "@estado", d.Estado);
                banco.Disconnect();
            }
            return result;
        }

        public Despesa get(int id)
        {
            DataTable dt = new DataTable();
            Despesa d = null;
            string SQL = @"SELECT * FROM Contas_Pagar WHERE id = " + id;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                d = new Despesa((int)dt.Rows[0]["id"],
                                dt.Rows[0]["descricao"].ToString(),
                                dt.Rows[0]["tipo"].ToString(),
                                dt.Rows[0]["estado"].ToString());
            }
            banco.Disconnect();
            return d;
        }

        public List<object> get(string op)
        {
            DataTable dt = new DataTable();
            List<object> lista = new List<object>();
            Despesa d = null;
            string SQL = @"SELECT * FROM Despesa WHERE id = " + op;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    d = new Despesa((int)dt.Rows[0]["id"],
                                dt.Rows[0]["descricao"].ToString(),
                                dt.Rows[0]["tipo"].ToString(),
                                dt.Rows[0]["estado"].ToString());
                    lista.Add(d);
                }

            }
            banco.Disconnect();
            return lista;
        }

        public List<object> getAll()
        {
            DataTable dt = new DataTable();
            List<object> lista = new List<object>();
            Despesa d = null;
            string SQL = @"SELECT * FROM Despesa ORDER BY id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    d = new Despesa((int)dt.Rows[0]["id"],
                                dt.Rows[0]["descricao"].ToString(),
                                dt.Rows[0]["tipo"].ToString(),
                                dt.Rows[0]["estado"].ToString());
                    lista.Add(d);
                }

            }
            banco.Disconnect();
            return lista;
        }
    }
}
