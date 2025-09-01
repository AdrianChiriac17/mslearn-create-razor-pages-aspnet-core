using ContosoPizza.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ContosoPizza.Data
{
    public class PizzaContextFactory : IDesignTimeDbContextFactory<PizzaContext>
    {
        public PizzaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PizzaContext>();
            optionsBuilder.UseSqlServer("Server=tcp:adrian-pizza-server.database.windows.net,1433;Initial Catalog=adrian-pizza-db;Persist Security Info=False;User ID=AdrianPizzaru;Password=Ilovepi55a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            return new PizzaContext(optionsBuilder.Options);
        }
    }
}
