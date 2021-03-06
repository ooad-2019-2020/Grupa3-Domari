﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentskiDom.Models;

namespace StudentskiDom.Migrations
{
    [DbContext(typeof(StudentskiDomContext))]
    [Migration("20200604142649_MjernaJedinica")]
    partial class MjernaJedinica
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StudentskiDom.Models.Blagajna", b =>
                {
                    b.Property<int>("BlagajnaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("StanjeBudgeta")
                        .HasColumnType("float");

                    b.Property<int>("UpravaId")
                        .HasColumnType("int");

                    b.HasKey("BlagajnaId");

                    b.HasIndex("UpravaId")
                        .IsUnique();

                    b.ToTable("Blagajna");
                });

            modelBuilder.Entity("StudentskiDom.Models.DnevniMeni", b =>
                {
                    b.Property<int>("DnevniMeniId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("DnevniMeniId");

                    b.ToTable("DnevniMeni");
                });

            modelBuilder.Entity("StudentskiDom.Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestoranId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RestoranId");

                    b.HasIndex("StudentId");

                    b.ToTable("Korisnik");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Korisnik");
                });

            modelBuilder.Entity("StudentskiDom.Models.LicniPodaci", b =>
                {
                    b.Property<int>("LicniPodaciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Jmbg")
                        .HasColumnType("bigint");

                    b.Property<string>("MjestoRodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mobitel")
                        .HasColumnType("int");

                    b.Property<int>("Pol")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LicniPodaciId");

                    b.ToTable("LicniPodaci");
                });

            modelBuilder.Entity("StudentskiDom.Models.Mjesec", b =>
                {
                    b.Property<int>("MjesecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("MjesecId");

                    b.HasIndex("StudentId");

                    b.ToTable("Mjesec");
                });

            modelBuilder.Entity("StudentskiDom.Models.Paviljon", b =>
                {
                    b.Property<int>("PaviljonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojStudenata")
                        .HasColumnType("int");

                    b.Property<int>("Kapacitet")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaviljonId");

                    b.ToTable("Paviljon");
                });

            modelBuilder.Entity("StudentskiDom.Models.PrebivalisteInfo", b =>
                {
                    b.Property<int>("PrebivalisteInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kanton")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opcina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrebivalisteInfoId");

                    b.ToTable("PrebivalisteInfo");
                });

            modelBuilder.Entity("StudentskiDom.Models.Rucak", b =>
                {
                    b.Property<int>("RucakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DnevniMeniId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RucakId");

                    b.HasIndex("DnevniMeniId");

                    b.ToTable("Rucak");
                });

            modelBuilder.Entity("StudentskiDom.Models.SkolovanjeInfo", b =>
                {
                    b.Property<int>("SkolovanjeInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojIndeksa")
                        .HasColumnType("int");

                    b.Property<int>("CiklusStudija")
                        .HasColumnType("int");

                    b.Property<string>("Fakultet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GodinaStudija")
                        .HasColumnType("int");

                    b.HasKey("SkolovanjeInfoId");

                    b.ToTable("SkolovanjeInfo");
                });

            modelBuilder.Entity("StudentskiDom.Models.Soba", b =>
                {
                    b.Property<int>("SobaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojSobe")
                        .HasColumnType("int");

                    b.Property<int>("Kapacitet")
                        .HasColumnType("int");

                    b.Property<int>("PaviljonId")
                        .HasColumnType("int");

                    b.HasKey("SobaId");

                    b.HasIndex("PaviljonId");

                    b.ToTable("Soba");
                });

            modelBuilder.Entity("StudentskiDom.Models.StavkaNarudzbe", b =>
                {
                    b.Property<int>("StavkaNarudzbeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Kolicina")
                        .HasColumnType("float");

                    b.Property<string>("MjernaJedinica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Namirnica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZahtjevZaNabavkuNamirnicaId")
                        .HasColumnType("int");

                    b.HasKey("StavkaNarudzbeId");

                    b.HasIndex("ZahtjevZaNabavkuNamirnicaId");

                    b.ToTable("StavkaNarudzbe");
                });

            modelBuilder.Entity("StudentskiDom.Models.Vecera", b =>
                {
                    b.Property<int>("VeceraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DnevniMeniId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VeceraId");

                    b.HasIndex("DnevniMeniId");

                    b.ToTable("Vecera");
                });

            modelBuilder.Entity("StudentskiDom.Models.Zahtjev", b =>
                {
                    b.Property<int>("ZahtjevId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Odobren")
                        .HasColumnType("bit");

                    b.Property<int?>("ZahtjevRestoranaZahtjevId")
                        .HasColumnType("int");

                    b.Property<int?>("ZahtjevStudentaZahtjevId")
                        .HasColumnType("int");

                    b.Property<int?>("ZahtjevZaUpisZahtjevId")
                        .HasColumnType("int");

                    b.HasKey("ZahtjevId");

                    b.HasIndex("ZahtjevRestoranaZahtjevId");

                    b.HasIndex("ZahtjevStudentaZahtjevId");

                    b.HasIndex("ZahtjevZaUpisZahtjevId");

                    b.ToTable("Zahtjev");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Zahtjev");
                });

            modelBuilder.Entity("StudentskiDom.Models.Restoran", b =>
                {
                    b.HasBaseType("StudentskiDom.Models.Korisnik");

                    b.Property<int>("DnevniMeniId")
                        .HasColumnType("int");

                    b.HasIndex("DnevniMeniId")
                        .IsUnique()
                        .HasFilter("[DnevniMeniId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Restoran");
                });

            modelBuilder.Entity("StudentskiDom.Models.Student", b =>
                {
                    b.HasBaseType("StudentskiDom.Models.Korisnik");

                    b.Property<int>("BrojRucaka")
                        .HasColumnType("int");

                    b.Property<int>("BrojVecera")
                        .HasColumnType("int");

                    b.Property<int>("LicniPodaciId")
                        .HasColumnType("int");

                    b.Property<int>("PrebivalisteInfoId")
                        .HasColumnType("int");

                    b.Property<int>("SkolovanjeInfoId")
                        .HasColumnType("int");

                    b.Property<int>("SobaId")
                        .HasColumnType("int");

                    b.HasIndex("LicniPodaciId")
                        .IsUnique()
                        .HasFilter("[LicniPodaciId] IS NOT NULL");

                    b.HasIndex("PrebivalisteInfoId")
                        .IsUnique()
                        .HasFilter("[PrebivalisteInfoId] IS NOT NULL");

                    b.HasIndex("SkolovanjeInfoId")
                        .IsUnique()
                        .HasFilter("[SkolovanjeInfoId] IS NOT NULL");

                    b.HasIndex("SobaId");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("StudentskiDom.Models.Uprava", b =>
                {
                    b.HasBaseType("StudentskiDom.Models.Korisnik");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.HasIndex("KorisnikId")
                        .IsUnique()
                        .HasFilter("[KorisnikId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Uprava");
                });

            modelBuilder.Entity("StudentskiDom.Models.ZahtjevRestorana", b =>
                {
                    b.HasBaseType("StudentskiDom.Models.Zahtjev");

                    b.Property<int>("RestoranId")
                        .HasColumnType("int");

                    b.HasIndex("RestoranId")
                        .IsUnique()
                        .HasFilter("[RestoranId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("ZahtjevRestorana");
                });

            modelBuilder.Entity("StudentskiDom.Models.ZahtjevStudenta", b =>
                {
                    b.HasBaseType("StudentskiDom.Models.Zahtjev");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasIndex("StudentId")
                        .IsUnique()
                        .HasFilter("[StudentId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("ZahtjevStudenta");
                });

            modelBuilder.Entity("StudentskiDom.Models.ZahtjevZaUpis", b =>
                {
                    b.HasBaseType("StudentskiDom.Models.Zahtjev");

                    b.Property<int>("LicniPodaciId")
                        .HasColumnType("int");

                    b.Property<int>("PrebivalisteInfoId")
                        .HasColumnType("int");

                    b.Property<int>("SkolovanjeInfoId")
                        .HasColumnType("int");

                    b.HasIndex("LicniPodaciId")
                        .IsUnique()
                        .HasFilter("[LicniPodaciId] IS NOT NULL");

                    b.HasIndex("PrebivalisteInfoId")
                        .IsUnique()
                        .HasFilter("[PrebivalisteInfoId] IS NOT NULL");

                    b.HasIndex("SkolovanjeInfoId")
                        .IsUnique()
                        .HasFilter("[SkolovanjeInfoId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("ZahtjevZaUpis");
                });

            modelBuilder.Entity("StudentskiDom.Models.ZahtjevZaNabavkuNamirnica", b =>
                {
                    b.HasBaseType("StudentskiDom.Models.ZahtjevRestorana");

                    b.HasDiscriminator().HasValue("ZahtjevZaNabavkuNamirnica");
                });

            modelBuilder.Entity("StudentskiDom.Models.ZahtjevZaCimeraj", b =>
                {
                    b.HasBaseType("StudentskiDom.Models.ZahtjevStudenta");

                    b.Property<int>("Cimer1Id")
                        .HasColumnType("int");

                    b.Property<int>("Cimer2Id")
                        .HasColumnType("int");

                    b.Property<string>("DodatneNapomene")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaviljonId")
                        .HasColumnType("int");

                    b.Property<int>("SobaId")
                        .HasColumnType("int");

                    b.HasIndex("Cimer1Id");

                    b.HasIndex("Cimer2Id");

                    b.HasIndex("PaviljonId")
                        .IsUnique()
                        .HasFilter("[PaviljonId] IS NOT NULL");

                    b.HasIndex("SobaId")
                        .IsUnique()
                        .HasFilter("[SobaId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("ZahtjevZaCimeraj");
                });

            modelBuilder.Entity("StudentskiDom.Models.ZahtjevZaPremjestanje", b =>
                {
                    b.HasBaseType("StudentskiDom.Models.ZahtjevStudenta");

                    b.Property<int>("Paviljon1Id")
                        .HasColumnType("int");

                    b.Property<int>("Paviljon2Id")
                        .HasColumnType("int");

                    b.Property<string>("RazlogPremjestanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Soba1Id")
                        .HasColumnType("int");

                    b.Property<int>("Soba2Id")
                        .HasColumnType("int");

                    b.HasIndex("Paviljon1Id");

                    b.HasIndex("Paviljon2Id");

                    b.HasIndex("Soba1Id");

                    b.HasIndex("Soba2Id");

                    b.HasDiscriminator().HasValue("ZahtjevZaPremjestanje");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.Blagajna", b =>
                {
                    b.HasOne("StudentskiDom.Models.Uprava", "Uprava")
                        .WithOne("Blagajna")
                        .HasForeignKey("StudentskiDom.Models.Blagajna", "UpravaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.Korisnik", b =>
                {
                    b.HasOne("StudentskiDom.Models.Restoran", "Restoran")
                        .WithMany()
                        .HasForeignKey("RestoranId");

                    b.HasOne("StudentskiDom.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("StudentskiDom.Models.Mjesec", b =>
                {
                    b.HasOne("StudentskiDom.Models.Student", "Student")
                        .WithMany("Mjesec")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.Rucak", b =>
                {
                    b.HasOne("StudentskiDom.Models.DnevniMeni", "DnevniMeni")
                        .WithMany("Rucak")
                        .HasForeignKey("DnevniMeniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.Soba", b =>
                {
                    b.HasOne("StudentskiDom.Models.Paviljon", "Paviljon")
                        .WithMany("Sobe")
                        .HasForeignKey("PaviljonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.StavkaNarudzbe", b =>
                {
                    b.HasOne("StudentskiDom.Models.ZahtjevZaNabavkuNamirnica", "ZahtjevZaNabavkuNamirnica")
                        .WithMany("StavkeNadruzbe")
                        .HasForeignKey("ZahtjevZaNabavkuNamirnicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.Vecera", b =>
                {
                    b.HasOne("StudentskiDom.Models.DnevniMeni", "DnevniMeni")
                        .WithMany("Vecera")
                        .HasForeignKey("DnevniMeniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.Zahtjev", b =>
                {
                    b.HasOne("StudentskiDom.Models.ZahtjevRestorana", "ZahtjevRestorana")
                        .WithMany()
                        .HasForeignKey("ZahtjevRestoranaZahtjevId");

                    b.HasOne("StudentskiDom.Models.ZahtjevStudenta", "ZahtjevStudenta")
                        .WithMany()
                        .HasForeignKey("ZahtjevStudentaZahtjevId");

                    b.HasOne("StudentskiDom.Models.ZahtjevZaUpis", "ZahtjevZaUpis")
                        .WithMany()
                        .HasForeignKey("ZahtjevZaUpisZahtjevId");
                });

            modelBuilder.Entity("StudentskiDom.Models.Restoran", b =>
                {
                    b.HasOne("StudentskiDom.Models.DnevniMeni", "DnevniMeni")
                        .WithOne("Restoran")
                        .HasForeignKey("StudentskiDom.Models.Restoran", "DnevniMeniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.Student", b =>
                {
                    b.HasOne("StudentskiDom.Models.LicniPodaci", "LicniPodaci")
                        .WithOne("Student")
                        .HasForeignKey("StudentskiDom.Models.Student", "LicniPodaciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.PrebivalisteInfo", "PrebivalisteInfo")
                        .WithOne("Student")
                        .HasForeignKey("StudentskiDom.Models.Student", "PrebivalisteInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.SkolovanjeInfo", "SkolovanjeInfo")
                        .WithOne("Student")
                        .HasForeignKey("StudentskiDom.Models.Student", "SkolovanjeInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.Soba", "Soba")
                        .WithMany("Students")
                        .HasForeignKey("SobaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.Uprava", b =>
                {
                    b.HasOne("StudentskiDom.Models.Korisnik", null)
                        .WithOne("Uprava")
                        .HasForeignKey("StudentskiDom.Models.Uprava", "KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.ZahtjevRestorana", b =>
                {
                    b.HasOne("StudentskiDom.Models.Restoran", "Restoran")
                        .WithOne("ZahtjevRestorana")
                        .HasForeignKey("StudentskiDom.Models.ZahtjevRestorana", "RestoranId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.ZahtjevStudenta", b =>
                {
                    b.HasOne("StudentskiDom.Models.Student", "Student")
                        .WithOne("ZahtjevStudenta")
                        .HasForeignKey("StudentskiDom.Models.ZahtjevStudenta", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.ZahtjevZaUpis", b =>
                {
                    b.HasOne("StudentskiDom.Models.LicniPodaci", "LicniPodaci")
                        .WithOne("ZahtjevZaUpis")
                        .HasForeignKey("StudentskiDom.Models.ZahtjevZaUpis", "LicniPodaciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.PrebivalisteInfo", "PrebivalisteInfo")
                        .WithOne("ZahtjevZaUpis")
                        .HasForeignKey("StudentskiDom.Models.ZahtjevZaUpis", "PrebivalisteInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.SkolovanjeInfo", "SkolovanjeInfo")
                        .WithOne("ZahtjevZaUpis")
                        .HasForeignKey("StudentskiDom.Models.ZahtjevZaUpis", "SkolovanjeInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.ZahtjevZaCimeraj", b =>
                {
                    b.HasOne("StudentskiDom.Models.Student", "Cimer1")
                        .WithMany("ZahtjevZaCimeraj1")
                        .HasForeignKey("Cimer1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.Student", "Cimer2")
                        .WithMany("ZahtjevZaCimeraj2")
                        .HasForeignKey("Cimer2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.Paviljon", "Paviljon")
                        .WithOne("ZahtjevZaCimeraj")
                        .HasForeignKey("StudentskiDom.Models.ZahtjevZaCimeraj", "PaviljonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.Soba", "Soba")
                        .WithOne("ZahtjevZaCimeraj")
                        .HasForeignKey("StudentskiDom.Models.ZahtjevZaCimeraj", "SobaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.ZahtjevZaPremjestanje", b =>
                {
                    b.HasOne("StudentskiDom.Models.Paviljon", "Paviljon1")
                        .WithMany("ZahtjevZaPremjestanje1")
                        .HasForeignKey("Paviljon1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.Paviljon", "Paviljon2")
                        .WithMany("ZahtjevZaPremjestanje2")
                        .HasForeignKey("Paviljon2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.Soba", "Soba1")
                        .WithMany("Soba1")
                        .HasForeignKey("Soba1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.Soba", "Soba2")
                        .WithMany("Soba2")
                        .HasForeignKey("Soba2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
