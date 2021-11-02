using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscussionForum.Migrations
{
    public partial class CommentQuestionDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommentQuestionDetails",
                columns: table => new
                {
                    CUId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentQuestionDetails", x => x.CUId);
                    table.ForeignKey(
                        name: "FK_CommentQuestionDetails_CommentDetails_CommentId",
                        column: x => x.CommentId,
                        principalTable: "CommentDetails",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentQuestionDetails_QuestionDetails_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionDetails",
                        principalColumn: "QId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentQuestionDetails_CommentId",
                table: "CommentQuestionDetails",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentQuestionDetails_QuestionId",
                table: "CommentQuestionDetails",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentQuestionDetails");
        }
    }
}
