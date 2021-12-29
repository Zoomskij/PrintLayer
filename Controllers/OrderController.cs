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
    public class OrderController : Controller
    {
        private readonly ICommonService<Order> _commonService;
        private readonly IAuthService _authService;
        public OrderController(ICommonService<Order> commonService, IAuthService authService)
        {
            _commonService = commonService;
            _authService = authService;
        }

        [HttpGet]
        public List<Order> Get()
        {
            var orders = _commonService.GetAll().ToList();
            return orders;
        }

        [HttpGet]
        [Route("order/{id}")]
        public async Task<Order> Get(Guid id)
        {
            var order = await _commonService.FindAsync(id);
            return order;
        }

        [HttpPost]
        public async Task Add([FromBody] Order order)
        {
            order.User = await _authService.GetUserByLoginAsync("admin");
            await _commonService.AddAsync(order);
        }

        [HttpPut]
        public async Task Update([FromBody] Order order)
        {
            await _commonService.UpdateAsync(order);
        }
    }
}
