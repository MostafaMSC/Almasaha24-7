﻿// <auto-generated />
using System;
using KSHIFSYSTEM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KSHIFSYSTEM.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KSHIFSYSTEM.Models.BookInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AddadAlkhobraa")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AlwasilDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("AlwasilNo")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("AstmaraDateM")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AstmaraDateP")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("AstmaraNoM")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("AstmaraNoP")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("BookDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("BookNo")
                        .HasColumnType("int");

                    b.Property<string>("BookPic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("HayaBookDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("HayaBookNo")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("JahaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KashefType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KshefDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MokataNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookTable");
                });

            modelBuilder.Entity("KSHIFSYSTEM.Models.DaawaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AkherALajraaat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AstanafNO")
                        .HasColumnType("int");

                    b.Property<string>("Court")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DawaNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DawaSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DawaType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Decision1ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Decision1Num")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectDawa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TameezNO")
                        .HasColumnType("int");

                    b.Property<int>("TashehNO")
                        .HasColumnType("int");

                    b.Property<int>("qraraadaNO")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DawwaTable");
                });

            modelBuilder.Entity("KSHIFSYSTEM.Models.KhobraaMahakemModule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KshofatNo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("khobraaMahakemTable");
                });

            modelBuilder.Entity("KSHIFSYSTEM.Models.KshfInfoModule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KshifType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KshofatNo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialBlock")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalKSofat")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("SpecialestTable");
                });

            modelBuilder.Entity("KSHIFSYSTEM.Models.TarshehBook", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("AddadAlkhobraa")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AlwasilDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("AlwasilNo")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BookDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BookNo")
                        .HasColumnType("int");

                    b.Property<DateTime?>("HayaBookDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HayaBookNo")
                        .HasColumnType("int");

                    b.Property<string>("JehaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KshefDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KshifResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KshifResultPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KshifType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MokataNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialName9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecaialTitle9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("WasilDateM")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("WasilDateP")
                        .HasColumnType("datetime2");

                    b.Property<int?>("WasilNoM")
                        .HasColumnType("int");

                    b.Property<int?>("WasilNoP")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TarshehBookTable");
                });

            modelBuilder.Entity("KSHIFSYSTEM.Models.TotalKsofatModule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KshodatNOAqaraat")
                        .HasColumnType("int");

                    b.Property<int>("KshofatNoMahakem")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalKshofat")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("TotalKshofatTable");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "owner",
                            ConcurrencyStamp = "45d1e7d5-c6e0-4a76-a37d-8650438ab527",
                            Name = "owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = "admin",
                            ConcurrencyStamp = "95465e4c-62bb-449c-a0b1-451f4295b434",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "DawaView",
                            ConcurrencyStamp = "ac1c37d0-6ec1-4e17-ab52-29936aaf3e32",
                            Name = "DawaView",
                            NormalizedName = "DAWAVIEW"
                        },
                        new
                        {
                            Id = "eatalaJazaea",
                            ConcurrencyStamp = "be792708-9fe0-4322-aa95-4a4e93f0d774",
                            Name = "eatalaJazaea",
                            NormalizedName = "EATALAJAZAEA"
                        },
                        new
                        {
                            Id = "admin2",
                            ConcurrencyStamp = "f27e6b7f-3694-4396-b72b-6ea18024650f",
                            Name = "admin2",
                            NormalizedName = "ADMIN2"
                        },
                        new
                        {
                            Id = "SuperAdmin",
                            ConcurrencyStamp = "d651692e-6537-472d-b038-e17161c82ca4",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "regulator",
                            ConcurrencyStamp = "fc0dbf39-3331-4ef6-b108-e91bbc58ec55",
                            Name = "regulator",
                            NormalizedName = "REGULATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "admin",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5eb0803f-a669-4563-8495-9d4c0b5c661a",
                            Email = "admin2",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin2",
                            NormalizedUserName = "ADMIN2",
                            PasswordHash = "000000",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "df787eca-d42a-43af-8d16-49334943349b",
                            TwoFactorEnabled = false,
                            UserName = "admin2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "admin",
                            RoleId = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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
#pragma warning restore 612, 618
        }
    }
}
