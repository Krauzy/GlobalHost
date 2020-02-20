using System;
using System.Diagnostics;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;

namespace GlobalHost.API
{
    class PDF
    {
        public static void Create()
        {
            string dir = "200000367421";
            int versao = 1;
            DateTime data_dir = new DateTime(2020, 2, 14, 9, 12, 0);
            string lote = "CGF2020021400057";
            string modalidade = "Expressa";
            string remessa = "07432182953";
            string situacao = "Desembaraçada";
            string manifesto = "CGF202000011844";
            DateTime data_manifesto = new DateTime(2020, 2, 14, 9, 12, 0);
            string master = "07432182953";
            string despacho = "0817600 - GRU - AEROPORTO INTERNACIONAL DE SÃO PAULO - SP";
            string operador = "CGF TRANSPORTES INTERNACIONAIS LTDA";
            string descricao = "documentos";
            double peso = 5.00;
            int volume = 18;
            string destinacao_comercial = "Não";
            double cambio = 4.33890;
            string remessa_dolar = "-";
            string remessa_real = "-";

            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            XGraphics graphics = XGraphics.FromPdfPage(page);
            XTextFormatter textFormatter = new XTextFormatter(graphics);
            XFont arial_10_bold = new XFont("Arial", 10.5, XFontStyle.Bold);
            XFont arial_9_bold = new XFont("Arial", 9.5, XFontStyle.Bold);
            XFont arial_7 = new XFont("Arial", 7, XFontStyle.Regular);

            //titulo
            graphics.DrawRectangle(XBrushes.LightGray, 45, 35, 500, 16);
            textFormatter.DrawString("DECLARAÇÃO DE IMPORTAÇÃO DE REMESSA - DIR", arial_10_bold, XBrushes.Black, new XRect(165, 37, page.Width, page.Height));
            graphics.DrawLine(XPens.Black, 45, 35, 545, 35);
            graphics.DrawLine(XPens.Black, 45, 51, 545, 51);

            //Identificação
            graphics.DrawRectangle(XBrushes.LightGray, 45, 55, 500, 13);
            textFormatter.DrawString("Identificação da Remessa", arial_9_bold, XBrushes.Black, new XRect(50, 56, page.Width, page.Height));
            graphics.DrawLine(XPens.Black, 45, 55, 545, 55);
            graphics.DrawLine(XPens.Black, 45, 68, 545, 68);

            textFormatter.DrawString("Declaração (DIR)/Versão", arial_9_bold, XBrushes.Black, new XRect(50, 70, page.Width, page.Height));
            textFormatter.DrawString(dir + " / " + versao, arial_7, XBrushes.Black, new XRect(50, 82, page.Width, page.Height));

            textFormatter.DrawString("Data/Horário Registro DIR", arial_9_bold, XBrushes.Black, new XRect(185, 70, page.Width, page.Height));
            textFormatter.DrawString(data_dir.Day + "/" + data_dir.Month + "/" + data_dir.Year + " " + data_dir.Hour + ":" + data_dir.Minute, arial_7, XBrushes.Black, new XRect(185, 82, page.Width, page.Height));

            textFormatter.DrawString("Lote DIR", arial_9_bold, XBrushes.Black, new XRect(335, 70, page.Width, page.Height));
            textFormatter.DrawString(lote, arial_7, XBrushes.Black, new XRect(335, 82, page.Width, page.Height));

            textFormatter.DrawString("Modalidade", arial_9_bold, XBrushes.Black, new XRect(440, 70, page.Width, page.Height));
            textFormatter.DrawString(modalidade, arial_7, XBrushes.Black, new XRect(440, 82, page.Width, page.Height));

            textFormatter.DrawString("Remessa", arial_9_bold, XBrushes.Black, new XRect(50, 95, page.Width, page.Height));
            textFormatter.DrawString(remessa, arial_7, XBrushes.Black, new XRect(50, 107, page.Width, page.Height));

            textFormatter.DrawString("Situação", arial_9_bold, XBrushes.Black, new XRect(185, 95, page.Width, page.Height));
            textFormatter.DrawString(situacao, arial_7, XBrushes.Black, new XRect(185, 107, page.Width, page.Height));

            textFormatter.DrawString("Manifesto", arial_9_bold, XBrushes.Black, new XRect(335, 95, page.Width, page.Height));
            textFormatter.DrawString(manifesto, arial_7, XBrushes.Black, new XRect(335, 107, page.Width, page.Height));

            textFormatter.DrawString("Data/Horário Manifesto", arial_9_bold, XBrushes.Black, new XRect(440, 95, page.Width, page.Height));
            textFormatter.DrawString(data_manifesto.Day + "/" + data_manifesto.Month + "/" + data_manifesto.Year + " " + data_manifesto.Hour + ":" + data_manifesto.Minute, arial_7, XBrushes.Black, new XRect(440, 107, page.Width, page.Height));

            textFormatter.DrawString("Master", arial_9_bold, XBrushes.Black, new XRect(50, 120, page.Width, page.Height));
            textFormatter.DrawString(master, arial_7, XBrushes.Black, new XRect(50, 132, page.Width, page.Height));

            textFormatter.DrawString("UA de Despacho", arial_9_bold, XBrushes.Black, new XRect(185, 120, page.Width, page.Height));
            if(despacho.Length > 30)
            {
                int i = 30;
                for (; despacho[i] != ' '; i--);
                textFormatter.DrawString(despacho.Substring(0, i+1), arial_7, XBrushes.Black, new XRect(185, 132, page.Width, page.Height));
                textFormatter.DrawString(despacho.Substring(i+1), arial_7, XBrushes.Black, new XRect(185, 140, page.Width, page.Height));
            }
            else textFormatter.DrawString(despacho, arial_7, XBrushes.Black, new XRect(185, 132, page.Width, page.Height));

            textFormatter.DrawString("Operador", arial_9_bold, XBrushes.Black, new XRect(335, 120, page.Width, page.Height));
            textFormatter.DrawString(operador, arial_7, XBrushes.Black, new XRect(335, 132, page.Width, page.Height));

            //Dados Gerais
            graphics.DrawRectangle(XBrushes.LightGray, 45, 155, 500, 13);
            textFormatter.DrawString("Dados Gerais", arial_9_bold, XBrushes.Black, new XRect(50, 156, page.Width, page.Height));
            graphics.DrawLine(XPens.Black, 45, 155, 545, 155);
            graphics.DrawLine(XPens.Black, 45, 168, 545, 168);

            textFormatter.DrawString("Descrição", arial_9_bold, XBrushes.Black, new XRect(50, 170, page.Width, page.Height));
            textFormatter.DrawString(descricao, arial_7, XBrushes.Black, new XRect(50, 182, page.Width, page.Height));

            textFormatter.DrawString("Peso Bruto (Kg)", arial_9_bold, XBrushes.Black, new XRect(50, 195, page.Width, page.Height));
            textFormatter.DrawString(peso.ToString(), arial_7, XBrushes.Black, new XRect(50, 207, page.Width, page.Height));

            textFormatter.DrawString("Volumes", arial_9_bold, XBrushes.Black, new XRect(185, 195, page.Width, page.Height));
            textFormatter.DrawString(volume.ToString(), arial_7, XBrushes.Black, new XRect(185, 207, page.Width, page.Height));

            textFormatter.DrawString("Destinação Comercial", arial_9_bold, XBrushes.Black, new XRect(335, 195, page.Width, page.Height));
            textFormatter.DrawString(destinacao_comercial, arial_7, XBrushes.Black, new XRect(335, 207, page.Width, page.Height));

            textFormatter.DrawString("Taxa de Câmbio", arial_9_bold, XBrushes.Black, new XRect(440, 195, page.Width, page.Height));
            textFormatter.DrawString(cambio.ToString(), arial_7, XBrushes.Black, new XRect(440, 207, page.Width, page.Height));

            textFormatter.DrawString("Valor Total Remessa", arial_9_bold, XBrushes.Black, new XRect(50, 220, page.Width, page.Height));
            textFormatter.DrawString("US$ " + remessa_dolar + " / R$ " + remessa_real, arial_7, XBrushes.Black, new XRect(50, 232, page.Width, page.Height));

            SaveFile("arquivo", doc);
        }
        
        private static void SaveFile(string file_name, PdfDocument pdf)
        {
            pdf.Save(file_name + ".pdf");
            Process.Start(file_name + ".pdf");
        }
    }
}
