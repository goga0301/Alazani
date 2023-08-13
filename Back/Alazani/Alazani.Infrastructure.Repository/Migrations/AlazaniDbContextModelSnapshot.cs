﻿// <auto-generated />
using System;
using Alazani.Infrastructure.Repository.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Alazani.Infrastructure.Repository.Migrations
{
    [DbContext(typeof(AlazaniDbContext))]
    partial class AlazaniDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("AlazaniDb")
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 30);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Alazani.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreateDate");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("CreateUserId");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<byte>("RecordStatus")
                        .HasColumnType("smallint")
                        .HasColumnName("RecordStatus");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("RecordStatus");

                    b.ToTable("Category", "AlazaniDb");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreateDate");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("CreateUserId");

                    b.Property<byte>("RecordStatus")
                        .HasColumnType("smallint")
                        .HasColumnName("RecordStatus");

                    b.HasKey("Id");

                    b.HasIndex("RecordStatus");

                    b.ToTable("Currency", "AlazaniDb");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreateDate");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("CreateUserId");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasAnnotation("RegularExpression", "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,4}$")
                        .HasAnnotation("RegularExpressionErrorMessage", "Invalid email address format.");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte>("RecordStatus")
                        .HasColumnType("smallint")
                        .HasColumnName("RecordStatus");

                    b.HasKey("Id");

                    b.HasIndex("RecordStatus");

                    b.ToTable("Customer", "AlazaniDb");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreateDate");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("CreateUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte>("RecordStatus")
                        .HasColumnType("smallint")
                        .HasColumnName("RecordStatus");

                    b.HasKey("Id");

                    b.HasIndex("RecordStatus");

                    b.ToTable("Organization", "AlazaniDb");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreateDate");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("CreateUserId");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<byte>("RecordStatus")
                        .HasColumnType("smallint")
                        .HasColumnName("RecordStatus");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("ProductId");

                    b.HasIndex("RecordStatus");

                    b.ToTable("Price", "AlazaniDb");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreateDate");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("CreateUserId");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<byte>("RecordStatus")
                        .HasColumnType("smallint")
                        .HasColumnName("RecordStatus");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("RecordStatus");

                    b.ToTable("Product", "AlazaniDb");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<byte>("RecordStatus")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Role", "AlazaniDb");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreateDate");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("CreateUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("varchar")
                        .HasColumnName("Name");

                    b.Property<byte>("RecordStatus")
                        .HasColumnType("smallint")
                        .HasColumnName("RecordStatus");

                    b.HasKey("Id");

                    b.HasIndex("RecordStatus");

                    b.ToTable("Test", "AlazaniDb");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreateDate");

                    b.Property<string>("CreateUserId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("CreateUserId");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<byte>("RecordStatus")
                        .HasColumnType("smallint")
                        .HasColumnName("RecordStatus");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("RecordStatus");

                    b.HasIndex("RoleId");

                    b.ToTable("User", "AlazaniDb");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Category", b =>
                {
                    b.HasOne("Alazani.Domain.Entities.Organization", null)
                        .WithMany("Categories")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Org_Categories");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Price", b =>
                {
                    b.HasOne("Alazani.Domain.Entities.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Currency_Prices");

                    b.HasOne("Alazani.Domain.Entities.Product", null)
                        .WithMany("Prices")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Product_Prices");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Product", b =>
                {
                    b.HasOne("Alazani.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Category_Products");

                    b.HasOne("Alazani.Domain.Entities.Organization", null)
                        .WithMany("Products")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Org_Products");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Role", b =>
                {
                    b.HasOne("Alazani.Domain.Entities.Organization", null)
                        .WithMany("Roles")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Org_Roles");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.User", b =>
                {
                    b.HasOne("Alazani.Domain.Entities.Organization", null)
                        .WithMany("Users")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Org_Users");

                    b.HasOne("Alazani.Domain.Entities.Role", null)
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Role_Users");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Organization", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Products");

                    b.Navigation("Roles");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Product", b =>
                {
                    b.Navigation("Prices");
                });

            modelBuilder.Entity("Alazani.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
