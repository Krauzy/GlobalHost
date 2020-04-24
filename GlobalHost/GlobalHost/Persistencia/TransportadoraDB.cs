using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Persistencia
{
    class TransportadoraDB
    {
        private readonly Banco banco;

        public TransportadoraDB()
        {
            banco = new Banco();
        }

        public bool Insert(object obj)
        {
            bool result = false;
            if(obj.GetType() == typeof(Transportadora))
            {
                Transportadora t = (Transportadora)obj;
                string SQL = @"INSERT INTO Transportadora (nome, valor, max_carga, endereco, contato, telefone, email, cnpj, tipo) " 
                        + @"VALUES (@nome, @valor, @carga, @end, @cont, @tel, @email, @cnpj, @tipo)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@nome", t.Nome, "@valor", t.Valor, "@carga", t.Max_carga, "@end", t.Endereco, 
                    "@cont", t.Contato, "@tel", t.Telefone, "@email", t.Email, "@cnpj", t.Cnpj, "@tipo", t.Tipo.Id);
                banco.Disconnect();
            }
            return result;
        }

        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Transportadora WHERE id = " + id;
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if(obj.GetType() == typeof(Transportadora))
            {
                Transportadora t = (Transportadora)obj;
                string SQL = @"UPDATE Transportadora SET nome = @nome, valor = @valor, max_carga = @carga, endereco = @end," 
                    + @" contato = @cont, telefone = @tel, email = @email, cnpj = @cnpj, tipo = @tipo WHERE id = " + t.Id;
                banco.Disconnect();
                result = banco.ExecuteNonQuery(SQL, "@nome", t.Nome, "@valor", t.Valor, "@carga", t.Max_carga, "@end", t.Endereco,
                    "@cont", t.Contato, "@tel", t.Telefone, "@email", t.Email, "@cnpj", t.Cnpj, "@tipo", t.Tipo.Id);
                banco.Disconnect();
            }
            return result;
        }

        public Transportadora get(int id)
        {
            DataTable dt = new DataTable();
            Transportadora t = null;
            Tipo_TransporteDB DB = new Tipo_TransporteDB();
            string SQL = @"SELECT * FROM Transportadora WHERE id = " + id;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if(dt.Rows.Count > 0)
            {
                t = new Transportadora((int)dt.Rows[0]["id"],
                                            dt.Rows[0]["nome"].ToString(),
                                    (double)dt.Rows[0]["valor"],
                                       (int)dt.Rows[0]["max_carga"],
                                            dt.Rows[0]["endereco"].ToString(),
                                            dt.Rows[0]["contato"].ToString(),
                                            dt.Rows[0]["telefone"].ToString(),
                                            dt.Rows[0]["email"].ToString(),
                                            dt.Rows[0]["cnpj"].ToString(),
                                DB.get((int)dt.Rows[0]["tipo"]));
            }
            banco.Disconnect();
            return t;
        }

        public List<object> getList(string op)
        {
            DataTable dt = new DataTable();
            List<object> list = new List<object>();
            Tipo_TransporteDB DB = new Tipo_TransporteDB();
            string SQL = @"SELECT * FROM Transportadora WHERE @op";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt, "@op", op);
            if (dt.Rows.Count > 0)
            {
                Transportadora t;
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    t = new Transportadora((int)dt.Rows[0]["id"],
                                                dt.Rows[0]["nome"].ToString(),
                                        (double)dt.Rows[0]["valor"],
                                           (int)dt.Rows[0]["max_carga"],
                                                dt.Rows[0]["endereco"].ToString(),
                                                dt.Rows[0]["contato"].ToString(),
                                                dt.Rows[0]["telefone"].ToString(),
                                                dt.Rows[0]["email"].ToString(),
                                                dt.Rows[0]["cnpj"].ToString(),
                                    DB.get((int)dt.Rows[0]["tipo"]));
                    list.Add(t);
                }
            }
            banco.Disconnect();
            return list;
        }

        public List<object> getAll()
        {
            DataTable dt = new DataTable();
            List<object> list = new List<object>();
            Tipo_TransporteDB DB = new Tipo_TransporteDB();
            string SQL = @"SELECT * FROM Transportadora ORDER BY id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Transportadora t;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    t = new Transportadora((int)dt.Rows[0]["id"],
                                                dt.Rows[0]["nome"].ToString(),
                                        (double)dt.Rows[0]["valor"],
                                           (int)dt.Rows[0]["max_carga"],
                                                dt.Rows[0]["endereco"].ToString(),
                                                dt.Rows[0]["contato"].ToString(),
                                                dt.Rows[0]["telefone"].ToString(),
                                                dt.Rows[0]["email"].ToString(),
                                                dt.Rows[0]["cnpj"].ToString(),
                                    DB.get((int)dt.Rows[0]["tipo"]));
                    list.Add(t);
                }
            }
            banco.Disconnect();
            return list;
        }
    }
}
