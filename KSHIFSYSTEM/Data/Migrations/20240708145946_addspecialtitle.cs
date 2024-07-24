using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KSHIFSYSTEM.Data.Migrations
{
    public partial class addspecialtitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpecaiaTitle11",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle1",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle10",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle12",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle13",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle14",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle15",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle16",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle2",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle3",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle4",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle5",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle6",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle7",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle8",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecaialTitle9",
                table: "TarshehBookTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "7a6653c0-3cc5-45c6-8aa5-744cae42c994");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "92567071-ce98-4e82-b760-1b267a7928c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "bb42d154-6303-4156-aea5-10cbdc71d6df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "810f28e2-287e-4320-8538-156c57e1cbb6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "da410a35-6c28-4b7a-99e3-a372227eebb5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "d9bb0356-4649-4f17-91d1-94eda824dbef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "49e9dc00-dace-4402-85e8-31a7a876741d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88b11ba9-0c5e-40cc-980f-89c4a37764ba", "ba4916e5-8a2a-4bad-bb33-c40fd9902d0b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecaiaTitle11",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle1",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle10",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle12",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle13",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle14",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle15",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle16",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle2",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle3",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle4",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle5",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle6",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle7",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle8",
                table: "TarshehBookTable");

            migrationBuilder.DropColumn(
                name: "SpecaialTitle9",
                table: "TarshehBookTable");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "1ab90c19-d19f-4d07-b090-8663bdb47800");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "30953090-b143-4de4-bde2-96afc3a6d6f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "72907bb9-8c05-4d34-88bf-4d98a7b855ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "45b87ff1-96a4-45c0-ba55-f0f6ec721ebe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "453e2a59-769a-43f3-9392-e081703489f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "bc2ddce5-30a8-4a5e-8464-51ff945ba8c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "a87424c0-24ae-411f-9e0e-b808e93f3581");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e8ca591-8fa5-4748-868f-c46e64eb6617", "d93fb5c3-265e-466b-a8fe-578929d524c0" });
        }
    }
}
