using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
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
            
        }
    }
}
