using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class terceraNombresTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_proyectos_ProyectoId",
                table: "Tareas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tareas",
                table: "Tareas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_proyectos",
                table: "proyectos");

            migrationBuilder.RenameTable(
                name: "Tareas",
                newName: "Tarea");

            migrationBuilder.RenameTable(
                name: "proyectos",
                newName: "Proyecto");

            migrationBuilder.RenameIndex(
                name: "IX_Tareas_ProyectoId",
                table: "Tarea",
                newName: "IX_Tarea_ProyectoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarea",
                table: "Tarea",
                column: "TareaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proyecto",
                table: "Proyecto",
                column: "ProyectoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Proyecto_ProyectoId",
                table: "Tarea",
                column: "ProyectoId",
                principalTable: "Proyecto",
                principalColumn: "ProyectoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Proyecto_ProyectoId",
                table: "Tarea");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarea",
                table: "Tarea");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proyecto",
                table: "Proyecto");

            migrationBuilder.RenameTable(
                name: "Tarea",
                newName: "Tareas");

            migrationBuilder.RenameTable(
                name: "Proyecto",
                newName: "proyectos");

            migrationBuilder.RenameIndex(
                name: "IX_Tarea_ProyectoId",
                table: "Tareas",
                newName: "IX_Tareas_ProyectoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tareas",
                table: "Tareas",
                column: "TareaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_proyectos",
                table: "proyectos",
                column: "ProyectoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_proyectos_ProyectoId",
                table: "Tareas",
                column: "ProyectoId",
                principalTable: "proyectos",
                principalColumn: "ProyectoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
