using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Persistencia
{
    class ContasPagarDB
    {
        private readonly Banco banco;

        public ContasPagarDB()
        {
            banco = new Banco();
        }
        public bool Insert(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Contas_Pagar))
            {
                Contas_Pagar c = (Contas_Pagar)obj;
<<<<<<< HEAD
                string SQL = @"INSERT INTO Contas_Pagar (valor, situacao, frete, despesa) VALUES (@valor, @situacao, @frete, @despesa)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@valor", c.Valor, "@tipo", c.Tipo, "@situacao", c.Situacao, "@frete", c.Frete, "@despesa", c.Despesa);
=======
                string SQL = @"INSERT INTO Contas_Pagar (valor, tipo, situacao, frete, despesa, data_emissao, data_vencimento, data_pagto, valor_pago) VALUES (@valor, @tipo, @situacao, @frete, @despesa, @data_emissao, @data_vencimento, @data_pagto, @valor_pago)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@valor", c.Valor, "@tipo", c.Tipo, "@situacao", c.Situacao, "@frete", c.Frete, "@despesa", c.Despesa, "@data_emissao",c.Dt_emissao, "@data_vencimento",c.Dt_vencimento, "@data_pagto",c.Dt_pagto, "@valor_pago",c.Pago);
>>>>>>> old-state
                banco.Disconnect();
            }
            return result;
        }
        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Contas_Pagar WHERE id = @id";
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL, "@id", id);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Contas_Pagar))
            {
                Contas_Pagar c = (Contas_Pagar)obj;
<<<<<<< HEAD
                string SQL = @"UPDATE Contas_Pagar SET valor=@valor, tipo=@tipo, situacao=@situacao,frete=@frete,despesa=@despesa";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@valor",c.Valor,"@tipo",c.Tipo,"@situacao",c.Situacao,"@frete",c.Frete,"@despesa",c.Despesa);
=======
                string SQL = @"UPDATE Contas_Pagar SET valor=@valor, tipo=@tipo, situacao=@situacao,frete=@frete,despesa=@despesa,
                data_emissao=@data_emissao,data_vencimento=@data_vencimento,data_pagto=@data_pagto,valor_pago=@valor_pago where ID=@ID";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@valor", c.Valor, "@tipo", c.Tipo, "@situacao", c.Situacao, 
                    "@frete", c.Frete, "@despesa", c.Despesa, "@data_emissao", c.Dt_emissao, "@data_vencimento", c.Dt_vencimento, 
                    "@data_pagto", c.Dt_pagto, "@valor_pago", c.Pago,"@ID",c.ID);
>>>>>>> old-state
            }
            return result;
        }

        public Contas_Pagar get(int id)
        {
            DataTable dt = new DataTable();
            Contas_Pagar c=null;
            string SQL = @"SELECT * FROM Contas_Pagar WHERE id = @id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt, "@id", id);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
<<<<<<< HEAD
                    c = new Contas_Pagar((int)dt.Rows[i]["id"],
                                    (double)dt.Rows[i]["valor"],
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    (int)dt.Rows[i]["frete"],
                                    (int)dt.Rows[i]["despesa"]);
=======
                    double vpago = Convert.ToDouble(dt.Rows[i]["valor_pago"]);
                    c = new Contas_Pagar(Convert.ToInt32(dt.Rows[i]["id"]),
                                    Convert.ToDouble(dt.Rows[i]["valor"]),
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    Convert.ToInt32(dt.Rows[i]["frete"]),
                                    Convert.ToInt32(dt.Rows[i]["despesa"]),
                                    Convert.ToDateTime(dt.Rows[i]["data_emissao"]),
                                    Convert.ToDateTime(dt.Rows[i]["data_vencimento"]),
                                    Convert.ToDateTime(dt.Rows[i]["data_pagto"]),
                                    vpago);
>>>>>>> old-state
                }
            }
            banco.Disconnect();
            return c;
        }

        public List<object> getAll()
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Contas_Pagar";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Contas_Pagar c;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    c = new Contas_Pagar((int)dt.Rows[i]["id"],
                                    (double)dt.Rows[i]["valor"],
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    (int)dt.Rows[i]["frete"],
<<<<<<< HEAD
                                    (int)dt.Rows[i]["despesa"]);
=======
                                    (int)dt.Rows[i]["despesa"],
                                    Convert.ToDateTime(dt.Rows[i]["data_emissao"]),
                                    Convert.ToDateTime(dt.Rows[i]["data_vencimento"]),
                                    Convert.ToDateTime(dt.Rows[i]["data_pagto"]),
                                    Convert.ToDouble(dt.Rows[i]["valor_pago"]));
>>>>>>> old-state
                    list.Add(c);
                }
            }
            banco.Disconnect();
            return list;
        }
<<<<<<< HEAD
        public List<object> getFromDespesa(int desp)
        {
            List<object> list = new List<object>();
=======
        public List<Contas_Pagar> getFromDespesa(int desp)
        {
            List<Contas_Pagar> list = new List<Contas_Pagar>();
>>>>>>> old-state
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Contas_Pagar where despesa="+desp;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Contas_Pagar c;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
<<<<<<< HEAD
                    c = new Contas_Pagar((int)dt.Rows[i]["id"],
                                    (double)dt.Rows[i]["valor"],
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    (int)dt.Rows[i]["frete"],
                                    (int)dt.Rows[i]["despesa"]);
=======
                    int frete, despesa,id;
                    double valor;
                    Int32.TryParse(dt.Rows[i]["id"].ToString(), out id);
                    double.TryParse(dt.Rows[i]["valor"].ToString(),out valor);
                    Int32.TryParse(dt.Rows[i]["frete"].ToString(), out frete) ;
                    Int32.TryParse(dt.Rows[i]["despesa"].ToString(),out despesa);
                    DateTime dte = Convert.ToDateTime(dt.Rows[i]["data_emissao"]), dtv = Convert.ToDateTime(dt.Rows[i]["data_vencimento"]), dtp = Convert.ToDateTime(dt.Rows[i]["data_pagto"]);

                    c = new Contas_Pagar(id,
                                    valor,
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["situacao"].ToString(),
                                    frete,
                                    despesa, 
                                    dte,
                                    dtv,
                                    dtp,
                                    Convert.ToDouble(dt.Rows[i]["valor_pago"]));
>>>>>>> old-state
                    list.Add(c);
                }
            }
            banco.Disconnect();
            return list;
        }
    }
}
