using GlobalHost.Controlador;
using GlobalHost.Properties;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.API
{
    class Boleto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Qualidade do Código", "IDE0067:Descartar objetos antes de perder o escopo", Justification = "...")]
        public static void Create()
        {
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            XGraphics graphics = XGraphics.FromPdfPage(page);
            XTextFormatter textFormatter = new XTextFormatter(graphics);
            XFont arial_10_bold = new XFont("Century Gothic", 10.5, XFontStyle.Bold);
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
            graphics.DrawImage(bank, 25, 110, Resources.bba.Width, Resources.bba.Height);
            graphics.DrawLine(line, 25 + Resources.bba.Width + 10, 110, 25 + Resources.bba.Width + 10, 137);

            doc.Save("Boleto.pdf");
            Process.Start("Boleto.pdf");
        }
    }
}
