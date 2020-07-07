using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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
                //MessageBox.Show("Data: " + p.Data + "\nModalidade: " + p.Modalidade + "\nOrigem: " + p.Origem + "\nDestino: " + p.Destino + "\nDespachante: " + p.Despachante + "\nSituação: " + p.Situacao + "\nCliente: " + p.Cliente + "\nFuncionário: " + p.Funcionario + "\nAutorização:", p.Autorizacao);
                banco.Connect();
                if (p.Remessa != null)
                {
                    SQL = @"INSERT INTO Pedido (data, modalidade, origem, destino, despachante, situacao, cliente, funcionario, remessa, autorizacao) VALUES (@data, @mod, @orig, @dest, @desp, @situ, @cli, @fun, @rem, @auto)";
                    result = banco.ExecuteNonQuery(SQL, "@data", p.Data, "@mod", p.Modalidade, "@orig", p.Origem, "@dest", p.Destino, "@desp", p.Despachante, "@situ", p.Situacao, "@cli", p.Cliente.Id, "@fun", p.Funcionario.Id, "@rem", p.Remessa.Id, "@auto", p.Autorizacao);
                }                    
                else
                {
                    SQL = @"INSERT INTO Pedido (data, modalidade, origem, destino, despachante, situacao, cliente, funcionario, autorizacao) VALUES (@data, @mod, @orig, @dest, @desp, @situ, @cli, @fun, @auto)";
                    result = banco.ExecuteNonQuery(SQL, "@data", p.Data, "@mod", p.Modalidade, "@orig", p.Origem, "@dest", p.Destino, "@desp", p.Despachante, "@situ", p.Situacao, "@cli", p.Cliente.Id, "@fun", p.Funcionario.Id, "@auto", p.Autorizacao);
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

        public bool DeletePorRemessa(int idR)
        {
            string SQL = @"DELETE FROM Pedido WHERE remessa = " + idR;
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
                    SQL = @"UPDATE Pedido SET data = @data, modalidade = @mod, origem = @orig, destino = @dest, despachante = @desp, situacao = @situ, cliente = @cli, funcionario = @fun, remessa = @rem, autorizacao = @auto WHERE id = " + p.Id;
                    result = banco.ExecuteNonQuery(SQL, "@data", p.Data, "@mod", p.Modalidade, "@orig", p.Origem, "@dest", p.Destino, "@desp", p.Despachante, "@situ", p.Situacao, "@cli", p.Cliente.Id, "@fun", p.Funcionario.Id, "@rem", p.Remessa.Id, "@auto", p.Autorizacao);
                }
                else
                {
                    SQL = @"UPDATE Pedido SET data = @data, modalidade = @mod, origem = @orig, destino = @dest, despachante = @desp, situacao = @situ, cliente = @cli, funcionario = @fun, autorizacao = @auto WHERE id = " + p.Id;
                    result = banco.ExecuteNonQuery(SQL, "@data", p.Data, "@mod", p.Modalidade, "@orig", p.Origem, "@dest", p.Destino, "@desp", p.Despachante, "@situ", p.Situacao, "@cli", p.Cliente.Id, "@fun", p.Funcionario.Id, "@auto", p.Autorizacao);
                }
                banco.Disconnect();
            }
            return result;
        }

        public int MAX()
        {
            int aux = 0;
            DataTable data = new DataTable();
            string SQL = @"SELECT MAX(id) AS aux FROM Pedido";
            banco.Connect();
            banco.ExecuteQuery(SQL, out data);
            if (data.Rows.Count > 0)
                aux = (int)data.Rows[0]["aux"];
            banco.Disconnect();
            return aux;
        }
        
        public Pedido get(int id)
        {
            DataTable dt = new DataTable();
            ClienteDB clientes = new ClienteDB();
            FuncionarioDB funcionarios = new FuncionarioDB();
            RemessaDB remessas = new RemessaDB();

            Pedido p = null;
            string SQL = @"SELECT * FROM Pedido WHERE id = " + id;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                try
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
                                remessas.get((int)dt.Rows[0]["remessa"]),
                                dt.Rows[0]["autorizacao"].ToString());

                }
                catch
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
                                null,
                                dt.Rows[0]["autorizacao"].ToString());
                }
            }
            banco.Disconnect();
            return p;
        }

        public List<object> getList(string op)
        {
            DataTable dt = new DataTable();
            ClienteDB clientes = new ClienteDB();
            FuncionarioDB funcionarios = new FuncionarioDB();
            RemessaDB remessas = new RemessaDB();
            List<object> lista = new List<object>();

            string SQL = @"SELECT * FROM Pedido WHERE " + op;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Pedido p = null;
                    try
                    {
                        p = new Pedido((int)dt.Rows[i]["id"],
                                    Convert.ToDateTime(dt.Rows[i]["data"]),
                                    dt.Rows[i]["modalidade"].ToString(),
                                    dt.Rows[i]["origem"].ToString(),
                                    dt.Rows[i]["destino"].ToString(),
                                    dt.Rows[i]["despachante"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    clientes.get((int)dt.Rows[i]["cliente"]),
                                    funcionarios.get((int)dt.Rows[i]["funcionario"]),
                                    remessas.get((int)dt.Rows[i]["remessa"]),
                                    dt.Rows[i]["autorizacao"].ToString());

                    }
                    catch
                    {
                        p = new Pedido((int)dt.Rows[i]["id"],
                                    Convert.ToDateTime(dt.Rows[i]["data"]),
                                    dt.Rows[i]["modalidade"].ToString(),
                                    dt.Rows[i]["origem"].ToString(),
                                    dt.Rows[i]["destino"].ToString(),
                                    dt.Rows[i]["despachante"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    clientes.get((int)dt.Rows[i]["cliente"]),
                                    funcionarios.get((int)dt.Rows[i]["funcionario"]),
                                    null,
                                    dt.Rows[i]["autorizacao"].ToString());
                    }
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
            RemessaDB remessas = new RemessaDB();
            List<object> lista = new List<object>();

            string SQL = @"SELECT * FROM Pedido ORDER BY id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Pedido p = null;
                    try
                    {
                        p = new Pedido((int)dt.Rows[i]["id"],
                                    Convert.ToDateTime(dt.Rows[i]["data"]),
                                    dt.Rows[i]["modalidade"].ToString(),
                                    dt.Rows[i]["origem"].ToString(),
                                    dt.Rows[i]["destino"].ToString(),
                                    dt.Rows[i]["despachante"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    clientes.get((int)dt.Rows[i]["cliente"]),
                                    funcionarios.get((int)dt.Rows[i]["funcionario"]),
                                    remessas.get((int)dt.Rows[i]["remessa"]),
                                    dt.Rows[i]["autorizacao"].ToString());
                        
                    }
                    catch
                    {
                        p = new Pedido((int)dt.Rows[i]["id"],
                                    Convert.ToDateTime(dt.Rows[i]["data"]),
                                    dt.Rows[i]["modalidade"].ToString(),
                                    dt.Rows[i]["origem"].ToString(),
                                    dt.Rows[i]["destino"].ToString(),
                                    dt.Rows[i]["despachante"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    clientes.get((int)dt.Rows[i]["cliente"]),
                                    funcionarios.get((int)dt.Rows[i]["funcionario"]),
                                    null,
                                    dt.Rows[i]["autorizacao"].ToString());
                    }
                    lista.Add(p);
                }
            }
            banco.Disconnect();
            return lista;
        }
    }
}
