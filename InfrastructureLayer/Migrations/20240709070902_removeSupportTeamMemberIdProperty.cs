using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

#nullable disable

namespace TicketingCleanArchitecture.InfrastructureLayer
{
    /// <inheritdoc />
    public partial class removeSupportTeamMemberIdProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_SupportTeamMembers_SupportTeamMemberId",
                table: "Tickets"
            );
            migrationBuilder.DropIndex(
                name: "IX_Tickets_SupportTeamMemberId",
                table: "Tickets"
            );
            migrationBuilder.DropColumn(
                name: "SupportTeamMemberId",
                table: "Tickets"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupportTeamMemberId",
                table: "Tickets");
        }
    }
}
