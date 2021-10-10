using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.Models
{
    public class OrderDomain
    {
        public Order Order { get; set; }
        public Membership Membership { get; set; }
    }
}
