using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System.Collections.Generic;
using System.Data;

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

        public static bool Insere_Tipo_Transporte(string desc, double peso, string dim)
        {
            Tipo_Transporte tt = new Tipo_Transporte(desc, peso, dim);
            Tipo_TransporteDB DB = new Tipo_TransporteDB();
            return DB.Insert(tt);
        }

        public static bool Remove_Tipo_Transporte(int id)
        {
            Tipo_TransporteDB DB = new Tipo_TransporteDB();
            return DB.Delete(id);
        }

        public static bool Altera_Tipo_Transporte(int id, string desc, double peso, string dim)
        {
            Tipo_Transporte tt = new Tipo_Transporte(id, desc, peso, dim);
            Tipo_TransporteDB DB = new Tipo_TransporteDB();
            return DB.Update(tt);
        }

        public static DataTable getTipo_Transporte(object obj)
        {
            Tipo_TransporteDB DB = new Tipo_TransporteDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Tipo_Transporte tt = DB.get((int)obj);
                list.Add(tt);
            }
            else if(obj.GetType() == typeof(string))
            {
                if (((string)obj).Length > 0)
                    list = DB.getList((string)obj);
                else
                    list = DB.getAll();
            }
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("descricao", typeof(string));
            table.Columns.Add("max_peso", typeof(double));
            table.Columns.Add("dimensoes", typeof(string));
            foreach(var item in list)
            {
                DataRow linha = table.NewRow();
                Tipo_Transporte aux = (Tipo_Transporte)item;
                linha["id"] = aux.Id;
                linha["descricao"] = aux.Descricao;
                linha["max_peso"] = aux.Max_peso;
                linha["dimensoes"] = aux.Dimensoes;
                table.Rows.Add(linha);
            }
            return table;
        }
    }
}
