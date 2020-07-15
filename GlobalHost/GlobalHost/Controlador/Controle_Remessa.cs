using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Controlador
{
    class Controle_Remessa
    {
        public static bool insert(string descricao, string origem, string destino, DateTime saida, DateTime previsao, DateTime requerida, int transportadora)
        {
            RemessaDB DB = new RemessaDB();
            TransportadoraDB dbT = new TransportadoraDB();
            Remessa r = new Remessa(descricao, origem, destino, saida, previsao, requerida, dbT.get(transportadora));
            return DB.Insert(r);
        }

        public static bool update(int id, string descricao, string origem, string destino, DateTime saida, DateTime previsao, DateTime requerida, int transportadora)
        {
            RemessaDB DB = new RemessaDB();
            TransportadoraDB dbT = new TransportadoraDB();
            Remessa r = new Remessa(id, descricao, origem, destino, saida, previsao, requerida, dbT.get(transportadora));
            return DB.Update(r);
        }

        public static bool delete(int id)
        {
            PedidoDB pdb = new PedidoDB();
            pdb.UpdatePorRemessa(id);
            RemessaDB DB = new RemessaDB();
           
            return DB.Delete(id);
        }

        public static DataTable get(object obj)
        {
            RemessaDB DB = new RemessaDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Remessa r = DB.get((int)obj);
                list.Add(r);
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
            table.Columns.Add("origem", typeof(string));
            table.Columns.Add("destino", typeof(string));
            table.Columns.Add("data_saida", typeof(DateTime));
            table.Columns.Add("previsao_requerida", typeof(DateTime));
            table.Columns.Add("data_requerida", typeof(DateTime));
            table.Columns.Add("transportadora", typeof(Transportadora));

            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Remessa r = (Remessa)item;
                linha["id"] = r.Id;
                linha["descricao"] = r.Descricao;
                linha["origem"] = r.Origem;
                linha["destino"] = r.Origem;
                linha["data_saida"] = r.Saida;
                linha["previsao_requerida"] = r.Previsao;
                linha["data_requerida"] = r.Requerimento;
                linha["Transportadora"] = r.Transportadora;
                table.Rows.Add(linha);
            }


            return table;
        }

        public static int MAX()
        {
            RemessaDB db = new RemessaDB();
            return db.MAX();
        }
    }
}
