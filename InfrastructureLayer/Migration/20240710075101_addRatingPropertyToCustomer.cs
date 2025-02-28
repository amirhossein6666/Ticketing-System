﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingCleanArchitecture.InfrastructureLayer.Migration
{
    /// <inheritdoc />
    public partial class addRatingPropertyToCustomer : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Customers",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Customers");
        }
    }
}
