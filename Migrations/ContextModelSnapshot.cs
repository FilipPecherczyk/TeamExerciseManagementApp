﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamExerciseManagementApp.Models.UserEntities;

#nullable disable

namespace TeamExerciseManagementApp.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TeamExerciseManagementApp.Models.UserEntities.PlayerResults", b =>
                {
                    b.Property<int>("Results_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Results_ID"));

                    b.Property<int>("BenchPress")
                        .HasColumnType("int");

                    b.Property<int>("Deadlift")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Jump")
                        .HasColumnType("int");

                    b.Property<int>("Run60")
                        .HasColumnType("int");

                    b.Property<int>("Squats")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Results_ID");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("TeamExerciseManagementApp.Models.UserEntities.User", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_ID"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Results_ID1")
                        .HasColumnType("int");

                    b.Property<int>("UserCategory")
                        .HasColumnType("int");

                    b.HasKey("User_ID");

                    b.HasIndex("Results_ID1");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TeamExerciseManagementApp.Models.UserEntities.User", b =>
                {
                    b.HasOne("TeamExerciseManagementApp.Models.UserEntities.PlayerResults", "Results_ID")
                        .WithMany()
                        .HasForeignKey("Results_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Results_ID");
                });
#pragma warning restore 612, 618
        }
    }
}
