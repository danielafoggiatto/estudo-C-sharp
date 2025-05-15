namespace ConsoleApp41
{

    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product{ Name = "Berries", Price = 2.99},
                new Product{ Name = "Apple", Price = 0.99}, 
                new Product{ Name = "Banana", Price = 1.99}
            };

            //products.Add(new Product { Name = "Berries", Price = 2.99 });  

            foreach (Product product in products)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price}");
            }


            //agora, para pegar somente os itens < 1.00
            List<Product> moreCheaper =  products.Where(p => p.Price < 1.0).ToList();
            Console.WriteLine("Cheaper List");
            foreach (Product product in moreCheaper)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price}");
            }


            //variVEL NULA
            //int? age = null;

        }
    }
}
