using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    public class Good
    {
        [Key]
        public int GoodId { get; set; }

        private double price;
        public string Name { get; set; }
        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new Exception("the price must be positive");
                price = value;
            }
        }

        public Good()
        {
        }
        public Good(string name, double price)
        {
            if (price < 0)
                throw new Exception("the price must be positive");
            Name = name;
            this.price = price;
        }

        protected bool Equals(Good other)
        {
            return Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Good) obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return $"ProductName:{Name}, unit price:{Price}";
        }
    }
}
