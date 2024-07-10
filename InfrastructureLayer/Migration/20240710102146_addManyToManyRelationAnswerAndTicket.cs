using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingCleanArchitecture.InfrastructureLayer.Migration
{
    /// <inheritdoc />
    public partial class addManyToManyRelationAnswerAndTicket : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Tickets_TicketId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_TicketId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Answers");

            migrationBuilder.CreateTable(
                name: "AnswerTicket",
                columns: table => new
                {
                    AnswersId = table.Column<int>(type: "int", nullable: false),
                    RepliesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerTicket", x => new { x.AnswersId, x.RepliesId });
                    table.ForeignKey(
                        name: "FK_AnswerTicket_Answers_AnswersId",
                        column: x => x.AnswersId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnswerTicket_Tickets_RepliesId",
                        column: x => x.RepliesId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketAnswer",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketAnswer", x => new { x.TicketId, x.AnswerId });
                    table.ForeignKey(
                        name: "FK_TicketAnswer_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketAnswer_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerTicket_RepliesId",
                table: "AnswerTicket",
                column: "RepliesId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketAnswer_AnswerId",
                table: "TicketAnswer",
                column: "AnswerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerTicket");

            migrationBuilder.DropTable(
                name: "TicketAnswer");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_TicketId",
                table: "Answers",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Tickets_TicketId",
                table: "Answers",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
