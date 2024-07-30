using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Books_BookId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropIndex(
                name: "IX_Orders_BookId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "FinePaid",
                table: "Orders",
                newName: "CarId");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Orders",
                newName: "AmountPaid");

            migrationBuilder.CreateTable(
                name: "CarCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Ordered = table.Column<bool>(type: "bit", nullable: false),
                    CarCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarCategories_CarCategoryId",
                        column: x => x.CarCategoryId,
                        principalTable: "CarCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarCategories",
                columns: new[] { "Id", "Category", "SubCategory" },
                values: new object[,]
                {
                    { 1, "computer", "algorithm" },
                    { 2, "computer", "programming languages" },
                    { 3, "computer", "networking" },
                    { 4, "computer", "hardware" },
                    { 5, "mechanical", "machine" },
                    { 6, "mechanical", "transfer of energy" },
                    { 7, "mathematics", "calculus" },
                    { 8, "mathematics", "algebra" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarCategoryId", "Name", "Ordered", "Owner", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Introduction to Algorithm", false, "Thomas Corman", 100f },
                    { 2, 1, "Introduction to Algorithm", false, "Thomas Corman", 100f },
                    { 3, 1, "Algorithms", false, "Robert Sedgewick & Kevin Wayne", 200f },
                    { 4, 1, "The Algorithm Design Manual", false, "Steve Skiena", 300f },
                    { 5, 1, "Algorithms For Interviews", false, "Adnan Aziz", 400f },
                    { 6, 1, "Algorithms For Interviews", false, "Adnan Aziz", 400f },
                    { 7, 1, "Algorithms For Interviews", false, "Adnan Aziz", 400f },
                    { 8, 1, "Algorithm in Nutshell", false, "George Heineman", 500f },
                    { 9, 1, "Klienberg & Tardos", false, "Algorithm Design", 600f },
                    { 10, 2, "Python Crash Course: A Hands-On, Project-Based Introduction to Programming", false, "Eric Matthes", 700f },
                    { 11, 2, "Python Crash Course: A Hands-On, Project-Based Introduction to Programming", false, "Eric Matthes", 700f },
                    { 12, 2, "Python Crash Course: A Hands-On, Project-Based Introduction to Programming", false, "Eric Matthes", 700f },
                    { 13, 2, "Head First Python: A Brain-Friendly Guide", false, "Paul Barry", 800f },
                    { 14, 2, "Effective Java", false, "Joshua Bloch", 900f },
                    { 15, 2, "Effective Java", false, "Joshua Bloch", 900f },
                    { 16, 2, "Head First Java", false, "Kathy Sierra and Bert Bates", 1000f },
                    { 17, 2, "C Programming Language", false, "Brian W. Kernighan, Dennis M. Ritchie", 1100f },
                    { 18, 2, "C Programming Language", false, "Brian W. Kernighan, Dennis M. Ritchie", 1100f },
                    { 19, 2, "C Programming Language", false, "Brian W. Kernighan, Dennis M. Ritchie", 1100f },
                    { 20, 2, "Eloquent JavaScript: A Modern Introduction to Programming", false, "Marijn Haverbeke", 1200f },
                    { 21, 2, "The Art of Computer Programming", false, "Donald E. Knuth", 1300f },
                    { 22, 2, "The Art of Computer Programming", false, "Donald E. Knuth", 1300f },
                    { 23, 3, "A Top-Down Approach: Computer Networking", false, "James F Kurose and Keith W Ross", 1400f },
                    { 24, 3, "The All-New Switch Book (2nd Edition)", false, "Rich Seifert and James Edwards", 1500f },
                    { 25, 3, "The All-New Switch Book (2nd Edition)", false, "Rich Seifert and James Edwards", 1500f },
                    { 26, 3, "Business Data Communications and Networking (14th Edition)", false, "Jerry FitzGerald, Alan Dennis, and Alexandra Durcikova", 1600f },
                    { 27, 3, "Data Communications and Networking with TCP/IP Protocol Suite, 6th Edition", false, "Forouzan", 1700f },
                    { 28, 3, "Network Warrior, 2nd Edition", false, "Gary Donahue", 1800f },
                    { 29, 3, "Network Warrior, 2nd Edition", false, "Gary Donahue", 1800f },
                    { 30, 3, "Network Warrior, 2nd Edition", false, "Gary Donahue", 1800f },
                    { 31, 4, "Microprocessor Architecture, Programming, and Applications with the 8085 (4th Edition)", false, "Ramesh Gaonkar", 1900f },
                    { 32, 4, "Microprocessors and Interfacing: Programming and Hardware (Hardcover)", false, "Douglas V. Hall", 2000f },
                    { 33, 4, "Microprocessors and Interfacing: Programming and Hardware (Hardcover)", false, "Douglas V. Hall", 2000f },
                    { 34, 4, "Embedded Microprocessor Systems Design", false, "Kenneth L. Short", 2100f },
                    { 35, 4, "Digital Electronics & Microprocessor", false, "Dr. Vibhav Kumar Sachan", 2200f },
                    { 36, 4, "Real-Time Embedded Systems", false, "Xiaocong Fan", 2300f },
                    { 37, 4, "Digital Interface Design and Application", false, "Jonathan A. Dell", 2400f },
                    { 38, 5, "Richard G. Budynas and Keith J. Nisbett", false, "Shigley's Mechanical Engineering Design", 2500f },
                    { 39, 5, "Richard G. Budynas and Keith J. Nisbett", false, "Shigley's Mechanical Engineering Design", 2500f },
                    { 40, 5, "Richard G. Budynas and Keith J. Nisbett", false, "Shigley's Mechanical Engineering Design", 2500f },
                    { 41, 5, "Machinery's Handbook", false, "Erik Oberg", 2600f },
                    { 42, 5, "Introduction to Robotics: Mechanics and Control", false, "John J. Craig", 2700f },
                    { 43, 5, "Machine Design", false, "Robert L. Norton", 2800f },
                    { 44, 5, "Machine Design", false, "Robert L. Norton", 2800f },
                    { 45, 6, "Fluid Mechanics", false, "Frank M. White", 3000f },
                    { 46, 6, "Fundamentals of Thermodynamics", false, "Claus Borgnakke and Richard E. Sonntag", 3100f },
                    { 47, 6, "Fundamentals of Thermodynamics", false, "Claus Borgnakke and Richard E. Sonntag", 3100f },
                    { 48, 7, "Calculus: Early Transcendentals", false, "James Stewart", 3200f },
                    { 49, 7, "Calculus for Dummies", false, "Mark Ryan", 3300f },
                    { 50, 7, "Calculus for Dummies", false, "Mark Ryan", 3300f },
                    { 51, 7, "The Calculus with Analytic Geometry", false, "Louis Leithold", 3400f },
                    { 52, 8, "Euclid's Elements", false, "Euclid", 3500f },
                    { 53, 8, "The Man Who Knew Infinity: A Life of the Genius Ramanujan", false, "Robert Kanigel", 3600f },
                    { 54, 8, "The Man Who Knew Infinity: A Life of the Genius Ramanujan", false, "Robert Kanigel", 3600f },
                    { 55, 8, "A Brief History of Time", false, "Stephen Hawking", 3700f },
                    { 56, 8, "Relativity: The Special and the General Theory", false, "Albert Einstein", 3800f },
                    { 57, 8, "Relativity: The Special and the General Theory", false, "Albert Einstein", 3800f },
                    { 58, 8, "Relativity: The Special and the General Theory", false, "Albert Einstein", 3800f },
                    { 59, 8, "Relativity: The Special and the General Theory", false, "Albert Einstein", 3800f },
                    { 60, 8, "Relativity: The Special and the General Theory", false, "Albert Einstein", 3800f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CarId",
                table: "Orders",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarCategoryId",
                table: "Cars",
                column: "CarCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cars_CarId",
                table: "Orders",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cars_CarId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarCategories");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CarId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Orders",
                newName: "FinePaid");

            migrationBuilder.RenameColumn(
                name: "AmountPaid",
                table: "Orders",
                newName: "BookId");

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookCategoryId = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ordered = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_BookCategories_BookCategoryId",
                        column: x => x.BookCategoryId,
                        principalTable: "BookCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "Id", "Category", "SubCategory" },
                values: new object[,]
                {
                    { 1, "computer", "algorithm" },
                    { 2, "computer", "programming languages" },
                    { 3, "computer", "networking" },
                    { 4, "computer", "hardware" },
                    { 5, "mechanical", "machine" },
                    { 6, "mechanical", "transfer of energy" },
                    { 7, "mathematics", "calculus" },
                    { 8, "mathematics", "algebra" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookCategoryId", "Ordered", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Thomas Corman", 1, false, 100f, "Introduction to Algorithm" },
                    { 2, "Thomas Corman", 1, false, 100f, "Introduction to Algorithm" },
                    { 3, "Robert Sedgewick & Kevin Wayne", 1, false, 200f, "Algorithms" },
                    { 4, "Steve Skiena", 1, false, 300f, "The Algorithm Design Manual" },
                    { 5, "Adnan Aziz", 1, false, 400f, "Algorithms For Interviews" },
                    { 6, "Adnan Aziz", 1, false, 400f, "Algorithms For Interviews" },
                    { 7, "Adnan Aziz", 1, false, 400f, "Algorithms For Interviews" },
                    { 8, "George Heineman", 1, false, 500f, "Algorithm in Nutshell" },
                    { 9, "Algorithm Design", 1, false, 600f, "Klienberg & Tardos" },
                    { 10, "Eric Matthes", 2, false, 700f, "Python Crash Course: A Hands-On, Project-Based Introduction to Programming" },
                    { 11, "Eric Matthes", 2, false, 700f, "Python Crash Course: A Hands-On, Project-Based Introduction to Programming" },
                    { 12, "Eric Matthes", 2, false, 700f, "Python Crash Course: A Hands-On, Project-Based Introduction to Programming" },
                    { 13, "Paul Barry", 2, false, 800f, "Head First Python: A Brain-Friendly Guide" },
                    { 14, "Joshua Bloch", 2, false, 900f, "Effective Java" },
                    { 15, "Joshua Bloch", 2, false, 900f, "Effective Java" },
                    { 16, "Kathy Sierra and Bert Bates", 2, false, 1000f, "Head First Java" },
                    { 17, "Brian W. Kernighan, Dennis M. Ritchie", 2, false, 1100f, "C Programming Language" },
                    { 18, "Brian W. Kernighan, Dennis M. Ritchie", 2, false, 1100f, "C Programming Language" },
                    { 19, "Brian W. Kernighan, Dennis M. Ritchie", 2, false, 1100f, "C Programming Language" },
                    { 20, "Marijn Haverbeke", 2, false, 1200f, "Eloquent JavaScript: A Modern Introduction to Programming" },
                    { 21, "Donald E. Knuth", 2, false, 1300f, "The Art of Computer Programming" },
                    { 22, "Donald E. Knuth", 2, false, 1300f, "The Art of Computer Programming" },
                    { 23, "James F Kurose and Keith W Ross", 3, false, 1400f, "A Top-Down Approach: Computer Networking" },
                    { 24, "Rich Seifert and James Edwards", 3, false, 1500f, "The All-New Switch Book (2nd Edition)" },
                    { 25, "Rich Seifert and James Edwards", 3, false, 1500f, "The All-New Switch Book (2nd Edition)" },
                    { 26, "Jerry FitzGerald, Alan Dennis, and Alexandra Durcikova", 3, false, 1600f, "Business Data Communications and Networking (14th Edition)" },
                    { 27, "Forouzan", 3, false, 1700f, "Data Communications and Networking with TCP/IP Protocol Suite, 6th Edition" },
                    { 28, "Gary Donahue", 3, false, 1800f, "Network Warrior, 2nd Edition" },
                    { 29, "Gary Donahue", 3, false, 1800f, "Network Warrior, 2nd Edition" },
                    { 30, "Gary Donahue", 3, false, 1800f, "Network Warrior, 2nd Edition" },
                    { 31, "Ramesh Gaonkar", 4, false, 1900f, "Microprocessor Architecture, Programming, and Applications with the 8085 (4th Edition)" },
                    { 32, "Douglas V. Hall", 4, false, 2000f, "Microprocessors and Interfacing: Programming and Hardware (Hardcover)" },
                    { 33, "Douglas V. Hall", 4, false, 2000f, "Microprocessors and Interfacing: Programming and Hardware (Hardcover)" },
                    { 34, "Kenneth L. Short", 4, false, 2100f, "Embedded Microprocessor Systems Design" },
                    { 35, "Dr. Vibhav Kumar Sachan", 4, false, 2200f, "Digital Electronics & Microprocessor" },
                    { 36, "Xiaocong Fan", 4, false, 2300f, "Real-Time Embedded Systems" },
                    { 37, "Jonathan A. Dell", 4, false, 2400f, "Digital Interface Design and Application" },
                    { 38, "Shigley's Mechanical Engineering Design", 5, false, 2500f, "Richard G. Budynas and Keith J. Nisbett" },
                    { 39, "Shigley's Mechanical Engineering Design", 5, false, 2500f, "Richard G. Budynas and Keith J. Nisbett" },
                    { 40, "Shigley's Mechanical Engineering Design", 5, false, 2500f, "Richard G. Budynas and Keith J. Nisbett" },
                    { 41, "Erik Oberg", 5, false, 2600f, "Machinery's Handbook" },
                    { 42, "John J. Craig", 5, false, 2700f, "Introduction to Robotics: Mechanics and Control" },
                    { 43, "Robert L. Norton", 5, false, 2800f, "Machine Design" },
                    { 44, "Robert L. Norton", 5, false, 2800f, "Machine Design" },
                    { 45, "Frank M. White", 6, false, 3000f, "Fluid Mechanics" },
                    { 46, "Claus Borgnakke and Richard E. Sonntag", 6, false, 3100f, "Fundamentals of Thermodynamics" },
                    { 47, "Claus Borgnakke and Richard E. Sonntag", 6, false, 3100f, "Fundamentals of Thermodynamics" },
                    { 48, "James Stewart", 7, false, 3200f, "Calculus: Early Transcendentals" },
                    { 49, "Mark Ryan", 7, false, 3300f, "Calculus for Dummies" },
                    { 50, "Mark Ryan", 7, false, 3300f, "Calculus for Dummies" },
                    { 51, "Louis Leithold", 7, false, 3400f, "The Calculus with Analytic Geometry" },
                    { 52, "Euclid", 8, false, 3500f, "Euclid's Elements" },
                    { 53, "Robert Kanigel", 8, false, 3600f, "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
                    { 54, "Robert Kanigel", 8, false, 3600f, "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
                    { 55, "Stephen Hawking", 8, false, 3700f, "A Brief History of Time" },
                    { 56, "Albert Einstein", 8, false, 3800f, "Relativity: The Special and the General Theory" },
                    { 57, "Albert Einstein", 8, false, 3800f, "Relativity: The Special and the General Theory" },
                    { 58, "Albert Einstein", 8, false, 3800f, "Relativity: The Special and the General Theory" },
                    { 59, "Albert Einstein", 8, false, 3800f, "Relativity: The Special and the General Theory" },
                    { 60, "Albert Einstein", 8, false, 3800f, "Relativity: The Special and the General Theory" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookId",
                table: "Orders",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookCategoryId",
                table: "Books",
                column: "BookCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Books_BookId",
                table: "Orders",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
