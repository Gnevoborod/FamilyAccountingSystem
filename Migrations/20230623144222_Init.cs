using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FamilyAccountingSystem.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "family",
                columns: table => new
                {
                    family_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_family", x => x.family_id);
                });

            migrationBuilder.CreateTable(
                name: "family_role",
                columns: table => new
                {
                    family_role_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_family_role", x => x.family_role_id);
                });

            migrationBuilder.CreateTable(
                name: "member",
                columns: table => new
                {
                    member_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    surname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    patronymic = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    birthday = table.Column<DateOnly>(type: "date", nullable: true),
                    gender = table.Column<bool>(type: "boolean", nullable: true),
                    phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_member", x => x.member_id);
                });

            migrationBuilder.CreateTable(
                name: "own",
                columns: table => new
                {
                    own_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_own", x => x.own_id);
                });

            migrationBuilder.CreateTable(
                name: "property",
                columns: table => new
                {
                    property_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_property", x => x.property_id);
                });

            migrationBuilder.CreateTable(
                name: "family_member",
                columns: table => new
                {
                    member_id = table.Column<long>(type: "bigint", nullable: false),
                    family_id = table.Column<long>(type: "bigint", nullable: false),
                    start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    family_role_id = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_family_member_family_family_id",
                        column: x => x.family_id,
                        principalTable: "family",
                        principalColumn: "family_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_family_member_family_role_family_role_id",
                        column: x => x.family_role_id,
                        principalTable: "family_role",
                        principalColumn: "family_role_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_family_member_member_member_id",
                        column: x => x.member_id,
                        principalTable: "member",
                        principalColumn: "member_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "famiy_member_property",
                columns: table => new
                {
                    famiy_member_property_id = table.Column<long>(type: "bigint", nullable: false),
                    member_id = table.Column<long>(type: "bigint", nullable: false),
                    own_id = table.Column<long>(type: "bigint", nullable: false),
                    start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_famiy_member_property_family_famiy_member_property_id",
                        column: x => x.famiy_member_property_id,
                        principalTable: "family",
                        principalColumn: "family_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_famiy_member_property_member_member_id",
                        column: x => x.member_id,
                        principalTable: "member",
                        principalColumn: "member_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_famiy_member_property_own_own_id",
                        column: x => x.own_id,
                        principalTable: "own",
                        principalColumn: "own_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "own_property_family",
                columns: table => new
                {
                    family_id = table.Column<long>(type: "bigint", nullable: false),
                    property_id = table.Column<long>(type: "bigint", nullable: false),
                    own_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_own_property_family_family_family_id",
                        column: x => x.family_id,
                        principalTable: "family",
                        principalColumn: "family_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_own_property_family_own_own_id",
                        column: x => x.own_id,
                        principalTable: "own",
                        principalColumn: "own_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_own_property_family_property_property_id",
                        column: x => x.property_id,
                        principalTable: "property",
                        principalColumn: "property_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_family_member_family_id",
                table: "family_member",
                column: "family_id");

            migrationBuilder.CreateIndex(
                name: "IX_family_member_family_role_id",
                table: "family_member",
                column: "family_role_id");

            migrationBuilder.CreateIndex(
                name: "IX_family_member_member_id",
                table: "family_member",
                column: "member_id");

            migrationBuilder.CreateIndex(
                name: "IX_famiy_member_property_famiy_member_property_id",
                table: "famiy_member_property",
                column: "famiy_member_property_id");

            migrationBuilder.CreateIndex(
                name: "IX_famiy_member_property_member_id",
                table: "famiy_member_property",
                column: "member_id");

            migrationBuilder.CreateIndex(
                name: "IX_famiy_member_property_own_id",
                table: "famiy_member_property",
                column: "own_id");

            migrationBuilder.CreateIndex(
                name: "IX_own_property_family_family_id",
                table: "own_property_family",
                column: "family_id");

            migrationBuilder.CreateIndex(
                name: "IX_own_property_family_own_id",
                table: "own_property_family",
                column: "own_id");

            migrationBuilder.CreateIndex(
                name: "IX_own_property_family_property_id",
                table: "own_property_family",
                column: "property_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "family_member");

            migrationBuilder.DropTable(
                name: "famiy_member_property");

            migrationBuilder.DropTable(
                name: "own_property_family");

            migrationBuilder.DropTable(
                name: "family_role");

            migrationBuilder.DropTable(
                name: "member");

            migrationBuilder.DropTable(
                name: "family");

            migrationBuilder.DropTable(
                name: "own");

            migrationBuilder.DropTable(
                name: "property");
        }
    }
}
