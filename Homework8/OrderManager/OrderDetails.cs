using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    public class OrderDetails
    {
        public Good Good { get; set; }
        public int Amount { get; set; }
        public OrderDetails() { }
        public OrderDetails(Good good, int amount)
        {
            if (amount <= 0)
            {
                throw new Exception("the amount must be positive");
                return;
            }
            Good = good;
            Amount = amount;
        }
        public double Price => Good.Price * Amount;

        protected bool Equals(OrderDetails other)
        {
            return Equals(Good, other.Good);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((OrderDetails) obj);
        }

        public override int GetHashCode()
        {
            return (Good != null ? Good.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return $"{Good}, Amount:{Amount}, Price:{Price}";
        }
    }
}
