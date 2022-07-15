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
                        ImageName = "82621.jpg"
                    }, new Product()
                    {
                        ProductCode = 45246,
                        Name = "ونس",
                        Price = 220000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "45246.jpg"
                    }, new Product()
                    {
                        ProductCode = 62183,
                        Name = "ایرجردن وان",
                        Price = 360000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "62183.jpg"
                    }, new Product()
                    {
                        ProductCode = 87239,
                        Name = "نایک",
                        Price = 250000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "87239.jpg"
                    }, new Product()
                    {
                        ProductCode = 94850,
                        Name = "کالج پازلی",
                        Price = 180000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "94850.jpg"

                    }, new Product()
                    {
                        ProductCode = 41234,
                        Name = "نیم بوت",
                        Price = 398000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "41234.jpg"
                    }, new Product()
                    {
                        ProductCode = 64368,
                        Name = "سئول",
                        Price = 265000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "64368.jpg"
                    }, new Product()
                    {
                        ProductCode = 12357,
                        Name = "بوت دکتر مارتنز",
                        Price = 410000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "12357.jpg"
                    }, new Product()
                    {
                        ProductCode = 78940,
                        Name = "ایرفورس وان",
                        Price = 310000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "78940.jpg"
                    }, new Product()
                    {
                        ProductCode = 67830,
                        Name = "استن اسمیت",
                        Price = 330000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "67830.jpg"
                    }, new Product()
                    {
                        ProductCode = 29604,
                        Name = "تکنو",
                        Price = 320000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "29604.jpg"
                    }, new Product()
                    {
                        ProductCode = 146097,
                        Name = "نیوبالانس",
                        Price = 320000,
                        Description = "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای",
                        ImageName = "146097.jpg"
                    });
            });
        }
    }
}
