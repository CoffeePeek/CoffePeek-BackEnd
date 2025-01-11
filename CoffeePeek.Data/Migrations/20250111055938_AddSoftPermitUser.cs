﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeePeek.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSoftPermitUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDeleted",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSoftDeleted",
                table: "Users");
        }
    }
}