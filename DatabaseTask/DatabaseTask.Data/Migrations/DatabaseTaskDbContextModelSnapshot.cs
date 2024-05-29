﻿// <auto-generated />
using System;
using DatabaseTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    [DbContext(typeof(DatabaseTaskDbContext))]
    partial class DatabaseTaskDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DatabaseTask.Core.Domain.AccessPermission", b =>
                {
                    b.Property<int>("AccessPermissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccessPermissionID"), 1L, 1);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Permissions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccessPermissionID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("AccessPermissions");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Branch", b =>
                {
                    b.Property<int>("BranchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("ContactAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfEmployees")
                        .HasColumnType("int");

                    b.Property<string>("RegistryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Child", b =>
                {
                    b.Property<int>("ChildID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChildID"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChildID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyID"), 1L, 1);

                    b.Property<string>("ContactAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfEmployees")
                        .HasColumnType("int");

                    b.Property<string>("RegistryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee2", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.Property<string>("ContactAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("BranchID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.HealthExamination", b =>
                {
                    b.Property<int>("HealthExaminationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HealthExaminationID"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HealthExaminationID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("HealthExaminations");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Job", b =>
                {
                    b.Property<int>("JobID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.LendableItem", b =>
                {
                    b.Property<int>("LendableItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LendableItemID"), 1L, 1);

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("Things")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LendableItemID");

                    b.HasIndex("CompanyID");

                    b.ToTable("LendableItems");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Loan", b =>
                {
                    b.Property<int>("LoanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanID"), 1L, 1);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HowMany")
                        .HasColumnType("int");

                    b.Property<int>("LendableItemID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoanID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("LendableItemID");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Request", b =>
                {
                    b.Property<int>("RequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestID"), 1L, 1);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.SickDays", b =>
                {
                    b.Property<int>("SickDaysID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SickDaysID"), 1L, 1);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("SickDaysID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("SickDays");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Vacation", b =>
                {
                    b.Property<int>("VacationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VacationID"), 1L, 1);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VacationID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.AccessPermission", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee2", "Employee")
                        .WithMany("AccessPermissions")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Branch", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Company", "Company")
                        .WithMany("Branches")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Child", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee2", "Employee")
                        .WithMany("Children")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee2", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Branch", "Branch")
                        .WithMany("Employees")
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.HealthExamination", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee2", "Employee")
                        .WithMany("HealthExaminations")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Job", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee2", "Employee")
                        .WithMany("Jobs")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.LendableItem", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Company", "Company")
                        .WithMany("LendableItems")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Loan", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee2", "Employee")
                        .WithMany("Loans")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Core.Domain.LendableItem", "LendableItem")
                        .WithMany("Loans")
                        .HasForeignKey("LendableItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("LendableItem");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Request", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee2", "Employee")
                        .WithMany("Requests")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.SickDays", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee2", "Employee")
                        .WithMany("SickDays")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Vacation", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee2", "Employee")
                        .WithMany("Vacations")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Branch", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Company", b =>
                {
                    b.Navigation("Branches");

                    b.Navigation("LendableItems");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee2", b =>
                {
                    b.Navigation("AccessPermissions");

                    b.Navigation("Children");

                    b.Navigation("HealthExaminations");

                    b.Navigation("Jobs");

                    b.Navigation("Loans");

                    b.Navigation("Requests");

                    b.Navigation("SickDays");

                    b.Navigation("Vacations");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.LendableItem", b =>
                {
                    b.Navigation("Loans");
                });
#pragma warning restore 612, 618
        }
    }
}
