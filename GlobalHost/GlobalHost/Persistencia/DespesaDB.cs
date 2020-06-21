﻿using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Persistencia
{
    class DespesaDB
    {
        private readonly Banco banco;

        public DespesaDB()
        {
            banco = new Banco();
        }
        public bool Insert(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Despesa))
            {
                Despesa d = (Despesa)obj;
                string SQL = @"INSERT INTO Despesa (descricao, tipo, estado) VALUES (@descricao, @tipo, @estado)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL,"@descricao",d.Descricao,"@tipo",d.Tipo,"@estado",d.Estado);
                banco.Disconnect();
            }
            return result;
        }
        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Despesa WHERE id = @id";
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL, "@id", id);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Despesa))
            {
                Despesa d = (Despesa)obj;
                string SQL = @"UPDATE Cliente SET descricao=@descricao, tipo=@tipo, estado=@estado";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@descricao", d.Descricao, "@tipo", d.Tipo, "@estado", d.Estado);
            }
            return result;
        }

        public Despesa get(int id)
        {
            DataTable dt = new DataTable();
            Despesa d = null;
            string SQL = @"SELECT * FROM Despesa WHERE id = @id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt, "@id", id);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    d = new Despesa((int)dt.Rows[i]["id"],
                                    dt.Rows[i]["descricao"].ToString(),
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["estado"].ToString());
                }
            }
            banco.Disconnect();
            return d;
        }

        public List<object> getAll()
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Despesa";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Despesa d;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    d = new Despesa((int)dt.Rows[i]["id"],
                                    dt.Rows[i]["descricao"].ToString(),
                                    dt.Rows[i]["tipo"].ToString(),
                                    dt.Rows[i]["estado"].ToString());
                    list.Add(d);
                }
            }
            banco.Disconnect();
            return list;
        }
    }
}
