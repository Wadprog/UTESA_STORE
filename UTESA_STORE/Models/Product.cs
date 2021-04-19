using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTESA_STORE.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int Stock { get; set; }
        public double UnitPrice { get; set; }

    }
}
