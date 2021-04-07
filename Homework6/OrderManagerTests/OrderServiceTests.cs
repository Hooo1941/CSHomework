using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void ExportAndImportTest()
        {
            var os = new OrderService();
            os.AddGood("a",12.0);
            os.AddGood("b",11.11);
            os.AddOrder(1,"Alice");
            var goods = os.ShowGoods();
            var orders = os.ShowOrder(1);
            os.Export();
            os.Import();
            Assert.IsTrue(os.ShowGoods() == goods && os.ShowOrder(1) == orders);
        }

        [TestMethod()]
        public void AddGoodTest()
        {
            var os = new OrderService();
            os.AddGood("a",12.0);
            try
            {
                os.AddGood("a", 12.0);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e.Message != "multiple good name")
                    Assert.Fail();
            }
        }

        [TestMethod()]
        public void ShowGoodsTest()
        {
            var os = new OrderService();
            os.AddGood("a", 12);
            os.AddGood("b", 1);
            Assert.IsTrue(os.ShowGoods() == "ProductName:a, unit price:12\nProductName:b, unit price:1\n");
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            var os = new OrderService();
            os.AddOrder(1,"a");
            try
            {
                os.AddOrder(1, "b");
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e.Message != "multiple order id")
                    Assert.Fail();
            }
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            var os = new OrderService();
            os.AddOrder(1, "a");
            os.DeleteOrder(1);
            try
            {
                os.AddOrder(1, "b");
                os.DeleteOrder(2);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e.Message != "Order not exist")
                    Assert.Fail();
            }
        }

        [TestMethod()]
        public void AddGoodIntoOrderTest()
        {
            var os = new OrderService();
            os.AddOrder(1, "a");
            var g = new Good("a", 1);
            os.AddGoodIntoOrder(1,new OrderDetails(g,1));
            try
            {
                os.AddGoodIntoOrder(1, new OrderDetails(g, 1));
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e.Message != "good already exists")
                    Assert.Fail();
            }
            try
            {
                os.AddGoodIntoOrder(2, new OrderDetails(g, 1));
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e.Message != "ID not exist")
                    Assert.Fail();
            }
        }

        [TestMethod()]
        public void DeleteGoodIntoOrderTest()
        {
            var os = new OrderService();
            os.AddOrder(1, "a");
            var g = new Good("a", 1);
            os.AddGoodIntoOrder(1, new OrderDetails(g, 1));
            os.DeleteGoodIntoOrder(1, new OrderDetails(g, 1));
            try
            {
                os.DeleteGoodIntoOrder(1, new OrderDetails(g, 1));
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e.Message != "good not exists")
                    Assert.Fail();
            }
            try
            {
                os.AddGoodIntoOrder(2, new OrderDetails(g, 1));
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e.Message != "ID not exist")
                    Assert.Fail();
            }
        }

        [TestMethod()]
        public void ModifyGoodIntoOrderTest()
        {
            var os = new OrderService();
            os.AddOrder(1, "a");
            var g = new Good("a", 1);
            os.AddGoodIntoOrder(1, new OrderDetails(g, 1));
            os.ModifyGoodIntoOrder(1, new OrderDetails(g, 5));
            os.DeleteGoodIntoOrder(1, new OrderDetails(g, 5));
            try
            {
                os.ModifyGoodIntoOrder(1, new OrderDetails(g, 1));
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e.Message != "good not exists")
                    Assert.Fail();
            }
            try
            {
                os.AddGoodIntoOrder(2, new OrderDetails(g, 1));
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e.Message != "ID not exist")
                    Assert.Fail();
            }
        }

        [TestMethod()]
        public void SortAndQueryTest()
        {
            var os = new OrderService();
            os.AddOrder(1, "a");
            os.AddOrder(2,"b");
            os.Sort((x, y) => string.Compare(y.Customer, x.Customer, StringComparison.Ordinal));
            Assert.IsTrue(os.Query()[1].Id == 1);
            os.Sort();
            Assert.IsTrue(os.Query()[1].Id == 2);
        }
    }
}