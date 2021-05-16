using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            using var context = new OrderContext();
            var query = context.Orders.OrderBy(o => o.OrderId);
            foreach (var order in query)
            {
                orders.Add(order);
            }

            var goodod = context.Goods.OrderBy(g => g.GoodId);
            var queryod = context.OrderDetails.OrderBy(od => od.OrderDetailsId);
            foreach (var od in queryod)
            {
                foreach (var o in orders.Where(o => o.OrderId == od.OrderId))
                {
                    o.OrderDetails.Add(od);
                }
            }
            foreach (var good in goodod)
            {
                foreach (var od in orders.SelectMany(o => o.OrderDetails.Where(od => od.GoodId == good.GoodId)))
                {
                    od.Good = good;
                }
            }
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
            using var context = new OrderContext();
            foreach (var contextOrder in context.Orders)
            {
                context.Orders.Remove(contextOrder);
            }
            context.SaveChanges();
            foreach (var od in context.OrderDetails)
            {
                context.OrderDetails.Remove(od);
            }
            context.SaveChanges();
            foreach (var g in context.Goods)
            {
                context.Goods.Remove(g);
            }
            context.SaveChanges();
            foreach (var order in orders)
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public int AddOrder(string customerName)
        {
            var temp = new Order(customerName);
            if (orders.Count != 0 && Enumerable.Contains(orders, temp)) throw new Exception("multiple order id");
            using var context = new OrderContext();
            context.Orders.Add(temp);
            context.SaveChanges();
            orders.Add(temp);
            return temp.OrderId;
        }

        public void DeleteOrder(int id)
        {
            var temp = new Order(id, "");
            if (!Enumerable.Contains(orders, temp)) throw new Exception("Order not exist");
            orders.Remove(temp);
            using var context = new OrderContext();
            foreach (var contextOrder in context.Orders.Where(o => o.OrderId == id))
            {
                context.Orders.Remove(contextOrder);
            }
            context.SaveChanges();
        }

        public string ShowOrder(uint id)
        {
            foreach (var order in orders.Where(order => order.OrderId == id))
            {
                return order.ToString();
            }

            return "Order not exists";
        }

        public void ChangeGoodIntoOrder(int ID, List<OrderDetails> detail)
        {
            var b = false;
            var name = "";
            foreach (var o in orders.Where(g => g.OrderId == ID))
            {
                b = true;
                name = o.Customer;
            }
            if (!b) throw new Exception("ID not exist");
            orders.Remove(new Order(ID, ""));
            var g = new Order(name);
            foreach (var od in detail)
            {
                g.OrderDetails.Add(new OrderDetails(new Good(od.Good.Name,od.Good.Price),od.Amount));
            }
            orders.Add(g);
            using var context = new OrderContext();
            foreach (var contextOrder in context.Orders.Where(o => o.OrderId == ID))
            {
                context.Orders.Remove(contextOrder);
            }
            context.SaveChanges();
            context.Orders.Add(g);
            context.SaveChanges();
        }
        public void Sort()
        {
            orders.Sort((x, y) => x.OrderId.CompareTo(y.OrderId));
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