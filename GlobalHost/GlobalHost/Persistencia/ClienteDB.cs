﻿using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Persistencia
{
    class ClienteDB
    {
        private readonly Banco banco;

        public ClienteDB()
        {
            banco = new Banco();
        }
        public bool Insert(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Cliente))
            {
                Cliente c = (Cliente)obj;
                string SQL = @"INSERT INTO Cliente (nome, endereco,dtnascimento,cpf_cnpj,cep,email,telefone) VALUES (@nome, @endereco,@dtnascimento,@cpf_cnpj,@cep,email,@telefone)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@nome",c.Nome, "@endereco", c.Endereco, "@dtnascimento", c.Dtnascimento, "@cpf_cnpj", c.Cpf_cnpj, "@cep", c.Cep, "@email", c.Email, "@telefone", c.Telefone);
                banco.Disconnect();
            }
            return result;
        }
        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Cliente WHERE id = @id";
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL, "@id", id);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Cliente))
            {
                Cliente c = (Cliente)obj;
                string SQL = @"UPDATE Cliente SET nome = @nome, endereco = @endereco, dtnascimento = @dtnascimento, cpf_cnpj = @cpf_cnpj, cep = @cep, email = @email, telefone = @telefone";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@nome", c.Nome, "@endereco", c.Endereco, "@dtnascimento", c.Dtnascimento, "@cpf_cnpj", c.Cpf_cnpj, "@cep", c.Cep, "@email", c.Email, "@telefone", c.Telefone);
            }
            return result;
        }

        public Cliente get(int id)
        {
            DataTable dt = new DataTable();
            Cliente c = null;
            string SQL = @"SELECT * FROM Cliente WHERE id = @id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt, "@id", id);
            if (dt.Rows.Count > 0)
            {
                c = new Cliente((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["nome"].ToString(),
                                    dt.Rows[0]["endereco"].ToString(),
                                    DateTime.Parse(dt.Rows[0]["dtnascimento"].ToString()),
                                    dt.Rows[0]["cpf_cnpj"].ToString(),
                                    dt.Rows[0]["cep"].ToString(),
                                    dt.Rows[0]["email"].ToString(),
                                    dt.Rows[0]["telefone"].ToString()
                                    );
            }
            banco.Disconnect();
            return c;
        }
        
        public List<object> getList(string filter)
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Cliente"; 
            if (filter != string.Empty) 
                SQL += " WHERE " + filter; 
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Cliente c;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    c = new Cliente((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["nome"].ToString(),
                                    dt.Rows[0]["endereco"].ToString(),
                                    DateTime.Parse(dt.Rows[0]["dtnascimento"].ToString()),
                                    dt.Rows[0]["cpf_cnpj"].ToString(),
                                    dt.Rows[0]["cep"].ToString(),
                                    dt.Rows[0]["email"].ToString(),
                                    dt.Rows[0]["telefone"].ToString()
                                    );
                    list.Add(c);
                }
            }
            banco.Disconnect();
            return list;
        }

        public List<object> getAll()
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Cliente";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Cliente c;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    c = new Cliente((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["nome"].ToString(),
                                    dt.Rows[0]["endereco"].ToString(),
                                    DateTime.Parse(dt.Rows[0]["dtnascimento"].ToString()),
                                    dt.Rows[0]["cpf_cnpj"].ToString(),
                                    dt.Rows[0]["cep"].ToString(),
                                    dt.Rows[0]["email"].ToString(),
                                    dt.Rows[0]["telefone"].ToString());
                    list.Add(c);
                }
            }
            banco.Disconnect();
            return list;
        }
    }
}
