﻿using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GlobalHost.Persistencia
{
    class Tipo_CargaDB
    {
        private readonly Banco banco;
        
        public Tipo_CargaDB()
        {
            banco = new Banco();
        }

        public bool Insert(object obj)
        {
            bool result = false;
            if(obj.GetType() == typeof(Tipo_Carga))
            {
                Tipo_Carga tc = (Tipo_Carga)obj;
                string SQL = @"INSERT INTO Tipo_Carga (descricao, peso, dimensoes) VALUES (@desc, @peso, @dim)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@desc", tc.Descricao, "@peso", tc.Peso, "@dim", tc.Dimensoes);
                banco.Disconnect();
            }
            return result;
        }

        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Tipo_Carga WHERE id = @id";
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL, "@id", id);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if(obj.GetType() == typeof(Tipo_Carga))
            {
                Tipo_Carga tc = (Tipo_Carga)obj;
                string SQL = @"UPDATE Tipo_Carga SET desc = @desc, peso = @peso, dimensoes = @dim WHERE id = @id";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@desc", tc.Descricao, "@peso", tc.Peso, "@dim", tc.Dimensoes, "@id", tc.Id);
            }
            return result;
        }

        public Tipo_Carga get(int id)
        {
            DataTable dt = new DataTable();
            Tipo_Carga tc = null;
            string SQL = @"SELECT * FROM Tipo_Carga WHERE id = @id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt, "@id", id);
            if (dt.Rows.Count > 0)
            {
                tc = new Tipo_Carga((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["descricao"].ToString(),
                                    Convert.ToDouble(dt.Rows[0]["peso"]),
                                    dt.Rows[0]["dimensoes"].ToString());
            }
            banco.Disconnect();
            return tc;
        }

        public Tipo_Carga get(string str)
        {
            DataTable dt = new DataTable();
            Tipo_Carga tc = null;
            string SQL = @"SELECT * FROM Tipo_Carga WHERE descricao LIKE '%" + str + "%'";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                tc = new Tipo_Carga((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["descricao"].ToString(),
                                    Convert.ToDouble(dt.Rows[0]["peso"]),
                                    dt.Rows[0]["dimensoes"].ToString());
            }
            banco.Disconnect();
            return tc;
        }

        public List<object> getList(string op)
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Tipo_Carga WHERE " + op;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if(dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    Tipo_Carga tc = new Tipo_Carga((int)dt.Rows[i]["id"],
                                    dt.Rows[i]["descricao"].ToString(),
                                    Convert.ToDouble(dt.Rows[i]["peso"]),
                                    dt.Rows[i]["dimensoes"].ToString());
                    list.Add(tc);
                }
            }
            banco.Disconnect();
            return list;
        }

        public List<object> getAll()
        {
            List<object> list = new List<object>();
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Tipo_Carga ORDER BY id";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Tipo_Carga tc;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tc = new Tipo_Carga((int)dt.Rows[i]["id"],
                                    dt.Rows[i]["descricao"].ToString(),
                                    Convert.ToDouble(dt.Rows[i]["peso"]),
                                    dt.Rows[i]["dimensoes"].ToString());
                    list.Add(tc);
                }
            }
            banco.Disconnect();
            return list;
        }
    }
}
