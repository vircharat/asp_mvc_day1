using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTheShowDAL.Migrations
{
    public partial class nue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "moviesv",
                columns: table => new
                {
                    MovievId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovievName = table.Column<string>(nullable: true),
                    MovievDesc = table.Column<string>(nullable: true),
                    MovievType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moviesv", x => x.MovievId);
                });

            migrationBuilder.CreateTable(
                name: "theatresv",
                columns: table => new
                {
                    TheatrevId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheatrevName = table.Column<string>(nullable: true),
                    TheatrevAddress = table.Column<string>(nullable: true),
                    TheatrevComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theatresv", x => x.TheatrevId);
                });

            migrationBuilder.CreateTable(
                name: "userv",
                columns: table => new
                {
                    UservId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UservName = table.Column<string>(nullable: true),
                    UservEmail = table.Column<string>(nullable: true),
                    UserPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userv", x => x.UservId);
                });

            migrationBuilder.CreateTable(
                name: "showtimingsv",
                columns: table => new
                {
                    ShowvId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovievId = table.Column<int>(nullable: false),
                    TheatrevId = table.Column<int>(nullable: false),
                    ShowTimevv = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_showtimingsv", x => x.ShowvId);
                    table.ForeignKey(
                        name: "FK_showtimingsv_moviesv_MovievId",
                        column: x => x.MovievId,
                        principalTable: "moviesv",
                        principalColumn: "MovievId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_showtimingsv_theatresv_TheatrevId",
                        column: x => x.TheatrevId,
                        principalTable: "theatresv",
                        principalColumn: "TheatrevId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UservId = table.Column<int>(nullable: false),
                    showId = table.Column<int>(nullable: false),
                    BookingQuantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_bookings_userv_UservId",
                        column: x => x.UservId,
                        principalTable: "userv",
                        principalColumn: "UservId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_showtimingsv_showId",
                        column: x => x.showId,
                        principalTable: "showtimingsv",
                        principalColumn: "ShowvId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_UservId",
                table: "bookings",
                column: "UservId");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_showId",
                table: "bookings",
                column: "showId");

            migrationBuilder.CreateIndex(
                name: "IX_showtimingsv_MovievId",
                table: "showtimingsv",
                column: "MovievId");

            migrationBuilder.CreateIndex(
                name: "IX_showtimingsv_TheatrevId",
                table: "showtimingsv",
                column: "TheatrevId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "userv");

            migrationBuilder.DropTable(
                name: "showtimingsv");

            migrationBuilder.DropTable(
                name: "moviesv");

            migrationBuilder.DropTable(
                name: "theatresv");
        }
    }
}
