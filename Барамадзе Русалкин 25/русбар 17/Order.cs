using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR17
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return $"Order {Id}: {Total:C}";
        }
    }
}
