﻿using GlobalHost.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GlobalHost.Persistencia
{
    class Tipo_TransporteDB
    {
        private readonly Banco banco;

        public Tipo_TransporteDB()
        {
            banco = new Banco();
        }

        public bool Insert(object obj)
        {
            bool result = false;
            if(obj.GetType() == typeof(Tipo_Transporte))
            {
                Tipo_Transporte tt = (Tipo_Transporte)obj;
                string SQL = @"INSERT INTO Tipo_Transporte (descricao, max_peso, dimensoes) VALUES (@desc, @peso, @dim)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@desc", tt.Descricao, "@peso", tt.Max_peso, "@dim", tt.Dimensoes);
                banco.Disconnect();
            }
            return result;
        }

        public bool Delete(int id)
        {
            string SQL = @"DELETE FROM Tipo_Transporte WHERE id = " + id;
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Tipo_Transporte))
            {
                Tipo_Transporte tt = (Tipo_Transporte)obj;
                string SQL = @"UPDATE Tipo_Transporte SET descricao = @desc, max_peso = @peso, dimensoes = @dim WHERE id = " + tt.Id;
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@desc", tt.Descricao, "@peso", tt.Max_peso, "@dim", tt.Dimensoes);
                banco.Disconnect();
            }
            return result;
        }

        public Tipo_Transporte get(int id)
        {
            DataTable dt = new DataTable();
            Tipo_Transporte tt = null;
            string SQL = @"SELECT * FROM Tipo_Transporte WHERE id = " + id;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                tt = new Tipo_Transporte((int)dt.Rows[0]["id"],
                                              dt.Rows[0]["descricao"].ToString(),
                             Convert.ToDouble(dt.Rows[0]["max_peso"].ToString()),
                                              dt.Rows[0]["dimensoes"].ToString());
            }
            banco.Disconnect();
            return tt;
        }

        public List<object> getList(string op)
        {
            DataTable dt = new DataTable();
            List<object> lista = new List<object>();
            string SQL = @"SELECT * FROM Tipo_Transporte WHERE " + op;
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Tipo_Transporte tt;
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    tt = new Tipo_Transporte((int)dt.Rows[i]["id"],
                                                  dt.Rows[i]["descricao"].ToString(),
                                 Convert.ToDouble(dt.Rows[i]["max_peso"].ToString()),
                                                  dt.Rows[i]["dimensoes"].ToString());
                    lista.Add(tt);
                }
            }
            banco.Disconnect();
            return lista;
        }

        public List<object> getAll()
        {
            DataTable dt = new DataTable();
            List<object> lista = new List<object>();
            string SQL = @"Select * from Tipo_Transporte";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if (dt.Rows.Count > 0)
            {
                Tipo_Transporte tt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tt = new Tipo_Transporte((int)dt.Rows[i]["id"],
                                                  dt.Rows[i]["descricao"].ToString(),
                                 Convert.ToDouble(dt.Rows[i]["max_peso"].ToString()),
                                                  dt.Rows[i]["dimensoes"].ToString());
                    lista.Add(tt);
                }
            }
            banco.Disconnect();
            return lista;
        }
    }
}
