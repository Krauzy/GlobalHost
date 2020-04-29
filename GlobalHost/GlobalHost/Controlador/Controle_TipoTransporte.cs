using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GlobalHost.Controlador
{
    class Controle_TipoTransporte
    {
        //Tipo_Transporte
        public static bool insert(string desc, double peso, string dim)
        {
            Tipo_Transporte tt = new Tipo_Transporte(desc, peso, dim);
            Tipo_TransporteDB DB = new Tipo_TransporteDB();
            return DB.Insert(tt);
        }

        public static bool delete(int id)
        {
            Tipo_TransporteDB DB = new Tipo_TransporteDB();
            if (Controle_Transportadora.get("tipo = " + id).Rows.Count > 0)
            {
                MessageBox.Show("Não é possível excluir " + get(id).Rows[0]["descricao"].ToString() + " pois existe um objeto detendo a chave primária desse registro", "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return true;
            }
            return DB.Delete(id);
        }

        public static bool update(int id, string desc, double peso, string dim)
        {
            Tipo_Transporte tt = new Tipo_Transporte(id, desc, peso, dim);
            Tipo_TransporteDB DB = new Tipo_TransporteDB();
            return DB.Update(tt);
        }

        public static DataTable get(object obj)
        {
            Tipo_TransporteDB DB = new Tipo_TransporteDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Tipo_Transporte tt = DB.get((int)obj);
                list.Add(tt);
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
            table.Columns.Add("max_peso", typeof(double));
            table.Columns.Add("dimensoes", typeof(string));
            foreach (var item in list)
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
