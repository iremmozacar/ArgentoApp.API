using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArgentoApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Products",
                type: "TEXT",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "date('now')",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "TEXT",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "date('now')",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1380), "Kök çakra ile uyumlu taşlar burada. Kırmızı renk ile ifade edilir.", true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1420), "1. Kök Çakra (Muladhara Çakra)", "Kök" },
                    { 2, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1430), "Sakral çakra ile uyumlu taşlar burada. Turuncu renk ile ifade edilir.", true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1430), "2.Sakral Çakra (Svadhistana Çakra)", "Sakral" },
                    { 3, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1440), "Solar Plexus çakra ile uyumlu taşlar burada. Sarı renk ile ifade edilir.", true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1440), " 3. Solar Pleksus Çakra(Manipura Çakra)", "SolarPlexus" },
                    { 4, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1440), "Kalp çakrası ile uyumlu taşlar burada. Yeşil renk ile ifade edilir.", true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1440), "Kalp Çakrası (Anahata Çakra)", "Kalp" },
                    { 5, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1440), "Boğaz çakrası ile uyumlu taşlar burada. Mavi renk ile ifade edilir.", true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1450), "5.Boğaz Çakrası (Vishuddha Çakra) ", "Boğaz" },
                    { 6, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1450), "3.Göz çakrası ile uyumlu taşlar burada. İndigo mavi ile ifade edilir.", true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1450), "6.Üçüncü Göz Çakrası (Ajna Çakra)", "3.Göz" },
                    { 7, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1450), "Taç çakra ile uyumlu taşlar burada. Menekşe rengi ile ifade edilir.", true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(1450), "7. Taç Çakra (Sahasrara Çakra)", "Taç" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "ImageUrl", "IsActive", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2620), "", true, true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2620), "Kırmızı Jasper", 100m, "Kırmızı Jasper", "Jasper" },
                    { 2, 2, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2630), "", true, true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2630), "Turuncu Kalsit", 100m, "Turuncu Kalsit", "Kalsit" },
                    { 3, 3, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2640), "", true, true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2640), "Kaplan Gözü ", 100m, "Kaplan Gözü", "KaplanGozu" },
                    { 4, 4, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2650), "", true, true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2650), "Moldavit", 100m, "Moldavit", "Moldavit" },
                    { 5, 5, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2660), "", true, true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2660), "Larimar", 100m, "Larimar", "Larimar" },
                    { 6, 3, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2660), "", true, true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2670), "Sodalit", 100m, "Sodalit", "Sodalit" },
                    { 7, 7, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2670), "", true, true, new DateTime(2024, 9, 14, 13, 34, 57, 433, DateTimeKind.Local).AddTicks(2670), "Kristal Kuvars", 100m, "Kristal Kuvars", "KristalKuvars" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Products",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "date('now')");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "date('now')");
        }
    }
}
