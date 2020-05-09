using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Controlador
{
    class Controle_Parametro
    {
        //Parametrização
        public static Parametros get()
        {
            ParametrosDB DB = new ParametrosDB();
            Parametros P = DB.get();
            return P;
        }

        public static bool update(string nome, string razao, string cnpj, DateTime data, string endereco, string email, string site, string atividade, string status, string telefone, Image logo)
        {
            ParametrosDB DB = new ParametrosDB();
            Parametros p = new Parametros(nome, razao, cnpj, data, endereco, email, site, atividade, status, telefone, logo);
            return DB.Update(p);
        }

        public static Image getLogo()
        {
            ParametrosDB DB = new ParametrosDB();
            Parametros P = DB.get();
            return P.Logo;
        }
    }
}
