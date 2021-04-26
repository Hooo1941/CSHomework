using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderManager
{
    public class OrderService
    {
        public List<Order> orders = new();

        public OrderService()
        {
            var g = new Good("name", 1);
            AddOrder(1, "Alice");
            AddGoodIntoOrder(1, new OrderDetails(g, 1));
        }

        public void Export()
        {
            var serializerOrder = new XmlSerializer(typeof(List<Order>));
            var writer = new StreamWriter("orders.xml");
            serializerOrder.Serialize(writer, orders);
            writer.Close();
        }

        public void Import()
        {
            var serializerOrder = new XmlSerializer(typeof(List<Order>));
            var fs = new FileStream("orders.xml", FileMode.Open);
            orders = (List<Order>) serializerOrder.Deserialize(fs);
            fs.Close();
        }

        public void AddOrder(uint id, string customerName)
        {
            var temp = new Order(id, customerName);
            if (orders.Count != 0 && Enumerable.Contains(orders, temp)) throw new Exception("multiple order id");
            orders.Add(temp);
        }

        public void DeleteOrder(uint id)
        {
            var temp = new Order(id, "");
            if (!Enumerable.Contains(orders, temp)) throw new Exception("Order not exist");
            orders.Remove(temp);
        }

        public string ShowOrder(uint id)
        {
            foreach (var order in orders.Where(order => order.Id == id))
            {
                return order.ToString();
            }

            return "Order not exists";
        }

        public void AddGoodIntoOrder(uint id, OrderDetails detail)
        {
            var b = false;
            foreach (var o in orders.Where(o => o.Id == id))
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
            foreach (var g in orders.Where(g => g.Id == ID))
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
            foreach (var g in orders.Where(g => g.Id == ID))
            {
                b = true;
                if (!Enumerable.Contains(g.Goods, detail))
                    throw new Exception("good not exists");
                g.Goods.Remove(detail);
                g.Goods.Add(detail);
            }
            if (!b) throw new Exception("ID not exist");
        }

        public void ChangeGoodIntoOrder(uint ID, List<OrderDetails> detail)
        {
            var b = false;
            foreach (var g in orders.Where(g => g.Id == ID))
            {
                b = true;
                g.Goods.Clear();
                detail.ForEach(i => g.Goods.Add(i));
            }
            if (!b) throw new Exception("ID not exist");
        }
        public void Sort()
        {
            orders.Sort((x, y) => x.Id.CompareTo(y.Id));
        }
        public void Sort(Comparison<Order> comparison)
        {
            orders.Sort(comparison);
        }
        public List<Order> Query()
        {
            return orders;
        }
        public IEnumerable<Order> Query(Predicate<Order> p)
        {
            return orders.Where(o => p(o));
        }
    }
}