using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShopAPI.Migrations
{
    public partial class ProductAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "Categorys");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Categorys",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Categorys",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_Id",
                table: "Products",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_CategoryId",
                table: "Categorys",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorys_Categorys_CategoryId",
                table: "Categorys",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categorys_Category_Id",
                table: "Products",
                column: "Category_Id",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorys_Categorys_CategoryId",
                table: "Categorys");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categorys_Category_Id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Category_Id",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys");

            migrationBuilder.DropIndex(
                name: "IX_Categorys_CategoryId",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Categorys");

            migrationBuilder.AddColumn<int>(
                name: "Category_Id",
                table: "Categorys",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys",
                column: "Category_Id");
        }
    }
}
