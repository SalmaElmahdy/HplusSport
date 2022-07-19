using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HplusSport.Models
{
    public class User
    {
        public int id { get; set; }

        public string  Email { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
