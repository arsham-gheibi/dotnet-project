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
                values: new object[] { 12357, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", "12357.jpg", "بوت دکتر مارتنز", 410000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 29604, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", "29604.jpg", "تکنو", 320000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 41234, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", "41234.jpg", "نیم بوت", 398000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 45246, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", "45246.jpg", "ونس", 220000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 62183, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", "62183.jpg", "ایرجردن وان", 360000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 64368, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", "64368.jpg", "سئول", 265000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 67830, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", "67830.jpg", "استن اسمیت", 330000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 78940, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", "78940.jpg", "ایرفورس وان", 310000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 82621, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", "82621.jpg", "بوت بوفالو", 285000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 87239, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", "87239.jpg", "نایک", 250000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 94850, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", "94850.jpg", "کالج پازلی", 180000f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 146097, "کیفیت خوب، قیمت مناسب و ضمانت مرجوع و یا تعویض سایز یک هفته‌ای", "146097.jpg", "نیوبالانس", 320000f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
