using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    class Good
    {
        private double _price;
        public string Name { get; }
        public double Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new Exception("the price must be positive");
                _price = value;
            }
        }

        public Good(string name, double price)
        {
            if (price < 0)
                throw new Exception("the price must be positive");
            Name = name;
            _price = price;
        }

        protected bool Equals(Good other)
        {
            return Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Good) obj);
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
