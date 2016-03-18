using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Data.Migrations
{
    public partial class rc2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Bill_Address_AddressId", table: "Bill");
            migrationBuilder.DropForeignKey(name: "FK_Bill_Customer_Customerid", table: "Bill");
            migrationBuilder.DropForeignKey(name: "FK_Customer_Address_DeliveryAddressId", table: "Customer");
            migrationBuilder.DropForeignKey(name: "FK_Position_Bill_BillId", table: "Position");
            migrationBuilder.DropForeignKey(name: "FK_Reversal_Bill_ReferenceBillId", table: "Reversal");
            migrationBuilder.AlterColumn<Guid>(
                name: "BillingAddressId",
                table: "Customer",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Address_AddressId",
                table: "Bill",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Customer_Customerid",
                table: "Bill",
                column: "Customerid",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Address_DeliveryAddressId",
                table: "Customer",
                column: "DeliveryAddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Position_Bill_BillId",
                table: "Position",
                column: "BillId",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Reversal_Bill_ReferenceBillId",
                table: "Reversal",
                column: "ReferenceBillId",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Bill_Address_AddressId", table: "Bill");
            migrationBuilder.DropForeignKey(name: "FK_Bill_Customer_Customerid", table: "Bill");
            migrationBuilder.DropForeignKey(name: "FK_Customer_Address_DeliveryAddressId", table: "Customer");
            migrationBuilder.DropForeignKey(name: "FK_Position_Bill_BillId", table: "Position");
            migrationBuilder.DropForeignKey(name: "FK_Reversal_Bill_ReferenceBillId", table: "Reversal");
            migrationBuilder.AlterColumn<Guid>(
                name: "BillingAddressId",
                table: "Customer",
                nullable: false);
            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Address_AddressId",
                table: "Bill",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Customer_Customerid",
                table: "Bill",
                column: "Customerid",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Address_DeliveryAddressId",
                table: "Customer",
                column: "DeliveryAddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Position_Bill_BillId",
                table: "Position",
                column: "BillId",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Reversal_Bill_ReferenceBillId",
                table: "Reversal",
                column: "ReferenceBillId",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
