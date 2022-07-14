using Microsoft.EntityFrameworkCore;
namespace app.Models

{
    public class ProductDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDatabase.db");
        }
        public ProductDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product>? Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(options =>
            {
                options.HasKey(e => e.ProductCode);
                options.Property(e => e.ProductCode).ValueGeneratedNever();
                options.HasData(
                    new Product()
                    {
                        ProductCode = 82621,
                        Name = "بوت بوفالو",
                        Price = 285000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "images/82621.jpg"
                    },
                    new Product()
                    {
                        ProductCode = 45246,
                        Name = "ونس",
                        Price = 220000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "images/45246.jpg"
                    },
                    new Product()
                    {
                        ProductCode = 62183,
                        Name = "ایرجردن وان",
                        Price = 360000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "images/62183.jpg"
                    },
                    new Product()
                    {
                        ProductCode = 87239,
                        Name = "نایک",
                        Price = 250000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "images/87239.jpg"
                    },
                    new Product()
                    {
                        ProductCode = 94850,
                        Name = "کالج پازلی",
                        Price = 180000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "images/94850.jpg"
                    });
            });
        }
    }
}
