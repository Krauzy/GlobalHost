using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Persistencia
{
    class FuncionarioDB
    {
        private readonly Banco banco;

        public FuncionarioDB()
        {
            banco = new Banco();
        }


        public bool Insert (object obj)
        {
            bool result = false;

            if(obj.GetType() == typeof(Funcionario))
            {
                Funcionario fun = (Funcionario)obj;
                string SQL = @"INSERT INTO Funcionario(nome, dtnascimento, cpf, salario, endereco, dtadmissao, dtdemissao, telefone, email, login) 
                             VALUES (@nome, @dtnascimento, @cpf, @salario, @endereco, @dtadmissao, @dtdemissao, @telefone, @email, @login)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@nome", fun.Nome, "@dtnascimento", fun.Dtnascimento, "@cpf", fun.Cpf, "@salario", fun.Salario, "@endereco", fun.Endereco, "@dtadmissao", fun.Dtadmissao, "@dtdemissao", fun.Dtdemissao, "@telefone", fun.Telefone, "@email", fun.Email, "@login", fun.Login);
                banco.Disconnect();
            }
            return result;
        }

        public bool Delete (int id)
        {
            string SQL = @"DELETE FROM Funcionario where id = @id";
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL, "@id", id);
            banco.Disconnect();
            return result;
        }

        public bool Update (object obj)
        {
            bool result = false;
            if(obj.GetType() == typeof(Funcionario))
            {
                Funcionario fun = (Funcionario)obj;
                string SQL = @"UPDATE Funcionario SET nome = @nome, dtnascimento = @dtnascimento, cpf = @cpf, salario = @salario, endereco = @endereco, dtadmissao = @dtadmissao, dtdemissao = @dtdemissao, telefone = @telefone, email = @email, login = @login";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@nome", fun.Nome, "@dtnascimento", fun.Dtnascimento, "@cpf", fun.Cpf, "@salario", fun.Salario, "@endereco", fun.Endereco, "@dtadmissao", fun.Dtadmissao, "@dtdemissao", fun.Dtdemissao, "@telefone", fun.Telefone, "@email", fun.Email, "@login", fun.Login);
            }
            return result; 
        }

        public Funcionario get(int id)
        {
            DataTable dt = new DataTable();
            Funcionario fun = null;
            string SQL = @"SELECT * FROM Funcionario WHERE id = @id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt, "@id", id);
            if (dt.Rows.Count > 0)
            {
                fun = new Funcionario((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["nome"].ToString(),
                                    (DateTime)dt.Rows[0]["dtnascimento"],
                                    dt.Rows[0]["cpf"].ToString(),
                                    (double)dt.Rows[0]["salario"],
                                    dt.Rows[0]["endereco"].ToString(),
                                    (DateTime)dt.Rows[0]["dtadmissao"],
                                    (DateTime)dt.Rows[0]["dtdemissao"],
                                    dt.Rows[0]["telefone"].ToString(),
                                    dt.Rows[0]["email"].ToString(),
                                    (int)dt.Rows[0]["login"]);
            }
            banco.Disconnect();
            return fun;
        }

        public List<object> getList(string op)
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Funcionario WHERE " + op + " ORDER BY id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Funcionario fun;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    fun = new Funcionario((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["nome"].ToString(),
                                    (DateTime)dt.Rows[0]["dtnascimento"],
                                    dt.Rows[0]["cpf"].ToString(),
                                    (double)dt.Rows[0]["salario"],
                                    dt.Rows[0]["endereco"].ToString(),
                                    (DateTime)dt.Rows[0]["dtadmissao"],
                                    (DateTime)dt.Rows[0]["dtdemissao"],
                                    dt.Rows[0]["telefone"].ToString(),
                                    dt.Rows[0]["email"].ToString(),
                                    (int)dt.Rows[0]["login"]);
                    list.Add(fun);
                }
            }
            banco.Disconnect();
            return list;
        }
        public List<object> getAll()
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Funcionario ORDER BY id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Funcionario fun;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    fun = new Funcionario((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["nome"].ToString(),
                                    (DateTime)dt.Rows[0]["dtnascimento"],
                                    dt.Rows[0]["cpf"].ToString(),
                                    (double)dt.Rows[0]["salario"],
                                    dt.Rows[0]["endereco"].ToString(),
                                    (DateTime)dt.Rows[0]["dtadmissao"],
                                    (DateTime)dt.Rows[0]["dtdemissao"],
                                    dt.Rows[0]["telefone"].ToString(),
                                    dt.Rows[0]["email"].ToString(),
                                    (int)dt.Rows[0]["login"]);
                    list.Add(fun);
                }
            }
            banco.Disconnect();
            return list;
        }
    }
}
