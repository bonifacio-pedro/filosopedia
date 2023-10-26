using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FIlosoPediaWeb.Api.Migrations
{
    /// <inheritdoc />
    public partial class SQLITE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GenderName",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<long>(
                name: "GenderId",
                table: "Genders",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Comentaries",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<long>(
                name: "BookId",
                table: "Comentaries",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "Comentaries",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<long>(
                name: "ComentaryId",
                table: "Comentaries",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<ushort>(
                name: "Stars",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(ushort),
                oldType: "smallint unsigned");

            migrationBuilder.AlterColumn<string>(
                name: "ImageBookUrl",
                table: "Books",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<long>(
                name: "GenderId",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<long>(
                name: "AuthorId",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "BookId",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<long>(
                name: "GenderId",
                table: "Authors",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "Authors",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Authors",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<long>(
                name: "AuthorId",
                table: "Authors",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GenderName",
                table: "Genders",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Genders",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<long>(
                name: "GenderId",
                table: "Genders",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Comentaries",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<long>(
                name: "BookId",
                table: "Comentaries",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "Comentaries",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<long>(
                name: "ComentaryId",
                table: "Comentaries",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<ushort>(
                name: "Stars",
                table: "Books",
                type: "smallint unsigned",
                nullable: false,
                oldClrType: typeof(ushort),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "ImageBookUrl",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<long>(
                name: "GenderId",
                table: "Books",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<long>(
                name: "AuthorId",
                table: "Books",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<long>(
                name: "BookId",
                table: "Books",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Authors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<long>(
                name: "GenderId",
                table: "Authors",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "Authors",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Authors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<long>(
                name: "AuthorId",
                table: "Authors",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);
        }
    }
}
