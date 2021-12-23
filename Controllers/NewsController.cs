using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrintLayer.Models;
using PrintLayer.Services;
using PrintLayer.Services.Interfaces;

namespace PrintLayer.Controllers
{
    [Route("[controller]")]
    public class NewsController : Controller
    {
        private readonly ICommonService<News> _commonService;

        public NewsController(ICommonService<News> commonService)
        {
            _commonService = commonService;
        }

        [HttpPost]
        public async Task Add(News news)
        {
            await _commonService.AddAsync(news);
        }
    }
}
