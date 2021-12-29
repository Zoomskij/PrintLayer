using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PrintLayer.Models;
using PrintLayer.Repositories.Interfaces;
using PrintLayer.Services.Interfaces;

namespace PrintLayer.Services
{
    public class PdfService : IPdfService
    {

        public PdfService() 
        {

        }

        public void GetPdf()
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            gfx.DrawString("Sample text!", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

            const string filename = "Sample.pdf";
            document.Save(filename);
            //Process.Start(filename);

        }

    }
}
