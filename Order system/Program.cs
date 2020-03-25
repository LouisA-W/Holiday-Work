using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Order_system
{
    class Program
    {
        class Order
        {
            private int OrderNumber;
            private string date;
            private List<Product> ProductsOrdered = new List<Product>();
            //private int NumItems;
            OrderStatus status = new OrderStatus(true);

                public Order(int n, string d)
            {
                OrderNumber = n;
                date = d;
            }
            public void OrderItem(Product product)
            {               
                ProductsOrdered.Add(product);
            }
            public bool getStatus() => status.getStatus();
            public string GetID(int i) => ProductsOrdered[i-1].getID();
            public double GetPrice(int i) => ProductsOrdered[i-1].getPrice();
        }
        class OrderStatus
        {
            private bool HasShipped;
            public OrderStatus(bool x)
            {
                HasShipped = x;
            }
            public bool getStatus() => HasShipped;
        }
        class Product
        {          
            private string ProductID;
            private double ProductPrice;
            public Product(string a, double b)
            {
                ProductID = a;
                ProductPrice = b;
            }
            public string getID() => ProductID;
            public double getPrice() => ProductPrice;

        }
        static void Main(string[] args)
        {
            Product product1 = new Product("beans", 0.45);
            Product product2 = new Product("eggs", 1.25);

            Order myOrder = new Order(1, "1/1/17");
            myOrder.OrderItem(product1);
            myOrder.OrderItem(product2);
            Console.WriteLine(myOrder.getStatus());
            Console.WriteLine(myOrder.GetID(1));
            Console.WriteLine(myOrder.GetPrice(1));

            Console.WriteLine(myOrder.GetID(2));
            Console.WriteLine(myOrder.GetPrice(2));
            Console.ReadLine();
        }
    }
}