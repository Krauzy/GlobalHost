using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Persistencia
{
    class LoginDB
    {
        private readonly Banco banco;

        public LoginDB()
        {
            banco = new Banco();
        }

        public bool Insert(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Login))
            {
                Login log = (Login)obj;
                string SQL = @"INSERT INTO Login (usuario, senha, nivel) VALUES (@usuario, @senha, @nivel)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@usuario", log.Usuario, "@senha", log.Senha, "@nivel", log.Nivel);
                banco.Disconnect();
            }
            return result;
        }

        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Login WHERE id = @id";
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
                string SQL = @"UPDATE Login SET usuario = @usuario, senha = @senha, nivel = @nivel WHERE id = " + log.Id;
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@usuario", log.Usuario, "@senha",log.Senha, "@nivel",log.Nivel);
            }
            return result;
        }

        public Login get(int id)
        {
            string SQL = @"SELECT * FROM Login WHERE id = " + id;
            DataTable dt = new DataTable();
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            banco.Disconnect();
            Login log = new Login();
            if(dt.Rows.Count > 0)
            {
                log = new Login((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["usuario"].ToString(),
                                    dt.Rows[0]["senha"].ToString(),
                                    (int)dt.Rows[0]["nivel"]);
            }
            return log;
        }

        public Login get(string user)
        {
            string SQL = @"SELECT * FROM Login WHERE usuario LIKE '%" + user + "%'";
            DataTable dt = new DataTable();
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            banco.Disconnect();
            Login log = new Login();
            if (dt.Rows.Count > 0)
            {
                log = new Login((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["usuario"].ToString(),
                                    dt.Rows[0]["senha"].ToString(),
                                    (int)dt.Rows[0]["nivel"]);
            }
            return log;
        }

        public bool check(string user, string pass)
        {           
            string SQL = @"SELECT * FROM Login WHERE usuario = @user and senha = @pass";
            DataTable dt = new DataTable();
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt, "@user", user, "@pass", pass);
            banco.Disconnect();
            return dt.Rows.Count > 0;
        }

        public int getId()
        {
            string SQL = @"SELECT id FROM Login GROUP BY id HAVING MAX(id) = id";
            DataTable dt = new DataTable();
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            banco.Disconnect();
            return (int)dt.Rows[dt.Rows.Count - 1]["id"];
        }
    }
}
