using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscussionForum.Migrations
{
    public partial class CommentDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommentDetails",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentDescr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentDetails", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_CommentDetails_AspNetUsers_CommentUserId",
                        column: x => x.CommentUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentDetails_CommentUserId",
                table: "CommentDetails",
                column: "CommentUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentDetails");
        }
    }
}
