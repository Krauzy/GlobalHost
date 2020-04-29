using GlobalHost.Modelo;
using System;
using System.Data;
using System.Drawing;
using System.IO;

namespace GlobalHost.Persistencia
{
    class ParametrosDB
    {
        private Banco banco;

        public ParametrosDB()
        {
            banco = new Banco();
        }
        
        private byte[] ImageToBinary(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        private Image BinaryToImage(byte[] bytes)
        {
            using(MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        public bool Insert(object obj)
        {
            bool result = false;
            if(obj.GetType() == typeof(Parametros))
            {
                Parametros p = (Parametros)obj;
                string SQL = @"INSERT INTO Parametros (nome_fantasia, razao_social, cnpj, data_abertura, endereco, email, site, atividade, status, telefone, logo) "
                    + @"VALUES (@nome, @razao, @cnpj, @data, @end, @email, @site, @ati, @sta, @tel, @logo)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@nome", p.Nome_fantasia, "@razao", p.Razao_social, "@cnpj", p.Cnpj, "@data", p.Data_abertura, 
                    "@end", p.Endereco, "@email", p.Email, "@site", p.Site, "@ati", p.Atividade, "@sta", p.Status, "@tel", p.Telefone, "@logo", this.ImageToBinary(p.Logo));
                banco.Disconnect();
            }
            return result;
        }
        
        public bool Delete()
        {
            string SQL = @"DELETE FROM Parametros";
            banco.Connect();
            bool result = banco.ExecuteNonQuery(SQL);
            banco.Disconnect();
            return result;
        }

        public bool Update(object obj)
        {
            bool result = false;
            if (obj.GetType() == typeof(Parametros))
            {
                this.Delete();
                Parametros p = (Parametros)obj;
                string SQL = @"INSERT INTO Parametros (nome_fantasia, razao_social, cnpj, data_abertura, endereco, email, site, atividade, status, telefone, logo) "
                    + @"VALUES (@nome, @razao, @cnpj, @data, @end, @email, @site, @ati, @sta, @tel, @logo)";
                banco.Connect();
                result = banco.ExecuteNonQuery(SQL, "@nome", p.Nome_fantasia, "@razao", p.Razao_social, "@cnpj", p.Cnpj, "@data", p.Data_abertura,
                    "@end", p.Endereco, "@email", p.Email, "@site", p.Site, "@ati", p.Atividade, "@sta", p.Status, "@tel", p.Telefone, "@logo", this.ImageToBinary(p.Logo));
                banco.Disconnect();
            }
            return result;
        }

        public Parametros get()
        {
            DataTable dt = new DataTable();
            Parametros p = null;
            string SQL = @"SELECT * FROM Parametros";
            banco.Connect();
            banco.ExecuteQuery(SQL, out dt);
            if(dt.Rows.Count > 0)
            {
                p = new Parametros((int)dt.Rows[0]["id"],
                                    dt.Rows[0]["nome_fantasia"].ToString(),
                                    dt.Rows[0]["razao_social"].ToString(),
                                    dt.Rows[0]["cnpj"].ToString(),
                                    DateTime.Parse(dt.Rows[0]["data_abertura"].ToString()),
                                    dt.Rows[0]["endereco"].ToString(),
                                    dt.Rows[0]["email"].ToString(),
                                    dt.Rows[0]["site"].ToString(),
                                    dt.Rows[0]["atividade"].ToString(),
                                    dt.Rows[0]["status"].ToString(),
                                    dt.Rows[0]["telefone"].ToString(),
                                    this.BinaryToImage((byte[])dt.Rows[0]["logo"]));

            }
            banco.Disconnect();
            return p;
        }
    }
}
