using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalHost.Controlador
{
    class Controle_ContasPagar
    {
        public bool insert(double valor, string tipo, string situacao, int frete, int despesa)
        {
            ContasPagarDB db = new ContasPagarDB();
            Contas_Pagar c = new Contas_Pagar(valor, tipo, situacao,frete,despesa);
            return db.Insert(c);
        }

        public bool delete(int id)
        {
            ContasPagarDB db = new ContasPagarDB();
            return db.Delete(id);
        }

        public bool update(int id,double valor,string tipo, string situacao, int frete, int despesa)
        {
            ContasPagarDB db = new ContasPagarDB();
            Contas_Pagar c = new Contas_Pagar(id, valor, tipo, situacao, frete,despesa);
            return db.Update(c);
        }
        public DataTable get(object obj)
        {
            ContasPagarDB DB = new ContasPagarDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Contas_Pagar d = DB.get((int)obj);
                list.Add(d);
            }
            else
                list = DB.getAll();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("valor", typeof(string));
            table.Columns.Add("tipo", typeof(string));
            table.Columns.Add("situacao", typeof(string));
            table.Columns.Add("frete", typeof(int));
            table.Columns.Add("despesa", typeof(int));
            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Contas_Pagar aux = (Contas_Pagar)item;
                linha["id"] = aux.ID;
                linha["valor"] = aux.Valor;
                linha["tipo"] = aux.Tipo;
                linha["situacao"] = aux.Situacao;
                linha["frete"] = aux.Frete;
                linha["despesa"] = aux.Despesa;
                table.Rows.Add(linha);
            }
            return table;
        }
        public List<object> getListaContas(int despesa)
        {
            ContasPagarDB db = new ContasPagarDB();
            List<object> l = db.getFromDespesa(despesa);
            //for(int i = 0; i < 10; i++)
            //{
            //    Contas_Pagar c = new Contas_Pagar(i, 50,"DÍVIDA DO AGIOTA", "PENDENTE");
            //}
            return l;
        }

        public bool updateAll(ListBox.ObjectCollection items,String v)
        {
            //trocar pra datasource dps
            bool res = false;
            Double valor = Double.Parse(v);
            ContasPagarDB db = new ContasPagarDB();
            int tam = items.Count;
            foreach (object o in items)
            {
                Contas_Pagar c = (Contas_Pagar)o;
                c.Valor -= valor / tam;
                valor -= valor / tam;
                if (c.Valor == 0)
                    c.Situacao = "PAGO";
                else
                {
                    c.Situacao = "PARCIALMENTE PAGO";
                    //gerar nova com novo valor
                }
                res = db.Update(c);
            }
            return res;
        }
    }
}
