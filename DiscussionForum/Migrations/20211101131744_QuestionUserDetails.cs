using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscussionForum.Migrations
{
    public partial class QuestionUserDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionUserDetails",
                columns: table => new
                {
                    QUId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreaterUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionUserDetails", x => x.QUId);
                    table.ForeignKey(
                        name: "FK_QuestionUserDetails_AspNetUsers_CreaterUserId",
                        column: x => x.CreaterUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionUserDetails_QuestionDetails_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionDetails",
                        principalColumn: "QId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionUserDetails_CreaterUserId",
                table: "QuestionUserDetails",
                column: "CreaterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionUserDetails_QuestionId",
                table: "QuestionUserDetails",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionUserDetails");
        }
    }
}
