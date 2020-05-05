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
                string SQL = @"INSERT INTO Login (usuario, senha) VALUES (@usuario, @senha)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@usuario", log.Usuario, "@senha", log.Senha);
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
                string SQL = @"UPDATE Login SET usuario = @usuario, senha = @senha";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@usuario", log.Usuario, "@senha",log.Senha);
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
                                    dt.Rows[0]["senha"].ToString());
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
    }
}
