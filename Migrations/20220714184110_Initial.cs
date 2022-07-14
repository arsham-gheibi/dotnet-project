using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductCode = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Price = table.Column<float>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductCode);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 45246, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", null, "ونس", 220000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 62183, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", null, "ایرجردن وان", 360000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 82621, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", null, "بوت بوفالو", 285000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 87239, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", null, "نایک", 250000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 94850, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", null, "کالج پازلی", 180000f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
