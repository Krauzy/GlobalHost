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
    class Controle_Funcionario
    {

        public static bool insert (string nome, DateTime dtnascimento, string cpf, double salario, string endereco, DateTime dtadmissao, DateTime dtdemissao, string telefone, string email, string login, string senha, int nivel)
        {
            Login l = new Login(login, senha, nivel);
            LoginDB dblog = new LoginDB();
            if (dblog.Insert(l))
            {
                Banco banco = new Banco();
                banco.Connect();
                int n = banco.GetIdentity();
                l.Id = n;
                banco.Disconnect();
                Funcionario f = new Funcionario(nome, dtnascimento, cpf, salario, endereco, dtadmissao, dtdemissao, telefone, email, l);
                FuncionarioDB DB = new FuncionarioDB();
                return DB.Insert(f);
            }
            else
                return false;
        }

        public static bool update(int id, string nome, DateTime dtnascimento, string cpf, double salario, string endereco, DateTime dtadmissao, DateTime dtdemissao, string telefone, string email, string login, string senha, int nivel)
        {
            Login l = new Login(login, senha, nivel);
            Funcionario f = new Funcionario(id,nome, dtnascimento, cpf, salario, endereco, dtadmissao, dtdemissao, telefone, email, l);
            FuncionarioDB DB = new FuncionarioDB();
            return DB.Update(f);
        }

        public static bool delete(int id)
        {
            FuncionarioDB DB = new FuncionarioDB();
            LoginDB dblog = new LoginDB();
            return dblog.Delete(DB.get(id).Login.Id);
        }

        public static DataTable get (object obj)
        {
            FuncionarioDB DB = new FuncionarioDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if(obj.GetType() == typeof(int))
            {
                Funcionario f = DB.get((int)obj);
                list.Add(f);
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
            table.Columns.Add("dtnascimento", typeof(DateTime));
            table.Columns.Add("cpf", typeof(string));
            table.Columns.Add("salario", typeof(double));
            table.Columns.Add("endereco", typeof(string));
            table.Columns.Add("dtadmissao", typeof(DateTime));
            table.Columns.Add("dtdemissao", typeof(DateTime));
            table.Columns.Add("telefone", typeof(string));
            table.Columns.Add("email", typeof(string));
            table.Columns.Add("login", typeof(Login));

            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Funcionario f = (Funcionario)item;
                linha["id"] = f.Id;
                linha["nome"] = f.Nome;
                linha["dtnascimento"] = f.Dtnascimento;
                linha["cpf"] = f.Cpf;
                linha["salario"] = f.Salario;
                linha["endereco"] = f.Endereco;
                linha["dtadmissao"] = f.Dtadmissao;
                linha["dtdemissao"] = f.Dtdemissao;
                linha["telefone"] = f.Telefone;
                linha["email"] = f.Email;
                linha["login"] = f.Login;
                table.Rows.Add(linha);
            }


            return table;
        }
        

    }
}
