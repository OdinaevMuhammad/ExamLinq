using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task8.Dtos
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int Amount { get; set; }
    }
}