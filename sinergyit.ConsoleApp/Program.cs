using sinergyit.Context;
using sinergyit.Entities;
using sinergyit.Repos;

class Program
{
    static void Main(string[] args)
    {
        using var context = new AppDbContext();
        var repo = new ProductRepository(context);

        repo.Add(new Product
        {
            Name = "Kalem",
            Price = 10
        });

        var products = repo.GetAll();
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Id} - {p.Name} - {p.Price}");
        }

        var product = repo.GetById(1);
        product.Price = 20;
        repo.Update(product);

        repo.Delete(product.Id);
    }
}
