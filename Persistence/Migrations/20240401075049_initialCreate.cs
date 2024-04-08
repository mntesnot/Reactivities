using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Venue = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("17fb418b-35e7-472e-b667-8395dd200e6b"), "culture", "London", new DateTime(2024, 5, 1, 10, 50, 48, 511, DateTimeKind.Local).AddTicks(7130), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("2467dc18-56ff-427a-b493-0762a25024fe"), "music", "London", new DateTime(2024, 10, 1, 10, 50, 48, 511, DateTimeKind.Local).AddTicks(7152), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("256716d7-4e4c-4e9d-a4df-05df41e4b570"), "drinks", "London", new DateTime(2024, 8, 1, 10, 50, 48, 511, DateTimeKind.Local).AddTicks(7147), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("333fb113-8b22-4a24-9c5b-5abd50d11dfb"), "drinks", "London", new DateTime(2024, 7, 1, 10, 50, 48, 511, DateTimeKind.Local).AddTicks(7135), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("4546613f-14a6-47e2-8993-06fd07047737"), "drinks", "London", new DateTime(2024, 9, 1, 10, 50, 48, 511, DateTimeKind.Local).AddTicks(7149), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("6e0d750a-e4d0-4562-a8b1-bfdfe7f43493"), "culture", "Paris", new DateTime(2024, 3, 1, 10, 50, 48, 511, DateTimeKind.Local).AddTicks(7127), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("85dd5acf-2a71-4a99-b6ee-bf07f0e0728b"), "drinks", "London", new DateTime(2024, 2, 1, 10, 50, 48, 511, DateTimeKind.Local).AddTicks(7109), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("9788cb9a-75e0-4eaf-ab57-b9eeceef758b"), "film", "London", new DateTime(2024, 12, 1, 10, 50, 48, 511, DateTimeKind.Local).AddTicks(7157), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("bd1c6c2b-eb22-4b60-add8-12dfa7a25005"), "music", "London", new DateTime(2024, 6, 1, 10, 50, 48, 511, DateTimeKind.Local).AddTicks(7132), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("d66f9e9a-97d8-4bcc-9272-4a4728dbfbe4"), "travel", "London", new DateTime(2024, 11, 1, 10, 50, 48, 511, DateTimeKind.Local).AddTicks(7154), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");
        }
    }
}
