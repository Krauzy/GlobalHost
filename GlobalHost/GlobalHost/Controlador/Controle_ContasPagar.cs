using GlobalHost.Modelo;
using GlobalHost.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalHost.Controlador
{
    class Controle_ContasPagar
    {
        public bool insert(double valor, string tipo, string situacao, int frete, int despesa, DateTime dte, DateTime dtv, DateTime dtp, double pago)
        {
            ContasPagarDB db = new ContasPagarDB();
            Contas_Pagar c = new Contas_Pagar(valor, tipo, situacao,frete,despesa,dte,dtv,dtp,pago);
            return db.Insert(c);
        }

        public bool delete(int id)
        {
            ContasPagarDB db = new ContasPagarDB();
            return db.Delete(id);
        }

        public DataTable getDtSchema()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("valor", typeof(string));
            dt.Columns.Add("tipo", typeof(string));
            dt.Columns.Add("situacao", typeof(string));
            dt.Columns.Add("frete", typeof(int));
            dt.Columns.Add("despesa", typeof(int));
            dt.Columns.Add("data_emissao", typeof(DateTime));
            dt.Columns.Add("data_vencimento", typeof(DateTime));
            dt.Columns.Add("data_pagto", typeof(DateTime));
            dt.Columns.Add("valor_pago", typeof(double));
            return dt;
        }
        public bool update(int id,double valor,string tipo, string situacao, int frete, int despesa, DateTime dte, DateTime dtv, DateTime dtp, double pago)
        {
            ContasPagarDB db = new ContasPagarDB();
            Contas_Pagar c = new Contas_Pagar(id, valor, tipo, situacao, frete,despesa, dte, dtv, dtp, pago);
            return db.Update(c);
        }
        public bool pay(int desp, int cp, double valor)
        {
            bool res = false;
            Controle_Despesa cd = new Controle_Despesa();
            ContasPagarDB db = new ContasPagarDB();
            Contas_Pagar c = db.get(cp);
            if(valor >= c.Valor)
            {
                c.Pago = c.Valor;
                c.Situacao = "PAGO";
                c.Dt_pagto = DateTime.Now;
            }
            else
            {
                c.Pago += valor;
                c.Situacao = "PARCIALMENTE PAGO";
                c.Dt_pagto = DateTime.Now;
            }
            valor -= c.Valor;
            res = db.Update(c);
            if(valor <= 0)
            {
                //gerar nova?
            }
            else // estorno
            {
                Controle_ContasReceber ccr = new Controle_ContasReceber();
                ccr.insert(valor,"ESTORNO");
            }
            return res;
        }
        public bool getFirstEmmited(int desp, DateTime dt)
        {
            ContasPagarDB db = new ContasPagarDB();
            List<Contas_Pagar> l = db.getFromDespesa(desp);
            DateTime min = l.Min(item => item.Dt_emissao);
            if(dt >= min)
              return true;
            return false;
        }
        public bool getLastToExpire(int desp, DateTime dt)
        {
            ContasPagarDB db = new ContasPagarDB();
            List<Contas_Pagar> l = db.getFromDespesa(desp);
            DateTime max = l.Max(item => item.Dt_vencimento);
            if(dt <= max)
                    return true;
            return false;
        }
        public bool paya(int despesa, double valor, double valor_a_pagar)
        {
            Controle_Despesa cd = new Controle_Despesa();
            bool res = false;
            ContasPagarDB db = new ContasPagarDB();
            List<Contas_Pagar> contas = db.getFromDespesa(despesa);
            foreach(Contas_Pagar c in contas)
            {
                if (valor_a_pagar >= c.Valor)
                {
                    c.Situacao = "PAGO";
                }
                else
                {
                    Contas_Pagar resto = new Contas_Pagar(valor - c.Valor, c.Tipo, "PARCELA PARCIAL",despesa);
                    db.Insert(resto);
                    c.Situacao = "PARCIALMENTE PAGA";
                }
                valor_a_pagar -= c.Valor;
                res = db.Update(c);
            }
            if(valor_a_pagar <=0)
            {
                DataRow dr = cd.get(despesa).Rows[0];
                cd.update(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), "PAGO");
            }
            // se valor total ainda não acabou, estornar, mas aí não é problema meu
            return res;
        }
        public DataTable get(object obj)
        {
            ContasPagarDB DB = new ContasPagarDB();
            DataTable table = new DataTable();
            List<object> list = new List<object>();
            if (obj.GetType() == typeof(int))
            {
                Contas_Pagar d = DB.get((int)obj);
                list.Add(d);
            }
            else
                list = DB.getAll();
            table = getDtSchema();
            foreach (var item in list)
            {
                DataRow linha = table.NewRow();
                Contas_Pagar aux = (Contas_Pagar)item;
                linha["id"] = aux.ID;
                linha["valor"] = aux.Valor;
                linha["tipo"] = aux.Tipo;
                linha["situacao"] = aux.Situacao;
                linha["frete"] = aux.Frete;
                linha["despesa"] = aux.Despesa;
                linha["data_emissao"] = aux.Dt_emissao;
                linha["data_vencimento"] = aux.Dt_vencimento;
                linha["data_pagto"] = aux.Dt_pagto;
                linha["valor_pago"] = aux.Pago;
                table.Rows.Add(linha);
            }
            return table;
        }

        public DataTable getListContasByDespesa(int despesa) 
        {
            ContasPagarDB db = new ContasPagarDB();
            List<Contas_Pagar> l = db.getFromDespesa(despesa);
            DataTable dt = getDtSchema();
            //DataRow dr = dt.NewRow();
            for(int i = 0; i < l.Count;i++)
            {
                /*
                 * dr[0] = c.ID;
                dr[1] = c.Valor;
                dr[2] = c.Tipo;
                dr[3] = c.Situacao;
                dr[4] = c.Frete;
                dr[5] = c.Despesa;
                dr[6] = "01/01/1999";
                dr[7] = "01/01/1999";
                 */
                Contas_Pagar c = l[i];
                dt.Rows.Add(c.ID,c.Valor,c.Tipo,c.Situacao,c.Frete,c.Despesa,c.Dt_emissao,c.Dt_vencimento,c.Dt_pagto,c.Pago);
            }
            return dt;
        }
        public List<Contas_Pagar> getListaContas(int despesa)
        {
            ContasPagarDB db = new ContasPagarDB();
            List<Contas_Pagar> l = db.getFromDespesa(despesa);
            //for(int i = 0; i < 10; i++)
            //{
            //    Contas_Pagar c = new Contas_Pagar(i, 50,"DÍVIDA DO AGIOTA", "PENDENTE");
            //}
            return l;
        }
    }
}
