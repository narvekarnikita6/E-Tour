using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETourProject1.Migrations
{
    /// <inheritdoc />
    public partial class Initiallast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryMaster",
                columns: table => new
                {
                    CatMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCatId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMaster", x => x.CatMasterId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerMaster",
                columns: table => new
                {
                    CustId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<int>(type: "int", nullable: true),
                    MobileNumber = table.Column<long>(type: "bigint", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdharNumber = table.Column<long>(type: "bigint", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerMaster", x => x.CustId);
                });

            migrationBuilder.CreateTable(
                name: "PackageMaster",
                columns: table => new
                {
                    PkgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PkgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatMasterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageMaster", x => x.PkgId);
                    table.ForeignKey(
                        name: "FK_PackageMaster_CategoryMaster_CatMasterId",
                        column: x => x.CatMasterId,
                        principalTable: "CategoryMaster",
                        principalColumn: "CatMasterId");
                });

            migrationBuilder.CreateTable(
                name: "Passanger",
                columns: table => new
                {
                    PassangerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassangerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassangerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassangerAmount = table.Column<int>(type: "int", nullable: true),
                    CustId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passanger", x => x.PassangerId);
                    table.ForeignKey(
                        name: "FK_Passanger_CustomerMaster_CustId",
                        column: x => x.CustId,
                        principalTable: "CustomerMaster",
                        principalColumn: "CustId");
                });

            migrationBuilder.CreateTable(
                name: "CostMaster",
                columns: table => new
                {
                    CostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cost = table.Column<int>(type: "int", nullable: true),
                    SinglePersonCost = table.Column<int>(type: "int", nullable: true),
                    ExtraPersonCost = table.Column<int>(type: "int", nullable: true),
                    ChildWithBed = table.Column<int>(type: "int", nullable: true),
                    ChildWithoutBed = table.Column<int>(type: "int", nullable: true),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PkgId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostMaster", x => x.CostId);
                    table.ForeignKey(
                        name: "FK_CostMaster_PackageMaster_PkgId",
                        column: x => x.PkgId,
                        principalTable: "PackageMaster",
                        principalColumn: "PkgId");
                });

            migrationBuilder.CreateTable(
                name: "DateMaster",
                columns: table => new
                {
                    DepartureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberOfDays = table.Column<int>(type: "int", nullable: true),
                    PkgId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateMaster", x => x.DepartureId);
                    table.ForeignKey(
                        name: "FK_DateMaster_PackageMaster_PkgId",
                        column: x => x.PkgId,
                        principalTable: "PackageMaster",
                        principalColumn: "PkgId");
                });

            migrationBuilder.CreateTable(
                name: "ItineraryMaster",
                columns: table => new
                {
                    ItrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayNo = table.Column<int>(type: "int", nullable: true),
                    ItrDtl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PkgId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItineraryMaster", x => x.ItrId);
                    table.ForeignKey(
                        name: "FK_ItineraryMaster_PackageMaster_PkgId",
                        column: x => x.PkgId,
                        principalTable: "PackageMaster",
                        principalColumn: "PkgId");
                });

            migrationBuilder.CreateTable(
                name: "BookingHeaders",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberOfPassengers = table.Column<int>(type: "int", nullable: true),
                    TourAmount = table.Column<int>(type: "int", nullable: true),
                    Taxes = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<int>(type: "int", nullable: true),
                    PkgId = table.Column<int>(type: "int", nullable: true),
                    DepartureId = table.Column<int>(type: "int", nullable: true),
                    CustId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingHeaders", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_BookingHeaders_CustomerMaster_CustId",
                        column: x => x.CustId,
                        principalTable: "CustomerMaster",
                        principalColumn: "CustId");
                    table.ForeignKey(
                        name: "FK_BookingHeaders_DateMaster_DepartureId",
                        column: x => x.DepartureId,
                        principalTable: "DateMaster",
                        principalColumn: "DepartureId");
                    table.ForeignKey(
                        name: "FK_BookingHeaders_PackageMaster_PkgId",
                        column: x => x.PkgId,
                        principalTable: "PackageMaster",
                        principalColumn: "PkgId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingHeaders_CustId",
                table: "BookingHeaders",
                column: "CustId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingHeaders_DepartureId",
                table: "BookingHeaders",
                column: "DepartureId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingHeaders_PkgId",
                table: "BookingHeaders",
                column: "PkgId");

            migrationBuilder.CreateIndex(
                name: "IX_CostMaster_PkgId",
                table: "CostMaster",
                column: "PkgId");

            migrationBuilder.CreateIndex(
                name: "IX_DateMaster_PkgId",
                table: "DateMaster",
                column: "PkgId");

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryMaster_PkgId",
                table: "ItineraryMaster",
                column: "PkgId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageMaster_CatMasterId",
                table: "PackageMaster",
                column: "CatMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Passanger_CustId",
                table: "Passanger",
                column: "CustId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingHeaders");

            migrationBuilder.DropTable(
                name: "CostMaster");

            migrationBuilder.DropTable(
                name: "ItineraryMaster");

            migrationBuilder.DropTable(
                name: "Passanger");

            migrationBuilder.DropTable(
                name: "DateMaster");

            migrationBuilder.DropTable(
                name: "CustomerMaster");

            migrationBuilder.DropTable(
                name: "PackageMaster");

            migrationBuilder.DropTable(
                name: "CategoryMaster");
        }
    }
}
