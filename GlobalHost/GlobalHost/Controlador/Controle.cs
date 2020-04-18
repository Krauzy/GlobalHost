using GlobalHost.Modelo;
using GlobalHost.Persistencia;

namespace GlobalHost.Controlador
{
    class Controle
    {
        public static Parametros getParametro()
        {
            ParametrosDB DB = new ParametrosDB();
            Parametros P = DB.get();
            return P;
        }
    }
}
