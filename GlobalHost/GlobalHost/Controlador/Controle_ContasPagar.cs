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
    class Controle_ContasPagar
    {
        public static bool insert(double valor, string tipo, string situacao, int frete, int despesa)
        {
            ContaAPagarDB db = new ContaAPagarDB();
            ContaAPagar c = new ContaAPagar(valor, tipo, situacao, frete, despesa);
            return db.Insert(c);
        }

        public static bool delete(int id)
        {
            ContaAPagarDB db = new ContaAPagarDB();
            return db.Delete(id);
        }

        public static bool update(double valor, string tipo, string situacao, int frete, int despesa)
        {
            ContaAPagarDB db = new ContaAPagarDB();
            ContaAPagar c = new ContaAPagar(valor, tipo, situacao, frete, despesa);
            return db.Update(c);
        }

        public static DataTable get(object obj)
        {
            ContaAPagarDB db = new ContaAPagarDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                ContaAPagar c = db.get((int)obj);
                list.Add(c);
            }
            else if (obj.GetType() == typeof(string))
            {
                if (((string)obj).Length > 0)
                    list = db.get((string)obj);
                else
                    list = db.getAll();
            }
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("valor", typeof(Double));
            table.Columns.Add("situacao", typeof(string));
            table.Columns.Add("frete", typeof(int));
            table.Columns.Add("despesa", typeof(int));
            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                ContaAPagar aux = (ContaAPagar)item;
                linha["id"] = aux.Id;
                linha["valor"] = aux.Valor;
                linha["situacao"] = aux.Situacao;
                linha["frete"] = aux.Frete;
                linha["despesa"] = aux.Despesa;
                table.Rows.Add(linha);
            }
            return table;
        }
    }
}
