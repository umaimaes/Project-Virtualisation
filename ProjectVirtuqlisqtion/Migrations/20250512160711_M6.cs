using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectVirtuqlisqtion.Migrations
{
    /// <inheritdoc />
    public partial class M6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuizOption_QuizQuestion_QuizQuestionId",
                table: "QuizOption");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizQuestion_Courses_CourseId",
                table: "QuizQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuizQuestion",
                table: "QuizQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuizOption",
                table: "QuizOption");

            migrationBuilder.RenameTable(
                name: "QuizQuestion",
                newName: "QuizQuestions");

            migrationBuilder.RenameTable(
                name: "QuizOption",
                newName: "QuizOptions");

            migrationBuilder.RenameIndex(
                name: "IX_QuizQuestion_CourseId",
                table: "QuizQuestions",
                newName: "IX_QuizQuestions_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_QuizOption_QuizQuestionId",
                table: "QuizOptions",
                newName: "IX_QuizOptions_QuizQuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuizQuestions",
                table: "QuizQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuizOptions",
                table: "QuizOptions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizOptions_QuizQuestions_QuizQuestionId",
                table: "QuizOptions",
                column: "QuizQuestionId",
                principalTable: "QuizQuestions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizQuestions_Courses_CourseId",
                table: "QuizQuestions",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuizOptions_QuizQuestions_QuizQuestionId",
                table: "QuizOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_QuizQuestions_Courses_CourseId",
                table: "QuizQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuizQuestions",
                table: "QuizQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuizOptions",
                table: "QuizOptions");

            migrationBuilder.RenameTable(
                name: "QuizQuestions",
                newName: "QuizQuestion");

            migrationBuilder.RenameTable(
                name: "QuizOptions",
                newName: "QuizOption");

            migrationBuilder.RenameIndex(
                name: "IX_QuizQuestions_CourseId",
                table: "QuizQuestion",
                newName: "IX_QuizQuestion_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_QuizOptions_QuizQuestionId",
                table: "QuizOption",
                newName: "IX_QuizOption_QuizQuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuizQuestion",
                table: "QuizQuestion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuizOption",
                table: "QuizOption",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizOption_QuizQuestion_QuizQuestionId",
                table: "QuizOption",
                column: "QuizQuestionId",
                principalTable: "QuizQuestion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizQuestion_Courses_CourseId",
                table: "QuizQuestion",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
