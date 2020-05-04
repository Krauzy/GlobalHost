using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GlobalHost.Controlador
{
    class ControleCliente
    {
        //Cliente
        public static bool insert(string nome, string endereco, DateTime dtnascimento, string cpf_cnpj, string cep, string email, string telefone)
        {
            ClienteDB db = new ClienteDB();
            Cliente c = new Cliente(nome, endereco, dtnascimento, cpf_cnpj, cep, email, telefone);
            return db.Insert(c);
        }

        public static bool delete(int id)
        {
            ClienteDB db = new ClienteDB();
            return db.Delete(id);
        }

        public static bool update(int id, string nome, string endereco, DateTime dtnascimento, string cpf_cnpj, string cep, string email, string telefone)
        {
            ClienteDB db = new ClienteDB();
            Cliente c = new Cliente(id, nome, endereco, dtnascimento, cpf_cnpj, cep, email, telefone);
            return db.Update(c);
        }

        public static DataTable get(object obj)
        {
            ClienteDB DB = new ClienteDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Cliente c = DB.get((int)obj);
                list.Add(c);
            }
            else if (obj.GetType() == typeof(string))
            {
                if (((string)obj).Length > 0)
                    list = DB.getList((string)obj);
                else
                    list = DB.getAll();
            }
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("nome", typeof(string));
            table.Columns.Add("endereco", typeof(string));
            table.Columns.Add("dtnascimento", typeof(DateTime));
            table.Columns.Add("cpf_cnpj", typeof(string));
            table.Columns.Add("cep", typeof(string));
            table.Columns.Add("email", typeof(string));
            table.Columns.Add("telefone", typeof(string));
            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Cliente aux = (Cliente)item;
                linha["id"] = aux.Id;
                linha["nome"] = aux.Nome;
                linha["endereco"] = aux.Endereco;
                linha["dtnascimento"] = aux.Dtnascimento;
                linha["cpf_cnpj"] = aux.Cpf_cnpj;
                linha["cep"] = aux.Cep;
                linha["email"] = aux.Email;
                linha["telefone"] = aux.Telefone;
                table.Rows.Add(linha);
            }
            return table;
        }
    }
}
