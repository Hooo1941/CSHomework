using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderWebApi.Models
{
    public class Good
    {
        [Key]
        public long GoodId { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public long OrderId { get; set; } //自动识别为外键
    }
}
