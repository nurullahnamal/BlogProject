using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class DALextensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2d9c2c36-cf4b-487a-b1a9-4800f5387ca2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b2af1f69-66a7-4d50-95e6-a5b446f7c910"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("b598ed3d-3dd5-4667-9f13-5949c67a3d91"), new Guid("a528849a-4d7f-431b-8c06-640bddef8d5a"), "---------------dwa---------------------ddwa---------------------ddwa---------------------ddwa-----", "Test", new DateTime(2024, 5, 5, 13, 45, 57, 367, DateTimeKind.Local).AddTicks(1082), null, null, new Guid("903bd50c-1c68-4fb2-bb32-2b4aa7d9900d"), false, null, null, "Asp net Deneme 212i", 16 },
                    { new Guid("c4fcd4e8-1cc9-4908-a9c3-e52ecb5606d3"), new Guid("f2e461bb-875d-4d0a-aff7-f8db21f937a1"), "---------------dwa---------------------ddwa---------------------ddwa---------------------ddwa---------------------", "Test", new DateTime(2024, 5, 5, 13, 45, 57, 367, DateTimeKind.Local).AddTicks(1077), null, null, new Guid("3654c9a2-82c0-4e22-9479-7db9069fe409"), false, null, null, "Asp net Deneme makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a528849a-4d7f-431b-8c06-640bddef8d5a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 13, 45, 57, 367, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2e461bb-875d-4d0a-aff7-f8db21f937a1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 13, 45, 57, 367, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3654c9a2-82c0-4e22-9479-7db9069fe409"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 13, 45, 57, 367, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("903bd50c-1c68-4fb2-bb32-2b4aa7d9900d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 13, 45, 57, 367, DateTimeKind.Local).AddTicks(1299));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b598ed3d-3dd5-4667-9f13-5949c67a3d91"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c4fcd4e8-1cc9-4908-a9c3-e52ecb5606d3"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2d9c2c36-cf4b-487a-b1a9-4800f5387ca2"), new Guid("a528849a-4d7f-431b-8c06-640bddef8d5a"), "---------------dwa---------------------ddwa---------------------ddwa---------------------ddwa-----", "Test", new DateTime(2024, 5, 4, 22, 54, 6, 386, DateTimeKind.Local).AddTicks(6624), null, null, new Guid("903bd50c-1c68-4fb2-bb32-2b4aa7d9900d"), false, null, null, "Asp net Deneme 212i", 16 },
                    { new Guid("b2af1f69-66a7-4d50-95e6-a5b446f7c910"), new Guid("f2e461bb-875d-4d0a-aff7-f8db21f937a1"), "---------------dwa---------------------ddwa---------------------ddwa---------------------ddwa---------------------", "Test", new DateTime(2024, 5, 4, 22, 54, 6, 386, DateTimeKind.Local).AddTicks(6618), null, null, new Guid("3654c9a2-82c0-4e22-9479-7db9069fe409"), false, null, null, "Asp net Deneme makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a528849a-4d7f-431b-8c06-640bddef8d5a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 22, 54, 6, 386, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2e461bb-875d-4d0a-aff7-f8db21f937a1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 22, 54, 6, 386, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3654c9a2-82c0-4e22-9479-7db9069fe409"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 22, 54, 6, 386, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("903bd50c-1c68-4fb2-bb32-2b4aa7d9900d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 22, 54, 6, 386, DateTimeKind.Local).AddTicks(6936));
        }
    }
}
