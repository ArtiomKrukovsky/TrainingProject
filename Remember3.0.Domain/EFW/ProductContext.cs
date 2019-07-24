namespace Remember3._0.Domain.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("name=ProductContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }

    public class Init: DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            context.Products.Add(new Product {ProductId=1, Name="IPhone XS", Price=1500 });
            base.Seed(context);
        }
    }

}