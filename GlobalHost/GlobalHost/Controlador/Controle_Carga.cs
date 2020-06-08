using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalHost.Controlador
{
    class Controle_Carga
    {
        public static bool Insert (string descricao, int volume, double peso, string dim, double vu, double vt, string tipo, int pedido)
        {
            CargaDB db = new CargaDB();
            Tipo_CargaDB tipos = new Tipo_CargaDB();
            PedidoDB pedDB = new PedidoDB();
            Tipo_Carga tc = tipos.get(tipo);
            return db.Insert(new Carga(descricao, volume, peso, dim, vu, vt, tc, pedDB.get(pedido)));
        }

        public static bool Delete (int id)
        {
            CargaDB cargas = new CargaDB();
            return cargas.Delete(id);
        }

        public static bool DeleteByPedido(int id)
        {
            CargaDB db = new CargaDB();
            return db.DeleteByPedido(id);
        }

        public static bool Update(string descricao, int volume, double peso, string dim, double vu, double vt, string tipo, int pedido)
        {
            CargaDB db = new CargaDB();
            Tipo_CargaDB tipos = new Tipo_CargaDB();
            PedidoDB pedDB = new PedidoDB();
            Tipo_Carga tc = (Tipo_Carga)tipos.getList("tipo LIKE '%" + tipo + "%'")[0];
            return db.Update(new Carga(descricao, volume, peso, dim, vu, vt, tc, pedDB.get(pedido)));
        }

        public static DataTable get(object obj)
        {
            CargaDB db = new CargaDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Carga p = db.get((int)obj);
                list.Add(p);
            }
            else if (obj.GetType() == typeof(string))
            {
                if (((string)obj).Length > 0)
                    list = db.getList((string)obj);
                else
                    list = db.getAll();
            }
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("descricao", typeof(string));
            table.Columns.Add("volume", typeof(int));
            table.Columns.Add("peso", typeof(double));
            table.Columns.Add("dimensoes", typeof(string));
            table.Columns.Add("valor_unitario", typeof(double));
            table.Columns.Add("valor", typeof(double));
            table.Columns.Add("tipo", typeof(string));
            table.Columns.Add("pedido", typeof(Pedido));
            list.Remove(null);
            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Carga c = (Carga)item;
                linha["id"] = c.Id;
                linha["descricao"] = c.Descricao;
                linha["volume"] = c.Volume;
                linha["peso"] = c.Peso;
                linha["dimensoes"] = c.Dimensoes;
                linha["valor_unitario"] = c.Valor_Unitario;
                linha["valor"] = c.Valor;
                linha["tipo"] = c.Tipo.Descricao;
                linha["pedido"] = c.Pedido;
                table.Rows.Add(linha);
            }
            return table;
        }
    }
}
