using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Persistencia
{
    class RemessaDB
    {
        private readonly Banco banco;

        public RemessaDB()
        {
            banco = new Banco();
        }

        public bool Insert(object obj)
        {
            bool result = false;
            if(obj.GetType() == typeof(Remessa))
            {
                Remessa r = (Remessa)obj;
                string SQL = @"INSERT INTO Remessa (descricao, origem, destino, data_saida, previsao_requerida, data_requerida, transportadora)"
                        + @"VALUES (@descricao, @origem, @destino, @data_saida, @previsao_requerida, @data_requerida, @transportadora)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, SQL, "@descricao", r.Descricao, "@origem", r.Origem, "@destino", r.Destino, "@data_saida", r.Saida,
                    "@previsao_requerida", r.Previsao, "@data_requerida", r.Requerimento, "@transportadora", r.Transportadora);
                banco.Disconnect();
            }
            return result;
        }

        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Remessa WHERE id = " + id;
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Remessa))
            {
                Remessa r = (Remessa)obj;
                string SQL = @"UPDATE Remessa SET descricao = @descricao, origem = @origem, destino = @destino,"
                        + @" data_saida = @data_saida, previsao_requerida = @previsao_requerida, data_requerida = @data_requerida, transportadora = @transportadora WHERE id =  " + r.Id;
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, SQL, "@descricao", r.Descricao, "@origem", r.Origem, "@destino", r.Destino, "@data_saida", r.Saida,
                    "@previsao_requerida", r.Previsao, "@data_requerida", r.Requerimento, "@transportadora", r.Transportadora.Id);
                banco.Disconnect();
            }
            return result;
        }

        public Remessa get (int id)
        {
            DataTable dt = new DataTable();
            Remessa r = null;
            TransportadoraDB DB = new TransportadoraDB();
            string SQL = @"SELECT * FROM Remessa WHERE id = " + id;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if(dt.Rows.Count > 0)
            {
                try
                {
                    r = new Remessa((int)dt.Rows[0]["id"],
                                     dt.Rows[0]["descricao"].ToString(),
                                     dt.Rows[0]["origem"].ToString(),
                                     dt.Rows[0]["destino"].ToString(),
                  Convert.ToDateTime(dt.Rows[0]["data_saida"]),
                  Convert.ToDateTime(dt.Rows[0]["previsao_requerida"]),
                  Convert.ToDateTime(dt.Rows[0]["data_requerida"]),
                         DB.get((int)dt.Rows[0]["transportadora"]));                    
                }
                catch
                {
                    r = new Remessa((int)dt.Rows[0]["id"],
                                     dt.Rows[0]["descricao"].ToString(),
                                     dt.Rows[0]["origem"].ToString(),
                                     dt.Rows[0]["destino"].ToString(),
                  Convert.ToDateTime(dt.Rows[0]["data_saida"]),
                  Convert.ToDateTime(dt.Rows[0]["previsao_requerida"]),
                         DB.get((int)dt.Rows[0]["transportadora"]));
                }                
            }
            banco.Disconnect();
            return r;
        }

        public List<object> getList(string op)
        {
            DataTable dt = new DataTable();
            List<object> list = new List<object>();
            TransportadoraDB DB = new TransportadoraDB();
            string SQL = @"SELECT * FROM Remessa WHERE " + op;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if(dt.Rows.Count > 0)
            {
                Remessa r;
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        r = new Remessa((int)dt.Rows[i]["id"],
                                         dt.Rows[i]["descricao"].ToString(),
                                         dt.Rows[i]["origem"].ToString(),
                                         dt.Rows[i]["destino"].ToString(),
                      Convert.ToDateTime(dt.Rows[i]["data_saida"]),
                      Convert.ToDateTime(dt.Rows[i]["previsao_requerida"]),
                      Convert.ToDateTime(dt.Rows[i]["data_requerida"]),
                             DB.get((int)dt.Rows[i]["transportadora"]));
                    }
                    catch
                    {
                        r = new Remessa((int)dt.Rows[i]["id"],
                                         dt.Rows[i]["descricao"].ToString(),
                                         dt.Rows[i]["origem"].ToString(),
                                         dt.Rows[i]["destino"].ToString(),
                      Convert.ToDateTime(dt.Rows[i]["data_saida"]),
                      Convert.ToDateTime(dt.Rows[i]["previsao_requerida"]),
                             DB.get((int)dt.Rows[i]["transportadora"]));
                    }
                    list.Add(r);
                }  
            }
            banco.Disconnect();
            return list;
        }

        public List<object> getAll()
        {
            DataTable dt = new DataTable();
            List<object> list = new List<object>();
            TransportadoraDB DB = new TransportadoraDB();
            string SQL = @"SELECT * FROM Remessa ORDER BY id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Remessa r;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        r = new Remessa((int)dt.Rows[i]["id"],
                                         dt.Rows[i]["descricao"].ToString(),
                                         dt.Rows[i]["origem"].ToString(),
                                         dt.Rows[i]["destino"].ToString(),
                      Convert.ToDateTime(dt.Rows[i]["data_saida"]),
                      Convert.ToDateTime(dt.Rows[i]["previsao_requerida"]),
                      Convert.ToDateTime(dt.Rows[i]["data_requerida"]),
                             DB.get((int)dt.Rows[i]["transportadora"]));
                    }
                    catch
                    {
                        r = new Remessa((int)dt.Rows[i]["id"],
                                         dt.Rows[i]["descricao"].ToString(),
                                         dt.Rows[i]["origem"].ToString(),
                                         dt.Rows[i]["destino"].ToString(),
                      Convert.ToDateTime(dt.Rows[i]["data_saida"]),
                      Convert.ToDateTime(dt.Rows[i]["previsao_requerida"]),
                             DB.get((int)dt.Rows[i]["transportadora"]));
                    }
                    list.Add(r);

                    list.Add(r);
                }
            }
            banco.Disconnect();
            return list;
        }
        public int MAX()
        {
            int aux = 0;
            DataTable data = new DataTable();
            string SQL = @"SELECT MAX(id) AS aux FROM Remessa";
            banco.Connect();
            banco.ExecuteQuery(SQL, out data);
            if (data.Rows.Count > 0)
                aux = (int)data.Rows[0]["aux"];
            banco.Disconnect();
            return aux;
        }
    }
}
