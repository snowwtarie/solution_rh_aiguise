﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using rh.Models;
using System;

namespace rh.Migrations
{
    [DbContext(typeof(RhContext))]
    partial class RhContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("rh.Models.Collaborateur", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Addresse");

                    b.Property<string>("CodePostal");

                    b.Property<DateTime>("DateEmbauche");

                    b.Property<DateTime>("DateNaissance");

                    b.Property<string>("Email");

                    b.Property<string>("Genre");

                    b.Property<string>("Nationalite");

                    b.Property<string>("NoSecu");

                    b.Property<string>("Nom");

                    b.Property<string>("NumeroFixe");

                    b.Property<string>("NumeroPortable");

                    b.Property<string>("Prenom");

                    b.Property<int>("ServiceId");

                    b.Property<string>("Ville");

                    b.HasKey("ID");

                    b.HasIndex("ServiceId");

                    b.ToTable("Collaborateur");
                });

            modelBuilder.Entity("rh.Models.Conge", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CollaborateurId");

                    b.Property<string>("Commentaire");

                    b.Property<DateTime>("DateDebut");

                    b.Property<DateTime>("DateDemande");

                    b.Property<DateTime>("DateFin");

                    b.Property<bool>("Decision");

                    b.Property<string>("NomResponsable");

                    b.Property<char>("PeriodeDebut");

                    b.Property<char>("PeriodeFin");

                    b.Property<string>("PrenomResponsable");

                    b.Property<int>("TypeCongeId");

                    b.HasKey("ID");

                    b.HasIndex("CollaborateurId");

                    b.HasIndex("TypeCongeId");

                    b.ToTable("Conge");
                });

            modelBuilder.Entity("rh.Models.Contrat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CollaborateurId");

                    b.Property<DateTime>("DateDebut");

                    b.Property<DateTime>("DateFin");

                    b.Property<int>("TypeContratId");

                    b.HasKey("ID");

                    b.HasIndex("CollaborateurId");

                    b.HasIndex("TypeContratId");

                    b.ToTable("Contrat");
                });

            modelBuilder.Entity("rh.Models.Depense", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AvionTrain");

                    b.Property<string>("Commentaire");

                    b.Property<string>("CommentaireRefus");

                    b.Property<DateTime>("DateDepense");

                    b.Property<decimal>("Divers");

                    b.Property<decimal>("Hotel");

                    b.Property<decimal>("LocationVoiture");

                    b.Property<string>("MotifDepense");

                    b.Property<string>("NomClient");

                    b.Property<decimal>("NombreKms");

                    b.Property<decimal>("ParkingPeage");

                    b.Property<decimal>("Restaurant");

                    b.Property<decimal>("TauxDevise");

                    b.Property<decimal>("TaxiBus");

                    b.Property<int>("TypeDepenseId");

                    b.Property<string>("VilleClient");

                    b.HasKey("ID");

                    b.HasIndex("TypeDepenseId");

                    b.ToTable("Depense");
                });

            modelBuilder.Entity("rh.Models.Service", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("ID");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("rh.Models.TypeConge", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("ID");

                    b.ToTable("TypeConge");
                });

            modelBuilder.Entity("rh.Models.TypeContrat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("ID");

                    b.ToTable("TypeContrat");
                });

            modelBuilder.Entity("rh.Models.TypeDepense", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("ID");

                    b.ToTable("TypeDepense");
                });

            modelBuilder.Entity("rh.Models.Collaborateur", b =>
                {
                    b.HasOne("rh.Models.Service", "Service")
                        .WithMany("Collaborateurs")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("rh.Models.Conge", b =>
                {
                    b.HasOne("rh.Models.Collaborateur", "Collaborateur")
                        .WithMany("Conges")
                        .HasForeignKey("CollaborateurId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("rh.Models.TypeConge", "TypeConge")
                        .WithMany("Conges")
                        .HasForeignKey("TypeCongeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("rh.Models.Contrat", b =>
                {
                    b.HasOne("rh.Models.Collaborateur", "Collaborateur")
                        .WithMany("Contrats")
                        .HasForeignKey("CollaborateurId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("rh.Models.TypeContrat", "TypeContrat")
                        .WithMany("Contrats")
                        .HasForeignKey("TypeContratId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("rh.Models.Depense", b =>
                {
                    b.HasOne("rh.Models.TypeDepense", "TypeDepense")
                        .WithMany("Depenses")
                        .HasForeignKey("TypeDepenseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
