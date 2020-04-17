using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GlobalHost.Persistencia
{
    class Banco
    {
        private readonly string strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ProjetoMVC\Proj-Aula-BD-novo-embranco\Banco\Banco.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection con;
        private SqlTransaction trans;

        public Banco ()
        {
            con = null;
            trans = null;
        }

        public bool Connect()
        {
            bool result = false;
            try
            {
                con = new SqlConnection(strcon);
                con.Open();
                result = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(null, "Connection Failed: " + e.Message, "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public void Disconnect()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
                con = null;
            }
        }

        public void BeginTransaction()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
                trans = con.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Commit();
                trans = null;
            }
        }

        public void RollbackTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Rollback();
                trans = null;
            }
        }

        public bool ExecuteQuery(String sql, out DataTable dt, params Object[] parametros)
        {
            dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(null, "Error on Execute Query: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ExecuteNonQuery(String sql, params Object[] parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(null, "Erro execute nonquery" + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public int GetIdentity()
        {
            SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", con);
            object o = cmd.ExecuteScalar();
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
        }
    }
}
