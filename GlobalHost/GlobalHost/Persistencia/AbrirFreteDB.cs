using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalHost.Persistencia
{
    class AbrirFreteDB
    {
        private readonly Banco banco;
        public AbrirFreteDB()
        {
            banco = new Banco();
        }

        public bool Insert(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Frete))
            {
                Frete f = (Frete)obj;
                string SQL = @"INSERT INTO Frete (valor_total, situacao, orcamento, remessa)"
                        + @"VALUES (@valor_total, @situacao, @orcamento, @remessa)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@valor_total", f.Total, "@situacao",
                    f.Situacao, "@orcamento", f.Orcamento.Id, "@remessa", f.Remessa.Id);
                banco.Disconnect();
            }
            return result;
        }
        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Frete WHERE id = " + id;
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Frete))
            {
                Frete f = (Frete)obj;
                string SQL = @"UPDATE Frete SET valor_total = @valor_total, situacao = @situacao, orcamento = @orcamento, remessa = @remessa"
                        + @"WHERE id =  " + f.Id;
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@valor_total", f.Total, "@situacao",
                    f.Situacao, "@orcamento", f.Orcamento.Id, "@remessa", f.Remessa.Id); 
                banco.Disconnect();
            }
            return result;
        }

        public Frete get(int id)
        {
            DataTable dt = new DataTable();
            Frete f = null;
            OrcamentoDB ODB = new OrcamentoDB();
            RemessaDB RDB = new RemessaDB();
            string SQL = @"SELECT * FROM Frete WHERE id = " + id;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                try
                {
                    f = new Frete((int)dt.Rows[0]["id"],
                                     Convert.ToDouble(dt.Rows[0]["valor_total"]),
                                     dt.Rows[0]["situacao"].ToString(),
                         ODB.get((int)dt.Rows[0]["Orcamento"]),
                         RDB.get((int)dt.Rows[0]["Remessa"]));
                }
                catch (Exception ex)
                {
                    f = new Frete((int)dt.Rows[0]["id"],
                                      Convert.ToDouble(dt.Rows[0]["valor_total"]),
                                      dt.Rows[0]["situacao"].ToString(),
                          ODB.get((int)dt.Rows[0]["Orcamento"]),
                          RDB.get((int)dt.Rows[0]["Remessa"]));
                    //MessageBox.Show("Erro ao retornar os dados do frete","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            banco.Disconnect();
            return f;
        }

        public List<object> getList(string op)
        {
            DataTable dt = new DataTable();
            List<object> list = new List<object>();
            OrcamentoDB ODB = new OrcamentoDB();
            RemessaDB RDB = new RemessaDB();
            string SQL = @"SELECT * FROM Frete WHERE " + op;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Frete f;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        f = new Frete((int)dt.Rows[0]["id"],
                                     Convert.ToDouble(dt.Rows[0]["valor_total"]),
                                     dt.Rows[0]["situacao"].ToString(),
                         ODB.get((int)dt.Rows[0]["orcamento"]),
                         RDB.get((int)dt.Rows[0]["eemessa"]));
                    }
                    catch (Exception ex)
                    {
                        f = new Frete((int)dt.Rows[0]["id"],
                                       Convert.ToDouble(dt.Rows[0]["valor_total"]),
                                       dt.Rows[0]["situacao"].ToString(),
                           ODB.get((int)dt.Rows[0]["orcamento"]),
                           RDB.get((int)dt.Rows[0]["eemessa"]));
                        //MessageBox.Show("Erro ao retornar os dados do frete","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    list.Add(f);
                }
            }
            banco.Disconnect();
            return list;
        }

        public List<object> getAll()
        {
            DataTable dt = new DataTable();
            List<object> list = new List<object>();
            OrcamentoDB ODB = new OrcamentoDB();
            RemessaDB RDB = new RemessaDB();
            string SQL = @"SELECT * FROM Frete ORDER BY id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Frete f;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        f = new Frete((int)dt.Rows[0]["id"],
                                     Convert.ToDouble(dt.Rows[0]["valor_total"]),
                                     dt.Rows[0]["situacao"].ToString(),
                         ODB.get((int)dt.Rows[0]["Orcamento"]),
                         RDB.get((int)dt.Rows[0]["Remessa"]));
                    }
                    catch (Exception ex)
                    {
                        f = new Frete((int)dt.Rows[0]["id"],
                                       Convert.ToDouble(dt.Rows[0]["valor_total"]),
                                       dt.Rows[0]["situacao"].ToString(),
                           ODB.get((int)dt.Rows[0]["Orcamento"]),
                           RDB.get((int)dt.Rows[0]["Remessa"]));
                        //MessageBox.Show("Erro ao retornar os dados do frete","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    list.Add(f);
                }
            }
            banco.Disconnect();
            return list;
        }

        public int MAX()
        {
            int aux = 0;
            DataTable data = new DataTable();
            string SQL = @"SELECT MAX(id) AS aux FROM Frete";
            banco.Connect();
            banco.ExecuteQuery(SQL, out data);
            if (data.Rows.Count > 0)
                aux = (int)data.Rows[0]["aux"];
            banco.Disconnect();
            return aux;
        }

    }
}
