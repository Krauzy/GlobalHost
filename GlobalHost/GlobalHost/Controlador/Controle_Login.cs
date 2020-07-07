using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Controlador
{
    class Controle_Login
    {

        public static bool insert (string usuario, string senha, int nivel)
        {
            Login log = new Login(usuario,senha,nivel);
            LoginDB DB = new LoginDB();
            return DB.Insert(log);
        }

        public static bool update(string usuario, string senha, int nivel)
        {
            LoginDB DB = new LoginDB();
            if (DB.check(usuario, senha))
            {
                Login log = new Login(usuario, senha, nivel);
                return DB.Update(log);
            }
            else
                return false;
        
        }

        public static bool delete(int id)
        {
            LoginDB DB = new LoginDB();
            return DB.Delete(id);
        }

        public static bool check(string login, string senha)
        {
            LoginDB DB = new LoginDB();
            return DB.check(login, senha);
        }

        public static int get(string user)
        {
            LoginDB DB = new LoginDB();
            Login l = DB.get(user);
            return l.Id;
        }

        public static bool isAdmin(int id)
        {
            LoginDB db = new LoginDB();
            Login l = db.get(id);
            return l.Nivel == 1;
        }

        public static Login get(int id)
        {
            LoginDB DB = new LoginDB();
            Login l = DB.get(id);
            return l;
        }
    }
}
