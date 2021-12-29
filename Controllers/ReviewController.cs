using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using PrintLayer.Models;
using PrintLayer.Services.Interfaces;

namespace PrintLayer.Controllers
{
    [Route("[controller]")]
    public class ReviewController : Controller 
    {
        private readonly ICommonService<Review> _commonService;
        private readonly IAuthService _authService;

        public ReviewController( ICommonService<Review> commonService, IAuthService authService)
        {
            _commonService = commonService;
            _authService = authService;
        }

        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<Review> Get()
        {
            var reviews = _commonService.GetAll().ToList();
            return reviews;
        }

        [HttpPost]
        [Route("add")]
        public async Task Add([FromBody] Review review)
        {
            review.User = await _authService.GetUserByLoginAsync("admin");
            await _commonService.AddAsync(review);
        }

        [HttpPut]
        public async Task Update([FromBody] Review review)
        {
            await _commonService.UpdateAsync(review);
        }

    }
}
