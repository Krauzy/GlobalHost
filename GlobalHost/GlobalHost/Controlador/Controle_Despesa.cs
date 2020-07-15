using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Controlador
{
    class Controle_Despesa
    {

        public bool insert(string desc, string tipo, string estado)
        {
            DespesaDB db = new DespesaDB();
            Despesa d = new Despesa(desc, tipo,estado);
            return db.Insert(d);
        }

        public bool delete(int id)
        {
            DespesaDB db = new DespesaDB();
            return db.Delete(id);
        }

        public bool update(int id, string desc, string tipo, string estado)
        {
            DespesaDB db = new DespesaDB();
            Despesa c = new Despesa(id, desc, tipo, estado);
            return db.Update(c);
        }
        public DataTable get(object obj)
        {
            DespesaDB DB = new DespesaDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Despesa d = DB.get((int)obj);
                list.Add(d);
            }
            else
                list = DB.getAll();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("descricao", typeof(string));
            table.Columns.Add("tipo", typeof(string));
            table.Columns.Add("estado", typeof(string));
            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Despesa aux = (Despesa)item;
                linha["id"] = aux.Id;
                linha["descricao"] = aux.Descricao;
                linha["tipo"] = aux.Tipo;
                linha["estado"] = aux.Estado;
                table.Rows.Add(linha);
            }
            return table;
        }
        public DataTable getNotPagas()
        {
            DespesaDB DB = new DespesaDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            list = DB.getNotPaga();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("descricao", typeof(string));
            table.Columns.Add("tipo", typeof(string));
            table.Columns.Add("estado", typeof(string));
            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Despesa aux = (Despesa)item;
                linha["id"] = aux.Id;
                linha["descricao"] = aux.Descricao;
                linha["tipo"] = aux.Tipo;
                linha["estado"] = aux.Estado;
                table.Rows.Add(linha);
            }
            return table;
        }

        public DataTable getByInterval(DateTime dt1, DateTime dt2)
        {
            DataTable dt = getNotPagas();
            Controle_ContasPagar ccp = new Controle_ContasPagar();
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("descricao", typeof(string));
            table.Columns.Add("tipo", typeof(string));
            table.Columns.Add("estado", typeof(string));
            foreach(DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                if (ccp.getFirstEmmited(id,dt1) && ccp.getLastToExpire(id,dt2))
                {
                    table.Rows.Add(row[0], row[1], row[2], row[3]);
                }
            }
            return table;
        }
        public void checkPaid(int desp)
        {
            DespesaDB db = new DespesaDB();
            Despesa d = db.get(desp);
            Controle_ContasPagar ccp = new Controle_ContasPagar() ;
            List<Contas_Pagar> l = ccp.getListaContas(desp);
            double soma = 0, somapago = 0;
            foreach(Contas_Pagar c in l)
            {
                soma += c.Valor;
                somapago += c.Pago;
            }
            if (soma != somapago) d.Estado = "PARCIALMENTE PAGO";
            else d.Estado = "PAGO";
            db.Update(d);
        }
        public int getIdentity()
        {
            DespesaDB DB = new DespesaDB();
            return DB.getIdentity();
        }
    }
}
