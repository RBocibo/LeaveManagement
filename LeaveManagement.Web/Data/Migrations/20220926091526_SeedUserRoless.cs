using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class SeedUserRoless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03d03fcd-20bf-44d5-81ea-0a9074dc7c21",
                column: "ConcurrencyStamp",
                value: "7ffdd9eb-54cc-41e1-98ae-9fd82315ae1c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04d03fcd-70bf-44d5-81ea-0a9074dc7c21",
                column: "ConcurrencyStamp",
                value: "dc7fc4a7-94d4-476c-bdb3-3ea2ae919d0e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04d03fcd-70bf-44d5-81ea-0a9074dc7c06",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5bae1933-eb8c-49cd-a8b9-8f6b8fb79316", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEO046xoI/QRa4d6DLuZxhKQobGfVEVnOBOnYfASwdLBlsZYdmRSY2vuxnSThVm2EbA==", "fdbea71c-0c6c-429e-be15-c2cff94434f9", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4077189e-6786-4d03-b0e7-698efbfe4ed0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ccd8b4ac-1d08-4ae6-b42f-edc516a283e7", true, "ADMIN@USER.COM", "AQAAAAEAACcQAAAAENDGkvhIlCIGhtwJGuShpJN9fkIpWkyGIO6yojS42s8eQpL16uTTS8RZ1H1f4LmqWg==", "fa67cb25-ff86-4b01-97d2-a8df8d9c408a", "admin@user.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03d03fcd-20bf-44d5-81ea-0a9074dc7c21",
                column: "ConcurrencyStamp",
                value: "92572071-a2e7-4bbf-9491-e297caccbc3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04d03fcd-70bf-44d5-81ea-0a9074dc7c21",
                column: "ConcurrencyStamp",
                value: "963c9191-7f95-4d76-a8d7-883680a631fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04d03fcd-70bf-44d5-81ea-0a9074dc7c06",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fa5de1c5-db51-44f9-990e-95b81192c089", false, null, "AQAAAAEAACcQAAAAEM7Ds2GYWYi+7XzT8WL/zOzfckzU+y4Dg14Zu2mJ+QFiYUKjM9+yEABYjMxWnrOaWg==", "f670cfb7-bb3e-422b-9080-0a94e5ff0830", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4077189e-6786-4d03-b0e7-698efbfe4ed0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8cb06945-19fe-47bc-90da-4605390c1a7d", false, null, "AQAAAAEAACcQAAAAEDaFMa/NbOOgxJkLlv0nuMbTrmTMCemWB7EyAqT3pvWfddPlPv1Z1BNj+q7UPkUUOA==", "ac2c32fa-d04a-40cf-9c73-14a7464bde63", null });
        }
    }
}
