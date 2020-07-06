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
    class Controle_Pedido
    {

        public static bool Insert(DateTime data, string mod, string orig, string dest, string desp, string sit, int cli, int fun, int rem)
        {
            FuncionarioDB funcionarios = new FuncionarioDB();
            ClienteDB clientes = new ClienteDB();
            RemessaDB remessas = new RemessaDB();
            PedidoDB pedidos = new PedidoDB();
            Funcionario f = funcionarios.get(fun);
            Cliente c = clientes.get(cli);
            Remessa r = remessas.get(rem);
            Pedido p = new Pedido(data, mod, orig, dest, desp, sit, c, f, r, "Em espera");
            return pedidos.Insert(p);
        }

        public static bool Insert(DateTime data, string mod, string orig, string dest, string desp, string sit, int cli, int fun)
        {
            FuncionarioDB funcionarios = new FuncionarioDB();
            ClienteDB clientes = new ClienteDB();
            PedidoDB pedidos = new PedidoDB();
            Funcionario f = funcionarios.get(fun);
            Cliente c = clientes.get(cli);
            Pedido p = new Pedido(data, mod, orig, dest, desp, sit, c, f, "Em espera");
            return pedidos.Insert(p);
        }

        public static bool Delete(int id)
        {
            PedidoDB db = new PedidoDB();
            return db.Delete(id);
        }

        public static bool Update(DateTime data, string mod, string orig, string dest, string desp, string sit, int cli, int fun, int rem)
        {
            FuncionarioDB funcionarios = new FuncionarioDB();
            ClienteDB clientes = new ClienteDB();
            PedidoDB pedidos = new PedidoDB();
            Funcionario f = funcionarios.get(fun);
            Cliente c = clientes.get(cli);
            Remessa r = null;                       /// Necessita da RemessaDB  <author>@campos</author>
            Pedido p = new Pedido(data, mod, orig, dest, desp, sit, c, f, "Em espera");
            return pedidos.Update(p);

        }

        public static bool Update(int id, DateTime data, string mod, string orig, string dest, string desp, string sit, int cli, int fun)
        {
            FuncionarioDB funcionarios = new FuncionarioDB();
            ClienteDB clientes = new ClienteDB();
            PedidoDB pedidos = new PedidoDB();
            Funcionario f = funcionarios.get(fun);
            Cliente c = clientes.get(cli);
            Pedido p = new Pedido(id, data, mod, orig, dest, desp, sit, c, f, "Em espera");
            return pedidos.Update(p);
        }

        public static int MAX()
        {
            PedidoDB db = new PedidoDB();
            return db.MAX();
        }

        public static DataTable get(object obj)
        {
            PedidoDB db = new PedidoDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Pedido p = db.get((int)obj);
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
            table.Columns.Add("data", typeof(DateTime));
            table.Columns.Add("modalidade", typeof(string));
            table.Columns.Add("origem", typeof(string));
            table.Columns.Add("destino", typeof(string));
            table.Columns.Add("despachante", typeof(string));
            table.Columns.Add("situacao", typeof(string));
            table.Columns.Add("cliente", typeof(Cliente));
            table.Columns.Add("funcionario", typeof(Funcionario));
            table.Columns.Add("remessa", typeof(Remessa));
            table.Columns.Add("autorizacao", typeof(string));
            list.Remove(null);
            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Pedido p = (Pedido)item;
                linha["id"] = p.Id;
                linha["data"] = p.Data;
                linha["modalidade"] = p.Modalidade;
                linha["origem"] = p.Origem;
                linha["destino"] = p.Destino;
                linha["despachante"] = p.Despachante;
                linha["situacao"] = p.Situacao;
                linha["cliente"] = p.Cliente;
                linha["funcionario"] = p.Funcionario;
                linha["remessa"] = p.Remessa;
                linha["autorizacao"] = p.Autorizacao;
                table.Rows.Add(linha);
            }
            return table;
        }

        public static bool UpdateByRemessa(int ID, int Remessa)
        {
            PedidoDB db = new PedidoDB();
            Pedido P = db.get(ID);
            RemessaDB dbR = new RemessaDB();
            Remessa R = dbR.get(Remessa);
            P.Remessa = R;
            return db.Update(P);
        }

        public static bool UpdateSituacao(int ID, string situacao)
        {
            PedidoDB db = new PedidoDB();
            Pedido P = db.get(ID);
            P.Situacao = situacao;
            return db.Update(P);
        }

        public static void Reverse()
        {
            Banco banco = new Banco();
            banco.RollbackTransaction();
        }
    }
}
