using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingCleanArchitecture.InfrastructureLayer.Migration
{
    /// <inheritdoc />
    public partial class DropTableAnswerTicket : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerTicket");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
