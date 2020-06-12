using GlobalHost.Controlador;
using GlobalHost.Properties;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;

namespace GlobalHost.API
{
    class Boleto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Qualidade do Código", "IDE0067: Descartar objetos antes de perder o escopo", Justification = "...")]
        public static void Create(double val)
        {
            DateTime data_base = new DateTime(1997, 10, 7);
            double n = (DateTime.Now - data_base).TotalDays;
            
            string cod = "34190.50095 40144.816069 06809.350314 3 " + Convert.ToInt32(n) + "";
            bool result = true;
            int p = 10000000;
            while(result)
            {
                if(val < p)
                {
                    cod += "0";
                    p /= 10;
                }
                else
                {
                    result = false;
                    string str = val.ToString();
                    if (str.Contains(",") || str.Contains("."))
                        str = str.Replace(",", "").Replace(".", "");
                    else
                        str += "00";
                    cod += str;
                }
            }
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            XGraphics graphics = XGraphics.FromPdfPage(page);
            XTextFormatter textFormatter = new XTextFormatter(graphics);
            XFont arial_16_bold = new XFont("Arial", 16, XFontStyle.Bold);
            XFont arial_12_bold = new XFont("Arial", 12, XFontStyle.Bold);
            XFont arial_10_bold = new XFont("Arial", 9, XFontStyle.Bold);
            XPen line = new XPen(XColor.FromArgb(0, 0, 0));

            MemoryStream stream = new MemoryStream();
            Controle_Parametro.getLogo().Save(stream, ImageFormat.Png);
            XImage logo = XImage.FromStream(stream);
            stream.Dispose();

            stream = new MemoryStream();
            Resources.bba.Save(stream, ImageFormat.Png);
            XImage bank = XImage.FromStream(stream);
            stream.Dispose();

            //LOGO
            graphics.DrawImage(logo, 25, 30, Controle_Parametro.getLogo().Width - 20, Controle_Parametro.getLogo().Height);

            //LINHA 1
            graphics.DrawImage(bank, 25, 110, Resources.bba.Width, Resources.bba.Height);
            graphics.DrawLine(line, 25 + Resources.bba.Width + 10, 110, 25 + Resources.bba.Width + 10, 137);
            textFormatter.DrawString("341-9", arial_16_bold, XBrushes.Black, new XRect(Resources.bba.Width + 40, 115, page.Width, page.Height));
            graphics.DrawLine(line, Resources.bba.Width + 90, 110, Resources.bba.Width + 90, 137);
            textFormatter.DrawString(cod, arial_12_bold, XBrushes.Black, new XRect(Resources.bba.Width + 115, 115, page.Width, page.Height));
            graphics.DrawLine(line, 25, 137, 550, 137);

            //LINHA 2
            graphics.DrawLine(line, 25, 137, 25, 160);
            graphics.DrawLine(line, 25, 160, 550, 160);
            graphics.DrawLine(line, 550, 160, 550, 137);
            textFormatter.DrawString("Local de pagamento", arial_10_bold, XBrushes.Black, new XRect(30, 137, page.Width, page.Height));

            doc.Save("Boleto.pdf");
            Process.Start("Boleto.pdf");
        }
    }
}