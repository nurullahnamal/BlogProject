using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class userCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b598ed3d-3dd5-4667-9f13-5949c67a3d91"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c4fcd4e8-1cc9-4908-a9c3-e52ecb5606d3"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("164e1090-765a-4edd-89fc-544de8626819"), new Guid("f2e461bb-875d-4d0a-aff7-f8db21f937a1"), "---------------dwa---------------------ddwa---------------------ddwa---------------------ddwa---------------------", "Test", new DateTime(2024, 5, 7, 17, 6, 54, 442, DateTimeKind.Local).AddTicks(426), null, null, new Guid("3654c9a2-82c0-4e22-9479-7db9069fe409"), false, null, null, "Asp net Deneme makalesi", 15 },
                    { new Guid("6b9956c4-2a4c-4c5a-a9da-e67edb67e7ae"), new Guid("a528849a-4d7f-431b-8c06-640bddef8d5a"), "---------------dwa---------------------ddwa---------------------ddwa---------------------ddwa-----", "Test", new DateTime(2024, 5, 7, 17, 6, 54, 442, DateTimeKind.Local).AddTicks(431), null, null, new Guid("903bd50c-1c68-4fb2-bb32-2b4aa7d9900d"), false, null, null, "Asp net Deneme 212i", 16 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("a864b42c-0ed3-48e4-8571-567b00603e42"), "6252e673-eca3-43fe-84db-5c40218f6dd4", "user", "USER" },
                    { new Guid("e524514b-f771-4793-a579-65f546e54009"), "12980cfe-aacf-4f9d-90c2-fd353f8e64d8", "Admin", "ADMIN" },
                    { new Guid("f3f18bae-431e-44e7-b1b2-79ee4621dd24"), "519ca4df-ab82-4ff3-aea9-9c475d8bcc81", "Superadmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1713c70c-1ef6-4201-b5fb-73e28054822c"), 0, "a70b484d-cb76-4aa3-9e09-6024f6df6e86", "admin@gmail.com", false, "yusuf ", "yılmaz", false, null, "ADMİN@GMAİL.COM", "ADMİN@GMAİL.COM", "AQAAAAEAACcQAAAAEBVY8DV0Gb+eWGI52Qlu/udHBPrhdM2hEM4f8N5QD6eqgskGJDsAQIpr+X6gPX5zJA==", "0525625525", false, "a8f877d1-21d8-42cf-88d2-9850549a1d09", false, "admin@gmail.com" },
                    { new Guid("945b2d6b-7e8a-4938-a485-7f729bade00a"), 0, "31949e85-9f8f-4088-a0dd-f7d789d10c8a", "superadmin@gmail.com", true, "nurullah ", "yılmaz", false, null, "SUPERADMİN@GMAİL.COM", "SUPERADMİN@GMAİL.COM", "AQAAAAEAACcQAAAAEHHt+ypdaeu593gbJcAAQ54fthllncLF9avOsG5EzCX0L5GX1DLQCKxn24+NWmok7Q==", "05252525525", true, "c5f79766-c636-4aa8-b0d6-ca8d1dc14355", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a528849a-4d7f-431b-8c06-640bddef8d5a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 17, 6, 54, 442, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2e461bb-875d-4d0a-aff7-f8db21f937a1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 17, 6, 54, 442, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3654c9a2-82c0-4e22-9479-7db9069fe409"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 17, 6, 54, 442, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("903bd50c-1c68-4fb2-bb32-2b4aa7d9900d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 17, 6, 54, 442, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e524514b-f771-4793-a579-65f546e54009"), new Guid("1713c70c-1ef6-4201-b5fb-73e28054822c") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("f3f18bae-431e-44e7-b1b2-79ee4621dd24"), new Guid("945b2d6b-7e8a-4938-a485-7f729bade00a") });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("164e1090-765a-4edd-89fc-544de8626819"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6b9956c4-2a4c-4c5a-a9da-e67edb67e7ae"));

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
    }
}
