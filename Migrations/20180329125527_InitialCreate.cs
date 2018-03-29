using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace rh.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypeConge",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeConge", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypeContrat",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeContrat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypeDepense",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDepense", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Collaborateur",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Addresse = table.Column<string>(nullable: true),
                    CodePostal = table.Column<string>(nullable: true),
                    DateEmbauche = table.Column<DateTime>(nullable: false),
                    DateNaissance = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Nationalite = table.Column<string>(nullable: true),
                    NoSecu = table.Column<string>(nullable: true),
                    Nom = table.Column<string>(nullable: true),
                    NumeroFixe = table.Column<string>(nullable: true),
                    NumeroPortable = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    ServiceID = table.Column<int>(nullable: true),
                    Ville = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborateur", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Collaborateur_Service_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Service",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Depense",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AvionTrain = table.Column<decimal>(nullable: false),
                    Commentaire = table.Column<string>(nullable: true),
                    CommentaireRefus = table.Column<string>(nullable: true),
                    DateDepense = table.Column<DateTime>(nullable: false),
                    Divers = table.Column<decimal>(nullable: false),
                    Hotel = table.Column<decimal>(nullable: false),
                    LocationVoiture = table.Column<decimal>(nullable: false),
                    MotifDepense = table.Column<string>(nullable: true),
                    NomClient = table.Column<string>(nullable: true),
                    NombreKms = table.Column<decimal>(nullable: false),
                    ParkingPeage = table.Column<decimal>(nullable: false),
                    Restaurant = table.Column<decimal>(nullable: false),
                    TauxDevise = table.Column<decimal>(nullable: false),
                    TaxiBus = table.Column<decimal>(nullable: false),
                    TypeDepenseID = table.Column<int>(nullable: true),
                    VilleClient = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depense", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Depense_TypeDepense_TypeDepenseID",
                        column: x => x.TypeDepenseID,
                        principalTable: "TypeDepense",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conge",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CollaborateurID = table.Column<int>(nullable: true),
                    Commentaire = table.Column<string>(nullable: true),
                    DateDebut = table.Column<DateTime>(nullable: false),
                    DateDemande = table.Column<DateTime>(nullable: false),
                    DateFin = table.Column<DateTime>(nullable: false),
                    Decision = table.Column<bool>(nullable: false),
                    NomResponsable = table.Column<string>(nullable: true),
                    PeriodeDebut = table.Column<char>(nullable: false),
                    PeriodeFin = table.Column<char>(nullable: false),
                    PrenomResponsable = table.Column<string>(nullable: true),
                    TypeCongeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conge", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Conge_Collaborateur_CollaborateurID",
                        column: x => x.CollaborateurID,
                        principalTable: "Collaborateur",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conge_TypeConge_TypeCongeID",
                        column: x => x.TypeCongeID,
                        principalTable: "TypeConge",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contrat",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateDebut = table.Column<DateTime>(nullable: false),
                    DateFin = table.Column<DateTime>(nullable: false),
                    TypeContratID = table.Column<int>(nullable: true),
                    collaborateurID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contrat_TypeContrat_TypeContratID",
                        column: x => x.TypeContratID,
                        principalTable: "TypeContrat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contrat_Collaborateur_collaborateurID",
                        column: x => x.collaborateurID,
                        principalTable: "Collaborateur",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Collaborateur_ServiceID",
                table: "Collaborateur",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Conge_CollaborateurID",
                table: "Conge",
                column: "CollaborateurID");

            migrationBuilder.CreateIndex(
                name: "IX_Conge_TypeCongeID",
                table: "Conge",
                column: "TypeCongeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contrat_TypeContratID",
                table: "Contrat",
                column: "TypeContratID");

            migrationBuilder.CreateIndex(
                name: "IX_Contrat_collaborateurID",
                table: "Contrat",
                column: "collaborateurID");

            migrationBuilder.CreateIndex(
                name: "IX_Depense_TypeDepenseID",
                table: "Depense",
                column: "TypeDepenseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conge");

            migrationBuilder.DropTable(
                name: "Contrat");

            migrationBuilder.DropTable(
                name: "Depense");

            migrationBuilder.DropTable(
                name: "TypeConge");

            migrationBuilder.DropTable(
                name: "TypeContrat");

            migrationBuilder.DropTable(
                name: "Collaborateur");

            migrationBuilder.DropTable(
                name: "TypeDepense");

            migrationBuilder.DropTable(
                name: "Service");
        }
    }
}
