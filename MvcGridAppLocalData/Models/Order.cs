using System;
using System.Collections.Generic;

namespace MvcGridWebApp.Models
{
    public class Order
    {
        public long OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public double Freight { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ShipCity { get; set; }

        public Order(long OrderId, string CustomerId, int EmployeeId, double Freight, DateTime? OrderDate, string ShipCity)
        {
            this.OrderID = OrderId;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.OrderDate = OrderDate;
            this.ShipCity = ShipCity;
        }

        public static List<Order> GenerateOrdersList(int count)
        {
            List<Order> orders = new List<Order>();
            int code = 10000;

            for (int i = 1; i <= count; i++)
            {
                orders.Add(new Order(code + 1, "LOFKI", i + 0, 2.3 * i, new DateTime(1991, 05, 15), "Berlin"));
                orders.Add(new Order(code + 2, "ANATR", i + 2, 3.3 * i, new DateTime(2017, 08, 11), "Madrid"));
                orders.Add(new Order(code + 3, "ANTON", i + 1, 4.3 * i, new DateTime(1957, 11, 30), "Cholchester"));
                orders.Add(new Order(code + 4, "BLONP", i + 3, 5.3 * i, new DateTime(2019, 11, 11), "Marseille"));
                orders.Add(new Order(code + 5, "BOLID", i + 4, 6.3 * i, new DateTime(1953, 02, 18), "Tsawassen"));
                code += 5;
            }

            return orders;
        }
    }
}
