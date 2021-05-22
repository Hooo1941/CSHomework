using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderWebApi.Models
{
    public class Order
    {
        [Key]
        public long OrderId { get; set; }
        public string Customer { get; set; }
        public List<Good> Goods { get; set; }
    }
}
