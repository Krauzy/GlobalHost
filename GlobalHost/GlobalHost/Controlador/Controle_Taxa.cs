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
    class Controle_Taxa
    {
        public static bool Insert (string descricao, double valor, int orcamento)
        {
            OrcamentoDB DBO = new OrcamentoDB();
            TaxaDB DB = new TaxaDB();
            Taxa taxa = new Taxa(descricao, valor, DBO.get(orcamento));
            return DB.Insert(taxa);
        }

        public static bool Delete (int id)
        {
            TaxaDB DB = new TaxaDB();
            return DB.Delete(id);
        }

        public static bool Update (int id, string descricao, double valor, int orcamento)
        {
            OrcamentoDB DBO = new OrcamentoDB();
            TaxaDB DB = new TaxaDB();
            Taxa taxa = new Taxa(id, descricao, valor, DBO.get(orcamento));
            return DB.Update(taxa);
        }

        public static DataTable get(object obj)
        {
            TaxaDB DB = new TaxaDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Taxa taxa = DB.get((int)obj);
                list.Add(taxa);
            }
            else if (obj.GetType() == typeof(string))
            {
                if (((string)obj).Length > 0)
                {
                    list = DB.getList(obj.ToString());
                }
                else
                    list = DB.getAll();
            }
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("descricao", typeof(string));
            table.Columns.Add("valor", typeof(double));
            table.Columns.Add("orcamento", typeof(Orcamento));
            foreach(var item in list)
            {
                DataRow linha = table.NewRow();
                Taxa taxa = (Taxa)item;
                linha["id"] = taxa.Id;
                linha["descricao"] = taxa.Descricao;
                linha["valor"] = taxa.Valor;
                linha["orcamento"] = taxa.Orcamento;
                table.Rows.Add(linha);
            }
            return table;
        }
    }
}
