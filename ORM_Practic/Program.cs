using ORM_Practic.Contexts;
using ORM_Practic.Entities;

namespace ORM_Practic
{
    public class Program
    {
        static void Main(string[] args)
        {
            using ShowDbContext context = new ShowDbContext();

            var category=new Category
            {
                Name = "Book",
                Description = "Salam"
            };
            context.Categories.Add(category);
            context.SaveChanges();

            //for (int i = 0; i < 100; i++)
            //{
            //    context.Products.Add(new Product
            //    {
            //        Name = "Book",
            //        Price = Random.Shared.Next(100, 1500),
            //        Quantity = Random.Shared.Next(1,50),
            //        CategoryId = 1

            //    });
            //}
            //context.SaveChanges();

            //var list = context.Products.Where(p => p.Price > 1000).ToList();
            //foreach(var item in list)
            //{
            //    Console.WriteLine(item.Price);
            //}
        }
    }
}