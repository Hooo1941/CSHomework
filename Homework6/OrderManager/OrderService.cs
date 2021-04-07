using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderManager
{
    public class OrderService
    {
        private List<Good> _goods = new();
        private List<Order> _orders = new();

        public void Export()
        {
            var serializerGood = new XmlSerializer(typeof(List<Good>));
            var writer = new StreamWriter("goods.xml");
            serializerGood.Serialize(writer, _goods);
            writer.Close();
            var serializerOrder = new XmlSerializer(typeof(List<Order>));
            writer = new StreamWriter("orders.xml");
            serializerOrder.Serialize(writer, _orders);
            writer.Close();
        }

        public void Import()
        {
            var serializerGood = new XmlSerializer(typeof(List<Good>));
            var fs = new FileStream("goods.xml", FileMode.Open);
            _goods = (List<Good>) serializerGood.Deserialize(fs);
            fs.Close();
            var serializerOrder = new XmlSerializer(typeof(List<Order>));
            fs = new FileStream("orders.xml", FileMode.Open);
            _orders = (List<Order>) serializerOrder.Deserialize(fs);
            fs.Close();
        }

        public void AddGood(string name, double price)
        {
            var temp = new Good(name, price);
            //if (_goods.Any(g => g.Name == name))
            if (Enumerable.Contains(_goods, temp)) //use the equal function
                throw new Exception("multiple good name");
            _goods.Add(temp);
        }

        public void AddGood(Good good)
        {
            //if (_goods.Any(g => g.Name == name))
            if (Enumerable.Contains(_goods, good)) //use the equal function
                throw new Exception("multiple good name");
            _goods.Add(good);
        }

        public string ShowGoods()
        {
            return _goods.Aggregate("", (current, good) => current + good + "\n");
        }

        public void AddOrder(uint id, string customerName)
        {
            var temp = new Order(id, customerName);
            if (_orders.Count != 0 && Enumerable.Contains(_orders, temp)) throw new Exception("multiple order id");
            _orders.Add(temp);

        }

        public void DeleteOrder(uint id)
        {
            var temp = new Order(id, "");
            if (!Enumerable.Contains(_orders, temp)) throw new Exception("Order not exist");
            _orders.Remove(temp);
        }

        public string ShowOrder(uint id)
        {
            foreach (var order in _orders.Where(order => order.Id == id))
            {
                return order.ToString();
            }

            return "Order not exists";
        }

        public void AddGoodIntoOrder(uint id, OrderDetails detail)
        {
            var b = false;
            foreach (var o in _orders.Where(o => o.Id == id))
            {
                b = true;
                if (Enumerable.Contains(o.Goods, detail))
                    throw new Exception("good already exists");
                o.Goods.Add(detail);
            }

            if (!b) throw new Exception("ID not exist");
        }

        public void DeleteGoodIntoOrder(uint ID, OrderDetails detail)
        {
            var b = false;
            foreach (var g in _orders.Where(g => g.Id == ID))
            {
                b = true;
                if (!Enumerable.Contains(g.Goods, detail))
                    throw new Exception("good not exists");
                g.Goods.Remove(detail);
            }
            if (!b) throw new Exception("ID not exist");
        }

        public void ModifyGoodIntoOrder(uint ID, OrderDetails detail)
        {
            var b = false;
            foreach (var g in _orders.Where(g => g.Id == ID))
            {
                b = true;
                if (!Enumerable.Contains(g.Goods, detail))
                    throw new Exception("good not exists");
                g.Goods.Remove(detail);
                g.Goods.Add(detail);
            }
            if (!b) throw new Exception("ID not exist");
        }
        public void Sort()
        {
            _orders.Sort((x, y) => x.Id.CompareTo(y.Id));
        }
        public void Sort(Comparison<Order> comparison)
        {
            _orders.Sort(comparison);
        }
        public List<Order> Query()
        {
            return _orders;
        }
        public IEnumerable<Order> Query(Predicate<Order> p)
        {
            return _orders.Where(o => p(o));
        }
    }
}