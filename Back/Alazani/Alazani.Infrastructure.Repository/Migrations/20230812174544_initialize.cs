using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Alazani.Infrastructure.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "AlazaniDb");

            migrationBuilder.CreateTable(
                name: "Currency",
                schema: "AlazaniDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RecordStatus = table.Column<byte>(type: "smallint", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                schema: "AlazaniDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    RecordStatus = table.Column<byte>(type: "smallint", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                schema: "AlazaniDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "varchar", maxLength: 90, nullable: false),
                    RecordStatus = table.Column<byte>(type: "smallint", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "AlazaniDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    RecordStatus = table.Column<byte>(type: "smallint", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Org_Categories",
                        column: x => x.OrganizationId,
                        principalSchema: "AlazaniDb",
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "AlazaniDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    RecordStatus = table.Column<byte>(type: "smallint", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Org_Roles",
                        column: x => x.OrganizationId,
                        principalSchema: "AlazaniDb",
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "AlazaniDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    RecordStatus = table.Column<byte>(type: "smallint", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Products",
                        column: x => x.CategoryId,
                        principalSchema: "AlazaniDb",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Org_Products",
                        column: x => x.OrganizationId,
                        principalSchema: "AlazaniDb",
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "AlazaniDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    RecordStatus = table.Column<byte>(type: "smallint", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Org_Users",
                        column: x => x.OrganizationId,
                        principalSchema: "AlazaniDb",
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Role_Users",
                        column: x => x.RoleId,
                        principalSchema: "AlazaniDb",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Price",
                schema: "AlazaniDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    CurrencyId = table.Column<int>(type: "integer", nullable: false),
                    RecordStatus = table.Column<byte>(type: "smallint", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Currency_Prices",
                        column: x => x.CurrencyId,
                        principalSchema: "AlazaniDb",
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Prices",
                        column: x => x.ProductId,
                        principalSchema: "AlazaniDb",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_OrganizationId",
                schema: "AlazaniDb",
                table: "Category",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_RecordStatus",
                schema: "AlazaniDb",
                table: "Category",
                column: "RecordStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Currency_RecordStatus",
                schema: "AlazaniDb",
                table: "Currency",
                column: "RecordStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_RecordStatus",
                schema: "AlazaniDb",
                table: "Organization",
                column: "RecordStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Price_CurrencyId",
                schema: "AlazaniDb",
                table: "Price",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_ProductId",
                schema: "AlazaniDb",
                table: "Price",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_RecordStatus",
                schema: "AlazaniDb",
                table: "Price",
                column: "RecordStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                schema: "AlazaniDb",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrganizationId",
                schema: "AlazaniDb",
                table: "Product",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_RecordStatus",
                schema: "AlazaniDb",
                table: "Product",
                column: "RecordStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Role_OrganizationId",
                schema: "AlazaniDb",
                table: "Role",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Test_RecordStatus",
                schema: "AlazaniDb",
                table: "Test",
                column: "RecordStatus");

            migrationBuilder.CreateIndex(
                name: "IX_User_OrganizationId",
                schema: "AlazaniDb",
                table: "User",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RecordStatus",
                schema: "AlazaniDb",
                table: "User",
                column: "RecordStatus");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                schema: "AlazaniDb",
                table: "User",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Price",
                schema: "AlazaniDb");

            migrationBuilder.DropTable(
                name: "Test",
                schema: "AlazaniDb");

            migrationBuilder.DropTable(
                name: "User",
                schema: "AlazaniDb");

            migrationBuilder.DropTable(
                name: "Currency",
                schema: "AlazaniDb");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "AlazaniDb");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "AlazaniDb");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "AlazaniDb");

            migrationBuilder.DropTable(
                name: "Organization",
                schema: "AlazaniDb");
        }
    }
}
