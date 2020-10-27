using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporX.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnswerQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(maxLength: 200, nullable: true),
                    Questions = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AskedQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(maxLength: 100, nullable: true),
                    Questions = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AskedQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Breadcrumbs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breadcrumbs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinesSolutionItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(type: "ntext", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinesSolutionItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinesSolutions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Text = table.Column<string>(maxLength: 200, nullable: true),
                    Photo = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinesSolutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ButtonDownloads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Icon = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ButtonDownloads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "ntext", maxLength: 300, nullable: true),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Company = table.Column<string>(maxLength: 50, nullable: false),
                    Photo = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliverServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Text = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliverServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Downloads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Downloads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LastHeads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastHeads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Position = table.Column<string>(maxLength: 100, nullable: false),
                    About = table.Column<string>(maxLength: 200, nullable: true),
                    Photo = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Desc = table.Column<string>(maxLength: 200, nullable: false),
                    TotalProjectPrice = table.Column<int>(maxLength: 50, nullable: false),
                    TotalCustomerPrice = table.Column<int>(maxLength: 50, nullable: false),
                    TotalProject = table.Column<int>(maxLength: 50, nullable: false),
                    Photo = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MostPartners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About = table.Column<string>(maxLength: 100, nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Desc = table.Column<string>(type: "ntext", nullable: true),
                    Button = table.Column<string>(maxLength: 50, nullable: true),
                    Photo = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MostPartners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Photo = table.Column<string>(maxLength: 200, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Position = table.Column<string>(maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "ntext", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderBy = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Photo = table.Column<string>(maxLength: 200, nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Options = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(maxLength: 100, nullable: true),
                    Url = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDescriptionItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDescriptionItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Desc = table.Column<string>(maxLength: 250, nullable: false),
                    Photo = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(maxLength: 100, nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Desc = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Icon = table.Column<string>(maxLength: 100, nullable: false),
                    Text = table.Column<string>(type: "ntext", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    HeadAdress = table.Column<string>(maxLength: 100, nullable: true),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    HeadquartersAdress = table.Column<string>(maxLength: 150, nullable: true),
                    HeadquartersPhone = table.Column<string>(maxLength: 100, nullable: true),
                    HeadquartersEmail = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SosialLinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderBy = table.Column<int>(nullable: false),
                    Icon = table.Column<string>(maxLength: 50, nullable: false),
                    Url = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosialLinks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryWorkId = table.Column<string>(nullable: false),
                    Position = table.Column<string>(maxLength: 50, nullable: false),
                    Specialty = table.Column<string>(maxLength: 50, nullable: false),
                    Photo = table.Column<string>(maxLength: 100, nullable: true),
                    CategoryWorkId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_CategoryWorks_CategoryWorkId1",
                        column: x => x.CategoryWorkId1,
                        principalTable: "CategoryWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberLinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Url = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberLinks_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberLinks_MemberId",
                table: "MemberLinks",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CategoryWorkId1",
                table: "Projects",
                column: "CategoryWorkId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerQuestions");

            migrationBuilder.DropTable(
                name: "AskedQuestions");

            migrationBuilder.DropTable(
                name: "Breadcrumbs");

            migrationBuilder.DropTable(
                name: "BusinesSolutionItems");

            migrationBuilder.DropTable(
                name: "BusinesSolutions");

            migrationBuilder.DropTable(
                name: "ButtonDownloads");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "DeliverServices");

            migrationBuilder.DropTable(
                name: "Downloads");

            migrationBuilder.DropTable(
                name: "LastHeads");

            migrationBuilder.DropTable(
                name: "MemberLinks");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "MostPartners");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "ProjectDescriptionItems");

            migrationBuilder.DropTable(
                name: "ProjectDescriptions");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Promos");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "SosialLinks");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "CategoryWorks");
        }
    }
}
