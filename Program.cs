using Microsoft.EntityFrameworkCore;
using TaskC.Data;
using TaskC.Model;

namespace TaskC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
                Product p1 = new Product()
                {
                    Name = "Car",
                    Price = 10500,
                };
                Product p2 = new Product()
                {
                    Name = "Bike",
                    Price = 1500,
                };
                Product p3 = new Product()
                {
                    Name = "Laptop",
                    Price = 2500,
                };
                Product p4 = new Product()
                {
                    Name = "Phone",
                    Price = 800,
                };

                dbContext.Products.Add(p1);
                dbContext.Products.Add(p2);
                dbContext.Products.Add(p3);
                dbContext.Products.Add(p4);
                dbContext.SaveChanges();

                Order o1 = new Order()
                {
                    address = "123 Main St",
                    createdAt = DateTime.Now
                };
                Order o2 = new Order()
                {
                    address = "456 Elm St",
                    createdAt = DateTime.Now
                };
                Order o3 = new Order()
                {
                    address = "Jenin",
                    createdAt = DateTime.Now
                };

                dbContext.Orders.Add(o1);
                dbContext.Orders.Add(o2);
                dbContext.Orders.Add(o3);
                dbContext.SaveChanges();

                var getP = dbContext.Products.ToList();
                foreach (var p in getP)
                {
                    Console.WriteLine(p.Name);
                }
                var getO = dbContext.Orders.ToList();
            foreach(var o in getO)
            {
                Console.WriteLine(o.address);
                Console.WriteLine(o.createdAt);
            }

            var updateP = dbContext.Products.First(p=> p.ProductId == 3);
            updateP.Name = "test";
            updateP.Price = 0;

            var updateO = dbContext.Orders.First(o => o.OrderId == 3);
            updateO.address = "test";
            updateO.createdAt = DateTime.Now;
            dbContext.SaveChanges();


            var deleteProduct = dbContext.Products.FirstOrDefault(p => p.ProductId == 2);
            dbContext.Products.Remove(deleteProduct);


            var deleteO = dbContext.Orders.FirstOrDefault(o => o.OrderId == 3);
            dbContext.Orders.Remove(deleteO);
            dbContext.SaveChanges();

        }
    }
}
