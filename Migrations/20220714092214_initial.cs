using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colleges",
                columns: table => new
                {
                    ClgID = table.Column<byte>(type: "INTEGER", nullable: false),
                    Clgname = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Pname = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colleges", x => x.ClgID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    GPA = table.Column<float>(type: "REAL", nullable: false),
                    ClgID = table.Column<byte>(type: "INTEGER", nullable: true),
                    ImageName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_Colleges_ClgID",
                        column: x => x.ClgID,
                        principalTable: "Colleges",
                        principalColumn: "ClgID");
                });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "ClgID", "City", "Clgname", "Pname" },
                values: new object[] { (byte)1, "تهران", "کامپیوتر", "حسنی" });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "ClgID", "City", "Clgname", "Pname" },
                values: new object[] { (byte)2, "خرم آباد", "حقوق", "ناصری" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "City", "ClgID", "GPA", "ImageName", "Name", "Surname" },
                values: new object[] { 9711, "شیراز", (byte)1, 18.24f, null, "علی", "علوی" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "City", "ClgID", "GPA", "ImageName", "Name", "Surname" },
                values: new object[] { 9833, "کاشان", (byte)2, 15.97f, null, "رضا", "فرزامی" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "City", "ClgID", "GPA", "ImageName", "Name", "Surname" },
                values: new object[] { 9900, "یزد", (byte)1, 16.77f, null, "فاطمه", "صادقی" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClgID",
                table: "Students",
                column: "ClgID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Colleges");
        }
    }
}
