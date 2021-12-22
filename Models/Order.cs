using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintLayer.Models
{
    public class Order : BaseEntity
    {
        public OrderStatus Status { get; set; }
    }
}
