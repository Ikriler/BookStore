using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWpf.Models
{
    public class Order
    {
        public int id { get; set; }
        public Status status { get; set; }
        public DateTime? dateTime { get; set; }
        public User user { get; set; }
        public double? amountPrice { get; set; }
        public List<OrderProduct> orderProducts { get; set; }
    }
}
