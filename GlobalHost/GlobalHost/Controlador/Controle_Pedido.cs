﻿using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Controlador
{
    class Controle_Pedido
    {
        public static bool Insert(DateTime data, string mod, string orig, string dest, string desp, string sit, int cli, int fun, int rem)
        {
            FuncionarioDB funcionarios = new FuncionarioDB();
            ClienteDB clientes = new ClienteDB();
            PedidoDB pedidos = new PedidoDB();
            Funcionario f = funcionarios.get(fun);
            Cliente c = clientes.get(cli);
            Remessa r = null;                       /// Necessita da RemessaDB  <author>@campos</author>
            Pedido p = new Pedido(data, mod, orig, dest, desp, sit, c, f, r);
            return pedidos.Insert(p);
        }

        public static bool Insert(DateTime data, string mod, string orig, string dest, string desp, string sit, int cli, int fun)
        {
            FuncionarioDB funcionarios = new FuncionarioDB();
            ClienteDB clientes = new ClienteDB();
            PedidoDB pedidos = new PedidoDB();
            Funcionario f = funcionarios.get(fun);
            Cliente c = clientes.get(cli);
            Pedido p = new Pedido(data, mod, orig, dest, desp, sit, c, f);
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
            Pedido p = new Pedido(data, mod, orig, dest, desp, sit, c, f, r);
            return pedidos.Update(p);

        }

        public static bool Update(DateTime data, string mod, string orig, string dest, string desp, string sit, int cli, int fun)
        {
            FuncionarioDB funcionarios = new FuncionarioDB();
            ClienteDB clientes = new ClienteDB();
            PedidoDB pedidos = new PedidoDB();
            Funcionario f = funcionarios.get(fun);
            Cliente c = clientes.get(cli);
            Pedido p = new Pedido(data, mod, orig, dest, desp, sit, c, f);
            return pedidos.Update(p);
        }

        public static int getMaxID()
        {
            DataTable dt = get("");
            return Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["id"]);
        }

        public static DataTable get(object obj)
        {
            PedidoDB db = new PedidoDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if(obj.GetType() == typeof(int))
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
                table.Rows.Add(linha);
            }
            return table;
        }
    }
}
