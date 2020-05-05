using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GlobalHost.Controlador
{
    class Controle_TipoCarga
    {
        //Tipo_Carga
        public static bool insert(string descricao, double peso, string dimsensoes)
        {
            Tipo_Carga tc = new Tipo_Carga(descricao, peso, dimsensoes);
            Tipo_CargaDB DB = new Tipo_CargaDB();
            return DB.Insert(tc);
        }

        public static bool delete(int id)
        {
            Tipo_CargaDB DB = new Tipo_CargaDB();
            return DB.Delete(id);
        }

        public static bool update(int id, string desc, double peso, string dim)
        {
            Tipo_Carga tc = new Tipo_Carga(id, desc, peso, dim);
            Tipo_CargaDB DB = new Tipo_CargaDB();
            return DB.Update(tc);
        }

        public static DataTable get(object obj)
        {
            Tipo_CargaDB DB = new Tipo_CargaDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Tipo_Carga tc = DB.get((int)obj);
                list.Add(tc);
            }
            else if (obj.GetType() == typeof(string))
            {
                if (((string)obj).Length > 0)
                    list = DB.getList((string)obj);
                else
                    list = DB.getAll();
            }
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("descricao", typeof(string));
            table.Columns.Add("peso", typeof(double));
            table.Columns.Add("dimensoes", typeof(string));
            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Tipo_Transporte aux = (Tipo_Transporte)item;
                linha["id"] = aux.Id;
                linha["descricao"] = aux.Descricao;
                linha["peso"] = aux.Max_peso;
                linha["dimensoes"] = aux.Dimensoes;
                table.Rows.Add(linha);
            }
            return table;
        }
    }
}
