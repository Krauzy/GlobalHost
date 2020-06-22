using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Persistencia
{
    class ContasPagarDB
    {
        private readonly Banco banco;

        public ContasPagarDB()
        {
            banco = new Banco();
        }
        public bool Insert(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Contas_Pagar))
            {
                Contas_Pagar c = (Contas_Pagar)obj;
                string SQL = @"INSERT INTO Contas_Pagar (valor, situacao, frete, despesa) VALUES (@valor, @situacao, @frete, @despesa)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@valor", c.Valor, "@tipo", c.Tipo, "@situacao", c.Situacao, "@frete", c.Frete, "@despesa", c.Despesa);
                banco.Disconnect();
            }
            return result;
        }
        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Contas_Pagar WHERE id = @id";
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL, "@id", id);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Contas_Pagar))
            {
                Contas_Pagar c = (Contas_Pagar)obj;
                string SQL = @"UPDATE Contas_Pagar SET valor=@valor, tipo=@tipo, situacao=@situacao,frete=@frete,despesa=@despesa";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@valor",c.Valor,"@tipo",c.Tipo,"@situacao",c.Situacao,"@frete",c.Frete,"@despesa",c.Despesa);
            }
            return result;
        }

        public Contas_Pagar get(int id)
        {
            DataTable dt = new DataTable();
            Contas_Pagar c=null;
            string SQL = @"SELECT * FROM Contas_Pagar WHERE id = @id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt, "@id", id);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    c = new Contas_Pagar((int)dt.Rows[i]["id"],
                                    (double)dt.Rows[i]["valor"],
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    (int)dt.Rows[i]["frete"],
                                    (int)dt.Rows[i]["despesa"]);
                }
            }
            banco.Disconnect();
            return c;
        }

        public List<object> getAll()
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Contas_Pagar";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Contas_Pagar c;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    c = new Contas_Pagar((int)dt.Rows[i]["id"],
                                    (double)dt.Rows[i]["valor"],
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    (int)dt.Rows[i]["frete"],
                                    (int)dt.Rows[i]["despesa"]);
                    list.Add(c);
                }
            }
            banco.Disconnect();
            return list;
        }
        public List<object> getFromDespesa(int desp)
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Contas_Pagar where despesa="+desp;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Contas_Pagar c;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    c = new Contas_Pagar((int)dt.Rows[i]["id"],
                                    (double)dt.Rows[i]["valor"],
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    (int)dt.Rows[i]["frete"],
                                    (int)dt.Rows[i]["despesa"]);
                    list.Add(c);
                }
            }
            banco.Disconnect();
            return list;
        }
    }
}
