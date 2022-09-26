using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class SeedUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03d03fcd-20bf-44d5-81ea-0a9074dc7c21", "92572071-a2e7-4bbf-9491-e297caccbc3b", "User", "USER" },
                    { "04d03fcd-70bf-44d5-81ea-0a9074dc7c21", "963c9191-7f95-4d76-a8d7-883680a631fd", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04d03fcd-70bf-44d5-81ea-0a9074dc7c06", 0, "fa5de1c5-db51-44f9-990e-95b81192c089", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEM7Ds2GYWYi+7XzT8WL/zOzfckzU+y4Dg14Zu2mJ+QFiYUKjM9+yEABYjMxWnrOaWg==", null, false, "f670cfb7-bb3e-422b-9080-0a94e5ff0830", null, false, null },
                    { "4077189e-6786-4d03-b0e7-698efbfe4ed0", 0, "8cb06945-19fe-47bc-90da-4605390c1a7d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@user.com", false, "System", "Admin", false, null, "ADMIN@USER.COM", null, "AQAAAAEAACcQAAAAEDaFMa/NbOOgxJkLlv0nuMbTrmTMCemWB7EyAqT3pvWfddPlPv1Z1BNj+q7UPkUUOA==", null, false, "ac2c32fa-d04a-40cf-9c73-14a7464bde63", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "04d03fcd-70bf-44d5-81ea-0a9074dc7c21", "04d03fcd-70bf-44d5-81ea-0a9074dc7c06" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "03d03fcd-20bf-44d5-81ea-0a9074dc7c21", "4077189e-6786-4d03-b0e7-698efbfe4ed0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04d03fcd-70bf-44d5-81ea-0a9074dc7c21", "04d03fcd-70bf-44d5-81ea-0a9074dc7c06" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "03d03fcd-20bf-44d5-81ea-0a9074dc7c21", "4077189e-6786-4d03-b0e7-698efbfe4ed0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03d03fcd-20bf-44d5-81ea-0a9074dc7c21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04d03fcd-70bf-44d5-81ea-0a9074dc7c21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04d03fcd-70bf-44d5-81ea-0a9074dc7c06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4077189e-6786-4d03-b0e7-698efbfe4ed0");
        }
    }
}
