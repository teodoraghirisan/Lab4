﻿// <auto-generated />

using System;
using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lab4.Migrations
{
    [DbContext(typeof(ExpensesDbContext))]
    partial class ExpensesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labo2.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddedById");

                    b.Property<int?>("ExpenseId");

                    b.Property<bool>("Important");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("AddedById");

                    b.HasIndex("ExpenseId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Labo2.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddedById");

                    b.Property<string>("Currency");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<double>("Sum");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("AddedById");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("Labo2.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Labo2.Models.Comment", b =>
                {
                    b.HasOne("Labo2.Models.User", "AddedBy")
                        .WithMany()
                        .HasForeignKey("AddedById");

                    b.HasOne("Labo2.Models.Expense", "Expense")
                        .WithMany("Comments")
                        .HasForeignKey("ExpenseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Labo2.Models.Expense", b =>
                {
                    b.HasOne("Labo2.Models.User", "AddedBy")
                        .WithMany()
                        .HasForeignKey("AddedById");
                });
#pragma warning restore 612, 618
        }
    }
}
