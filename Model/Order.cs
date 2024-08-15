using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC.Model
{
    internal class Order
    {
        public int OrderId { get; set; }
        public string address { get; set; }
        public DateTime createdAt { get; set; }
    }
}
