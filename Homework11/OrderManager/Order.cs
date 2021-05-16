using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace OrderManager
{
    public class Order
    {
        public Order()
        { }
        public Order(int orderId, string customer)
        {
            OrderId = orderId;
            Customer = customer;
            OrderDetails = new List<OrderDetails>();
            OrderTime = DateTime.Now;
        }
        public Order(string customer)
        {
            Customer = customer;
            OrderDetails = new List<OrderDetails>();
            OrderTime = DateTime.Now;
        }
        [Key]
        public int OrderId { get; set; }
        public string Customer { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }

        public double TotalPrice => OrderDetails.Sum(g => g.Price);

        public DateTime OrderTime { get; set; }

        protected bool Equals(Order other)
        {
            return OrderId == other.OrderId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Order) obj);
        }

        public override int GetHashCode()
        {
            return (int) OrderId;
        }

        public override string ToString()
        {
            var tmp = $"OrderID:{OrderId}, Customer:{Customer}, OrderTime:{OrderTime}\n";
            return OrderDetails.Aggregate(tmp, (current, g) => current + (g + "\n")) + $"Total price:{TotalPrice}\n";
        }
    }
}