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
    class Controle_Transportadora
    {
        //Transportadora
        public static bool insert(string nome, double valor, int max_carga, string endereco, string contato, string telefone, string email, string cnpj, int tipo)
        {
            DataTable dt = Controle_TipoTransporte.get(tipo);
            Tipo_Transporte tt = new Tipo_Transporte((int)dt.Rows[0]["id"], dt.Rows[0]["descricao"].ToString(),
                (double)dt.Rows[0]["max_peso"], dt.Rows[0]["dimensoes"].ToString());
            Transportadora t = new Transportadora(nome, valor, max_carga, endereco, contato, telefone, email, cnpj, tt);
            TransportadoraDB DB = new TransportadoraDB();
            return DB.Insert(t);
        }

        public static bool delete(int id)
        {
            TransportadoraDB DB = new TransportadoraDB();
            return DB.Delete(id);
        }

        public static bool update(int id, string nome, double valor, int max_carga, string endereco, string contato, string telefone, string email, string cnpj, int tipo)
        {
            DataTable dt = Controle_TipoTransporte.get(tipo);
            Tipo_Transporte tt = new Tipo_Transporte((int)dt.Rows[0]["id"], dt.Rows[0]["descricao"].ToString(),
                (double)dt.Rows[0]["max_peso"], dt.Rows[0]["dimensoes"].ToString());
            Transportadora t = new Transportadora(id, nome, valor, max_carga, endereco, contato, telefone, email, cnpj, tt);
            TransportadoraDB DB = new TransportadoraDB();
            return DB.Update(t);
        }

        public static DataTable get(object obj)
        {
            TransportadoraDB DB = new TransportadoraDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Transportadora t = DB.get((int)obj);
                list.Add(t);
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
            table.Columns.Add("valor", typeof(double));
            table.Columns.Add("max_carga", typeof(int));
            table.Columns.Add("endereco", typeof(string));
            table.Columns.Add("contato", typeof(string));
            table.Columns.Add("telefone", typeof(string));
            table.Columns.Add("email", typeof(string));
            table.Columns.Add("cnpj", typeof(string));
            table.Columns.Add("tipo", typeof(Tipo_Transporte));
            list.Remove(null);
            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Transportadora t = (Transportadora)item;
                linha["id"] = t.Id;
                linha["nome"] = t.Nome;
                linha["valor"] = t.Valor;
                linha["max_carga"] = t.Max_carga;
                linha["endereco"] = t.Endereco;
                linha["contato"] = t.Contato;
                linha["telefone"] = t.Telefone;
                linha["email"] = t.Email;
                linha["cnpj"] = t.Cnpj;
                linha["tipo"] = t.Tipo;
                table.Rows.Add(linha);
            }
            return table;
        }
    }
}
