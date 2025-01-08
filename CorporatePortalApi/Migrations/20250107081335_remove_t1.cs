using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorporatePortalApi.Migrations
{
    /// <inheritdoc />
    public partial class remove_t1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TmX_Address_Address_ID1",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TmX_Locale_Locale_ID1",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TmX_Tenants_Tenant_ID1",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TmX_Time_Zone_TimeZoneTime_Zone_ID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Address_ID1",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Locale_ID1",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Tenant_ID1",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TimeZoneTime_Zone_ID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address_ID1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Locale_ID1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Tenant_ID1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TimeZoneTime_Zone_ID",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Address_ID",
                table: "AspNetUsers",
                column: "Address_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Locale_ID",
                table: "AspNetUsers",
                column: "Locale_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Tenant_ID",
                table: "AspNetUsers",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Time_Zone_ID",
                table: "AspNetUsers",
                column: "Time_Zone_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TmX_Address_Address_ID",
                table: "AspNetUsers",
                column: "Address_ID",
                principalTable: "TmX_Address",
                principalColumn: "Address_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TmX_Locale_Locale_ID",
                table: "AspNetUsers",
                column: "Locale_ID",
                principalTable: "TmX_Locale",
                principalColumn: "Locale_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TmX_Tenants_Tenant_ID",
                table: "AspNetUsers",
                column: "Tenant_ID",
                principalTable: "TmX_Tenants",
                principalColumn: "Tenant_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TmX_Time_Zone_Time_Zone_ID",
                table: "AspNetUsers",
                column: "Time_Zone_ID",
                principalTable: "TmX_Time_Zone",
                principalColumn: "Time_Zone_ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TmX_Address_Address_ID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TmX_Locale_Locale_ID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TmX_Tenants_Tenant_ID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TmX_Time_Zone_Time_Zone_ID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Address_ID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Locale_ID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Tenant_ID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Time_Zone_ID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Address_ID1",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Locale_ID1",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tenant_ID1",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TimeZoneTime_Zone_ID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Address_ID1",
                table: "AspNetUsers",
                column: "Address_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Locale_ID1",
                table: "AspNetUsers",
                column: "Locale_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Tenant_ID1",
                table: "AspNetUsers",
                column: "Tenant_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TimeZoneTime_Zone_ID",
                table: "AspNetUsers",
                column: "TimeZoneTime_Zone_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TmX_Address_Address_ID1",
                table: "AspNetUsers",
                column: "Address_ID1",
                principalTable: "TmX_Address",
                principalColumn: "Address_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TmX_Locale_Locale_ID1",
                table: "AspNetUsers",
                column: "Locale_ID1",
                principalTable: "TmX_Locale",
                principalColumn: "Locale_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TmX_Tenants_Tenant_ID1",
                table: "AspNetUsers",
                column: "Tenant_ID1",
                principalTable: "TmX_Tenants",
                principalColumn: "Tenant_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TmX_Time_Zone_TimeZoneTime_Zone_ID",
                table: "AspNetUsers",
                column: "TimeZoneTime_Zone_ID",
                principalTable: "TmX_Time_Zone",
                principalColumn: "Time_Zone_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
