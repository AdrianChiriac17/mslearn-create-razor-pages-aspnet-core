using Microsoft.EntityFrameworkCore;
using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace ContosoPizza.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {


        }
        public DbSet<ContosoPizza.Models.Pizza>? Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Pizza entity
            modelBuilder.Entity<Pizza>(entity =>
            {
                // Price column with proper decimal type for SQL Server
                entity.Property(p => p.Price)
                      .HasColumnType("decimal(18,2)")
                      .IsRequired();

                // Size enum stored as string (nvarchar(50))
                entity.Property(p => p.Size)
                      .HasConversion(new EnumToStringConverter<PizzaSize>())
                      .HasMaxLength(50)
                      .IsRequired();

                // Configure other properties here as needed
                // e.g., entity.Property(p => p.Name).HasMaxLength(100).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }


}
