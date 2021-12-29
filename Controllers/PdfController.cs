using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrintLayer.Services.Interfaces;

namespace PrintLayer.Controllers
{
    [Route("[controller]")]
    public class PdfController : Controller
    {
        private readonly IPdfService _pdfService;

        public PdfController(IPdfService pdfService)
        {
            _pdfService = pdfService;
        }

        [HttpGet]
        public void Get()
        {
            _pdfService.GetPdf();
        }
    }
}
