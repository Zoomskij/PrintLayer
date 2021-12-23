using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpPost]
        [Route("add")]
        public async Task Add(Review review)
        {
            review.User = await _authService.GetUserByLoginAsync("admin");
            await _commonService.AddAsync(review);
        }

    }
}
