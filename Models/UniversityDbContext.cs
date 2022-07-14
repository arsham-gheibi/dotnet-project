using Microsoft.EntityFrameworkCore;

namespace app.Models
{
    public class UniversityDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDatabase.db");
        }
        public UniversityDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<College>? Colleges { get; set; }
        public DbSet<Student>? Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<College>(options =>
            {
                options.HasKey(e => e.ClgID);
                options.Property(e => e.ClgID).ValueGeneratedNever();

                options.HasData(
                    new College() { ClgID = 1, Clgname = "کامپیوتر", City = "تهران", Pname = "حسنی" },
                    new College() { ClgID = 2, Clgname = "حقوق", City = "خرم آباد", Pname = "ناصری" });

            });

            modelBuilder.Entity<Student>(options =>
            {
                options.HasKey(e => e.StudentID);
                options.Property(e => e.StudentID).ValueGeneratedNever();

                options.HasOne(e => e.College)
                .WithMany(e => e.Students)
                .HasForeignKey(e => e.ClgID);

                options.HasData(
                    new Student() { StudentID = 9711, Name = "علی", Surname = "علوی", City = "شیراز", GPA = 18.24f, ClgID = 1 },
                    new Student() { StudentID = 9833, Name = "رضا", Surname = "فرزامی", City = "کاشان", GPA = 15.97f, ClgID = 2 },
                    new Student() { StudentID = 9900, Name = "فاطمه", Surname = "صادقی", City = "یزد", GPA = 16.77f, ClgID = 1 }
                    );
            });


        }
    }
}
