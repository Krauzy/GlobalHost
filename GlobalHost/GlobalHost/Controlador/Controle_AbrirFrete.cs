using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Controlador
{
    class Controle_AbrirFrete
    {

        public static bool insert (double total, string situacao, int orcamento, int remessa)
        {
            AbrirFreteDB afdb = new AbrirFreteDB();
            RemessaDB rdb = new RemessaDB();
            OrcamentoDB odb = new OrcamentoDB();
            Frete f = new Frete(total, situacao, odb.get(orcamento), rdb.get(remessa));
            return afdb.Insert(f);
        }

        public static bool update(int id, double total, string situacao, int orcamento, int remessa)
        {
            AbrirFreteDB afdb = new AbrirFreteDB();
            RemessaDB rdb = new RemessaDB();
            OrcamentoDB odb = new OrcamentoDB();
            Frete f = new Frete(total, situacao, odb.get(orcamento), rdb.get(remessa));
            return afdb.Update(f);
        }
        
        public static bool delete(int id)
        {
            AbrirFreteDB afdb = new AbrirFreteDB();
            return afdb.Delete(id);
        }

        public static DataTable get(object obj)
        {
            AbrirFreteDB afdb = new AbrirFreteDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Frete f = afdb.get((int)obj);
                list.Add(f);
            }
            else if (obj.GetType() == typeof(string))
            {
                if (((string)obj).Length > 0)
                    list = afdb.getList((string)obj);
                else
                    list = afdb.getAll();
            }

            table.Columns.Add("id", typeof(int));
            table.Columns.Add("total", typeof(double));
            table.Columns.Add("situacao", typeof(string));
            table.Columns.Add("orcamento", typeof(Orcamento));
            table.Columns.Add("remessa", typeof(Remessa));

            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Frete f = (Frete)item;
                linha["id"] = f.Id;
                linha["total"] = f.Total;
                linha["situacao"] = f.Situacao;
                linha["orcamento"] = f.Orcamento;
                linha["remessa"] = f.Remessa;
                table.Rows.Add(linha);
            }


            return table;
        }

        public static int MAX()
        {
            AbrirFreteDB afdb = new AbrirFreteDB();
            return afdb.MAX();
        }
    }

}

