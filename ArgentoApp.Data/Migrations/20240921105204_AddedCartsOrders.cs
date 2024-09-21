using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArgentoApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedCartsOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Adress = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentType = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderState = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CartId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quentity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderItemId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[] { 1, new DateTime(2024, 9, 21, 13, 52, 4, 201, DateTimeKind.Local).AddTicks(9830), "1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1910), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1930), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1930), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1930), "3. Solar Pleksus Çakra(Manipura Çakra)" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1930), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1930), "4.Kalp Çakrası (Anahata Çakra)" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1940), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1940), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1940), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1950), "7.Taç Çakra (Sahasrara Çakra)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2950), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "Price" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2960), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2960), 200m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Price" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2970), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2970), 300m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "Price" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2970), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2980), 400m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "Price" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2980), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2980), 500m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "Price" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2990), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2990), 600m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "Price" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(3000), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(3000), 700m });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderItemId",
                table: "OrderItems",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1430), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1440), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1440), " 3. Solar Pleksus Çakra(Manipura Çakra)" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1440), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1440), "Kalp Çakrası (Anahata Çakra)" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1440), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1450), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1450), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1450), "7. Taç Çakra (Sahasrara Çakra)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2620), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "Price" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2630), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2630), 100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Price" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2640), 100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "Price" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2650), 100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate", "Price" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2660), 100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "Price" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2670), 100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate", "Price" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2670), new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2670), 100m });
        }
    }
}
