using System.Diagnostics;

namespace GlobalHost.API
{
    class PDF
    {
        public static void Create()
        {
            var doc = new PdfSharp.Pdf.PdfDocument();
            var page = doc.AddPage();
            var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
            var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
            var arial_10_bold = new PdfSharp.Drawing.XFont("Arial", 10.5, PdfSharp.Drawing.XFontStyle.Bold);
            var arial_9_bold = new PdfSharp.Drawing.XFont("Arial", 9.5, PdfSharp.Drawing.XFontStyle.Bold);
            var arial_7 = new PdfSharp.Drawing.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular);

            //titulo
            graphics.DrawRectangle(PdfSharp.Drawing.XBrushes.LightGray, 45, 35, 500, 16);
            textFormatter.DrawString("DECLARAÇÃO DE IMPORTAÇÃO DE REMESSA - DIR", arial_10_bold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(165, 37, page.Width, page.Height));
            graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 45, 35, 545, 35);
            graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 45, 51, 545, 51);

            //Identificação
            graphics.DrawRectangle(PdfSharp.Drawing.XBrushes.LightGray, 45, 55, 500, 13);
            textFormatter.DrawString("Identificação da Remessa", arial_9_bold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 56, page.Width, page.Height));
            graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 45, 55, 545, 55);
            graphics.DrawLine(PdfSharp.Drawing.XPens.Black, 45, 68, 545, 68);

            textFormatter.DrawString("Declaração (DIR)/Versão", arial_9_bold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 70, page.Width, page.Height));
            textFormatter.DrawString("200000367421 / 1", arial_7, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 82, page.Width, page.Height));

            textFormatter.DrawString("Data/Horário Registro DIR", arial_9_bold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(185, 70, page.Width, page.Height));
            textFormatter.DrawString("14/02/2020 09:14", arial_7, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(185, 82, page.Width, page.Height));

            textFormatter.DrawString("Lote DIR", arial_9_bold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(335, 70, page.Width, page.Height));
            textFormatter.DrawString("CGF2020021400057", arial_7, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(335, 82, page.Width, page.Height));

            textFormatter.DrawString("Modalidade", arial_9_bold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(440, 70, page.Width, page.Height));
            textFormatter.DrawString("Expressa", arial_7, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(440, 82, page.Width, page.Height));

            textFormatter.DrawString("Remessa", arial_9_bold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 95, page.Width, page.Height));
            textFormatter.DrawString("07432182953", arial_7, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 107, page.Width, page.Height));

            textFormatter.DrawString("Situação", arial_9_bold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(185, 95, page.Width, page.Height));
            textFormatter.DrawString("Desembaraçada", arial_7, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(185, 107, page.Width, page.Height));

            textFormatter.DrawString("Manifesto", arial_9_bold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(335, 95, page.Width, page.Height));
            textFormatter.DrawString("CGF202000011844", arial_7, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(335, 107, page.Width, page.Height));

            textFormatter.DrawString("Data/Horário Manifesto", arial_9_bold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(440, 95, page.Width, page.Height));
            textFormatter.DrawString("14/02/2020 09:12", arial_7, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(440, 107, page.Width, page.Height));

            textFormatter.DrawString("Master", arial_9_bold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 120, page.Width, page.Height));
            textFormatter.DrawString("07432182953", arial_7, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(50, 132, page.Width, page.Height));



            SaveFile("arquivo", doc);
        }
        
        private static void SaveFile(string file_name, PdfSharp.Pdf.PdfDocument pdf)
        {
            pdf.Save(file_name + ".pdf");
            Process.Start(file_name + ".pdf");
        }
    }
}
