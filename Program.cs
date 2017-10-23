using System;
using System.Linq;
using System.Collections.Generic;


namespace LiveCode4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContex())
            {
                
                var categories = db.Categories
                    .Where(x => x.Id < 100);
            
                var order = db.Orders
                    .Where(x => x.Id < 10256);

                var product = db.Products
                    .Where(x => x.ProductId < 10);


                var addCategory = new Category
                {
                    Name = "Cake",
                    Description = "cupcake"
                };
                
                
                db.Categories.Add(addCategory);
                db.SaveChanges();


                foreach (var category in categories)
                {

                    Console.WriteLine(category.Id + "|\t|" + category.Name + "\t|" + category.Description);
                }
                foreach (var orders in order)
                {
                    Console.WriteLine(orders.ShipAddress + "|\t|" + orders.OrderDate + "|\t|" + orders.OrderId);
                }
                foreach (var products in product)
                {
                    Console.WriteLine(products.UnitPrice + "|\t|" + "|\t|" + products.UnitsInStock);
                        
                }
              

                

                //var category = db.Categories.FirstOrDefault(
                //    x => x.Id == 11);

                // update
                //if (category != null)
                //{
                //    category.Name = "2017 Testing";
                //}

                // delete
                //db.Categories.Remove(category);


            }
            Console.ReadLine();
        }
    }
}
