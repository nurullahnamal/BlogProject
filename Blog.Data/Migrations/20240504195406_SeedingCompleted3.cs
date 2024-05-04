using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class SeedingCompleted3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("a528849a-4d7f-431b-8c06-640bddef8d5a"), "admin test", new DateTime(2024, 5, 4, 22, 54, 6, 386, DateTimeKind.Local).AddTicks(6823), null, null, false, null, null, "aspnet core " },
                    { new Guid("f2e461bb-875d-4d0a-aff7-f8db21f937a1"), "admin test", new DateTime(2024, 5, 4, 22, 54, 6, 386, DateTimeKind.Local).AddTicks(6806), null, null, false, null, null, "aspnet core " }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("3654c9a2-82c0-4e22-9479-7db9069fe409"), "Admin Test", new DateTime(2024, 5, 4, 22, 54, 6, 386, DateTimeKind.Local).AddTicks(6933), null, null, "dwadaw", "png", false, null, null },
                    { new Guid("903bd50c-1c68-4fb2-bb32-2b4aa7d9900d"), "Admin Test", new DateTime(2024, 5, 4, 22, 54, 6, 386, DateTimeKind.Local).AddTicks(6936), null, null, "dwadaw", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("2d9c2c36-cf4b-487a-b1a9-4800f5387ca2"), new Guid("a528849a-4d7f-431b-8c06-640bddef8d5a"), "---------------dwa---------------------ddwa---------------------ddwa---------------------ddwa-----", "Test", new DateTime(2024, 5, 4, 22, 54, 6, 386, DateTimeKind.Local).AddTicks(6624), null, null, new Guid("903bd50c-1c68-4fb2-bb32-2b4aa7d9900d"), false, null, null, "Asp net Deneme 212i", 16 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("b2af1f69-66a7-4d50-95e6-a5b446f7c910"), new Guid("f2e461bb-875d-4d0a-aff7-f8db21f937a1"), "---------------dwa---------------------ddwa---------------------ddwa---------------------ddwa---------------------", "Test", new DateTime(2024, 5, 4, 22, 54, 6, 386, DateTimeKind.Local).AddTicks(6618), null, null, new Guid("3654c9a2-82c0-4e22-9479-7db9069fe409"), false, null, null, "Asp net Deneme makalesi", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2d9c2c36-cf4b-487a-b1a9-4800f5387ca2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b2af1f69-66a7-4d50-95e6-a5b446f7c910"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a528849a-4d7f-431b-8c06-640bddef8d5a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2e461bb-875d-4d0a-aff7-f8db21f937a1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3654c9a2-82c0-4e22-9479-7db9069fe409"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("903bd50c-1c68-4fb2-bb32-2b4aa7d9900d"));
        }
    }
}
