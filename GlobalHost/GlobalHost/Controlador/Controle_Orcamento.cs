using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;

namespace GlobalHost.Controlador
{
    class Controle_Orcamento
    {
        public static bool Insert (double valor, DateTime data, DateTime vencimento, int pedido, int transportadora)
        {
            OrcamentoDB DB = new OrcamentoDB();
            TransportadoraDB DBT = new TransportadoraDB();
            PedidoDB DBP = new PedidoDB();
            Orcamento orc = new Orcamento(valor, data, vencimento, DBP.get(pedido), DBT.get(transportadora));
            return DB.Insert(orc);
        }

        public static bool Update (int id, double valor, DateTime data, DateTime vencimento, int pedido, int transportadora)
        {
            OrcamentoDB DB = new OrcamentoDB();
            TransportadoraDB DBT = new TransportadoraDB();
            PedidoDB DBP = new PedidoDB();
            Orcamento orc = new Orcamento(id, valor, data, vencimento, DBP.get(pedido), DBT.get(transportadora));
            return DB.Update(orc);
        }

        public static bool Delete (int id)
        {
            OrcamentoDB DB = new OrcamentoDB();
            return DB.Delete(id);
        }

        public static DataTable get (object obj)
        {
            OrcamentoDB DB = new OrcamentoDB(); DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Orcamento o = DB.get((int)obj);
                list.Add(o);
            }
            else if (obj.GetType() == typeof(string))
            {
                if (((string)obj).Length > 0)
                    list = DB.getList((string)obj);
                else
                    list = DB.getAll();
            }
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("valor", typeof(double));
            table.Columns.Add("data", typeof(DateTime));
            table.Columns.Add("validade", typeof(DateTime));
            table.Columns.Add("pedido", typeof(Pedido));
            table.Columns.Add("Transportadora", typeof(Transportadora));
            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Orcamento orc = (Orcamento)item;
                linha["id"] = orc.Id;
                linha["valor"] = orc.Valor;
                linha["data"] = orc.Data;
                linha["validade"] = orc.Vencimento;
                linha["pedido"] = orc.Pedido;
                linha["transportadora"] = orc.Transportadora;
                table.Rows.Add(linha);
            }
            return table;
        }
    }
}
