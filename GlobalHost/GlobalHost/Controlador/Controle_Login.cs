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
            FuncionarioDB DB = new FuncionarioDB();
            return DB.Delete(id);
        }

    }
}
