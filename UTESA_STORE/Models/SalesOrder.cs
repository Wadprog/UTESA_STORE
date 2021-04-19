using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTESA_STORE.Models
{
    public class SalesOrder
    {


        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public int ProductId { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public int SellerId { get; set; }
        public string Seller { get; set; }
        public DateTime Purchase_Date { get; set; }





    }
}
