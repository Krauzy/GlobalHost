using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;

namespace GlobalHost.Persistencia
{
    class PedidoDB
    {
        private readonly Banco banco;

        public PedidoDB()
        {
            this.banco = new Banco();
        }

        public bool Insert(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Pedido))
            {
                Pedido p = (Pedido)obj;
                string SQL;
                banco.Connect();
                if (p.Remessa != null)
                {
                    SQL = @"INSERT INTO Pedido (data, modalidade, origem, destino, despachante, situacao, cliente, funcionario, remessa) VALUES (@data, @mod, @orig, @dest, @desp, @situ, @cli, @fun, @rem)";
                    result = banco.ExecuteNonQuery(SQL, "@data", p.Data, "@mod", p.Modalidade, "@orig", p.Origem, "@dest", p.Destino, "@desp", p.Despachante, "@situ", p.Situacao, "@cli", p.Cliente.Id, "@fun", p.Funcionario.Id, "@rem", p.Remessa.Id);
                }                    
                else
                {
                    SQL = @"INSERT INTO Pedido (data, modalidade, origem, destino, despachante, situacao, cliente, funcionario) VALUES (@data, @mod, @orig, @dest, @desp, @situ, @cli, @fun)";
                    result = banco.ExecuteNonQuery(SQL, "@data", p.Data, "@mod", p.Modalidade, "@orig", p.Origem, "@dest", p.Destino, "@desp", p.Despachante, "@situ", p.Situacao, "@cli", p.Cliente.Id, "@fun", p.Funcionario.Id);
                }
                banco.Disconnect();
            }
            return result;
        }

        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Pedido WHERE id = " + id;
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Pedido))
            {
                Pedido p = (Pedido)obj;
                string SQL;
                banco.Connect();
                if (p.Remessa != null)
                {
                    SQL = @"UPDATE Pedido SET data = @data, modalidade = @mod, origem = @orig, destino = @dest, despachante = @desp, situacao = @situ, cliente = @cli, funcionario = @fun, remessa = @rem WHERE id = " + p.Id;
                    result = banco.ExecuteNonQuery(SQL, "@data", p.Data, "@mod", p.Modalidade, "@orig", p.Origem, "@dest", p.Destino, "@desp", p.Despachante, "@situ", p.Situacao, "@cli", p.Cliente.Id, "@fun", p.Funcionario.Id, "@rem", p.Remessa.Id);
                }
                else
                {
                    SQL = @"UPDATE Pedido SET data = @data, modalidade = @mod, origem = @orig, destino = @dest, despachante = @desp, situacao = @situ, cliente = @cli, funcionario = @fun WHERE id = " + p.Id;
                    result = banco.ExecuteNonQuery(SQL, "@data", p.Data, "@mod", p.Modalidade, "@orig", p.Origem, "@dest", p.Destino, "@desp", p.Despachante, "@situ", p.Situacao, "@cli", p.Cliente.Id, "@fun", p.Funcionario.Id);
                }
                banco.Disconnect();
            }
            return result;
        }

        public Pedido get(int id)
        {
            DataTable dt = new DataTable();
            ClienteDB clientes = new ClienteDB();
            FuncionarioDB funcionarios = new FuncionarioDB();
            
            Pedido p = null;
            string SQL = @"SELECT * FROM Pedido WHERE id = " + id;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                p = new Pedido((int)dt.Rows[0]["id"],
                 Convert.ToDateTime(dt.Rows[0]["data"]),
                                    dt.Rows[0]["modalidade"].ToString(),
                                    dt.Rows[0]["origem"].ToString(),
                                    dt.Rows[0]["destino"].ToString(),
                                    dt.Rows[0]["despachante"].ToString(),
                                    dt.Rows[0]["situacao"].ToString(),
                  clientes.get((int)dt.Rows[0]["cliente"]),
              funcionarios.get((int)dt.Rows[0]["funcionario"]),
                                    null);                                  /// remessaDB necessário <author>@campos</author>
            }
            banco.Disconnect();
            return p;
        }

        public List<object> getList(string op)
        {
            DataTable dt = new DataTable();
            ClienteDB clientes = new ClienteDB();
            FuncionarioDB funcionarios = new FuncionarioDB();
            List<object> lista = new List<object>();

            string SQL = @"SELECT * FROM Pedido WHERE " + op;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Pedido p = new Pedido((int)dt.Rows[i]["id"],
                                    Convert.ToDateTime(dt.Rows[i]["data"]),
                                    dt.Rows[i]["modalidade"].ToString(),
                                    dt.Rows[i]["origem"].ToString(),
                                    dt.Rows[i]["destino"].ToString(),
                                    dt.Rows[i]["despachante"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    clientes.get((int)dt.Rows[i]["cliente"]),
                                    funcionarios.get((int)dt.Rows[i]["funcionario"]),
                                    null);                                  /// remessaDB necessário <author>@campos</author>
                    lista.Add(p);
                }
            }
            banco.Disconnect();
            return lista;
        }

        public List<object> getAll()
        {
            DataTable dt = new DataTable();
            ClienteDB clientes = new ClienteDB();
            FuncionarioDB funcionarios = new FuncionarioDB();
            List<object> lista = new List<object>();

            string SQL = @"SELECT * FROM Pedido ORDER BY id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Pedido p = new Pedido((int)dt.Rows[i]["id"],
                                    Convert.ToDateTime(dt.Rows[i]["data"]),
                                    dt.Rows[i]["modalidade"].ToString(),
                                    dt.Rows[i]["origem"].ToString(),
                                    dt.Rows[i]["destino"].ToString(),
                                    dt.Rows[i]["despachante"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    clientes.get((int)dt.Rows[i]["cliente"]),
                                    funcionarios.get((int)dt.Rows[i]["funcionario"]),
                                    null);                                  /// remessaDB necessário <author>@campos</author>
                    lista.Add(p);
                }
            }
            banco.Disconnect();
            return lista;
        }
    }
}
