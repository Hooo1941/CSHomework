using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManager
{
    internal class Order
    {
        public Order(uint id, string customer)
        {
            Id = id;
            Customer = customer;
            Goods = new List<OrderDetails>();
            OrderTime = DateTime.Now;
        }

        public uint Id { get; set; }
        public string Customer { get; set; }

        public List<OrderDetails> Goods { get; set; }

        public double TotalPrice => Goods.Sum(g => g.Price);

        public DateTime OrderTime { get; set; }

        protected bool Equals(Order other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Order) obj);
        }

        public override int GetHashCode()
        {
            return (int) Id;
        }

        public override string ToString()
        {
            var tmp = $"OrderID:{Id}, Customer:{Customer}, OrderTime:{OrderTime}\n";
            return Goods.Aggregate(tmp, (current, g) => current + (g + "\n")) + $"Total price:{TotalPrice}\n";
        }
    }
}