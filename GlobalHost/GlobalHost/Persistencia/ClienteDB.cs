using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Persistencia
{
    class ClienteDB
    {
        private readonly Banco banco;

        public ClienteDB()
        {
            banco = new Banco();
        }
        public bool Insert(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Login))
            {
                Login log = (Login)obj;
                string SQL = @"INSERT INTO Cliente (usuario, senha) VALUES (@nome, @senha)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@usuario", log.Usuario, "@senha", log.Senha);
                banco.Disconnect();
            }
            return result;
        }
        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Cliente WHERE id = @id";
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL, "@id", id);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Login))
            {
                Login log = (Login)obj;
                string SQL = @"UPDATE Cliente SET usuario = @usuario, senha = @senha";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@usuario", log.Usuario, "@senha",log.Senha);
            }
            return result;
        }
        public Cliente get(int id)
        {
            DataTable dt = new DataTable();
            Cliente c = null;
            string SQL = @"SELECT * FROM Cliente WHERE id = @id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt, "@id", id);
            if (dt.Rows.Count > 0)
            {
                c = new Cliente((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["nome"].ToString(),
                                    dt.Rows[0]["endereco"].ToString(),
                                    DateTime.Parse(dt.Rows[0]["dtnascimento"].ToString()),
                                    dt.Rows[0]["cpf_cnpj"].ToString(),
                                    dt.Rows[0]["cep"].ToString(),
                                    dt.Rows[0]["email"].ToString(),
                                    dt.Rows[0]["telefone"].ToString()
                                    );
            }
            banco.Disconnect();
            return c;
        }
        
        public List<object> getList(string nome)
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Cliente WHERE nome like  %" + nome + "% ORDER BY id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Cliente c;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    c = new Cliente((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["nome"].ToString(),
                                    dt.Rows[0]["endereco"].ToString(),
                                    DateTime.Parse(dt.Rows[0]["dtnascimento"].ToString()),
                                    dt.Rows[0]["cpf_cnpj"].ToString(),
                                    dt.Rows[0]["cep"].ToString(),
                                    dt.Rows[0]["email"].ToString(),
                                    dt.Rows[0]["telefone"].ToString()
                                    );
                    list.Add(c);
                }
            }
            banco.Disconnect();
            return list;
        }
        public List<object> getAll()
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Cliente";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Cliente c;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    c = new Cliente((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["nome"].ToString(),
                                    dt.Rows[0]["endereco"].ToString(),
                                    DateTime.Parse(dt.Rows[0]["dtnascimento"].ToString()),
                                    dt.Rows[0]["cpf_cnpj"].ToString(),
                                    dt.Rows[0]["cep"].ToString(),
                                    dt.Rows[0]["email"].ToString(),
                                    dt.Rows[0]["telefone"].ToString()
                                    );
                    list.Add(c);
                }
            }
            banco.Disconnect();
            return list;
        }
    }
}
