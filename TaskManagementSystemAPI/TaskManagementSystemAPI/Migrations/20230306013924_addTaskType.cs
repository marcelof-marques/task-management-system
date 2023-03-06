using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class addTaskType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Tasks");

            migrationBuilder.AddColumn<long>(
                name: "TypeID",
                table: "Tasks",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "TaskTypes",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTypes", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TypeID",
                table: "Tasks",
                column: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskTypes_TypeID",
                table: "Tasks",
                column: "TypeID",
                principalTable: "TaskTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskTypes_TypeID",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskTypes");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TypeID",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "Tasks");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
