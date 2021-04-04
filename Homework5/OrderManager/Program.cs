using System;
using System.Collections.Generic;

namespace OrderManager
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                var pencil = new Good("pencil", 1);
                var pen = new Good("pen", 2);
                var eraser = new Good("eraser", 0.5);
                var myOrder = new OrderService();
                myOrder.AddOrder(1, "Alice");
                myOrder.AddGood(pencil);
                myOrder.AddGood(pen);
                myOrder.AddGood(eraser);
                Console.WriteLine(myOrder.ShowGoods());
                myOrder.AddGoodIntoOrder(1, new OrderDetails(pencil, 10));
                Console.WriteLine(myOrder.ShowOrder(1));
                myOrder.AddOrder(2, "Bob");
                myOrder.AddGoodIntoOrder(2, new OrderDetails(pencil, 100));
                myOrder.AddGoodIntoOrder(2, new OrderDetails(pen, 5));
                var orders = myOrder.Query();
                orders.ForEach(Console.WriteLine);
                foreach (var o in myOrder.Query(o => o.Customer == "Alice"))
                {
                    Console.WriteLine(o);
                }
                myOrder.Sort((x, y) => y.TotalPrice.CompareTo(x.TotalPrice));
                orders = myOrder.Query();
                orders.ForEach(Console.WriteLine);
                myOrder.DeleteOrder(1);
                myOrder.DeleteOrder(2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
