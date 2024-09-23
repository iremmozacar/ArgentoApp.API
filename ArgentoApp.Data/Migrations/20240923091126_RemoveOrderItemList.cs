using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArgentoApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveOrderItemList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_OrderItems_OrderItemId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderItemId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "OrderItems");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3920), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3930), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3950), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3950), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(4960), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(4970), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(4990), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(5000), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(5000), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(5010), new DateTime(2024, 9, 23, 12, 11, 26, 346, DateTimeKind.Local).AddTicks(5010) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "OrderItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 21, 13, 52, 4, 201, DateTimeKind.Local).AddTicks(9830));

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1930), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1930), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1930) });

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1940), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(1950) });

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2960), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2970), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2970), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2980), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2990), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(3000), new DateTime(2024, 9, 21, 13, 52, 4, 202, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderItemId",
                table: "OrderItems",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_OrderItems_OrderItemId",
                table: "OrderItems",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id");
        }
    }
}
