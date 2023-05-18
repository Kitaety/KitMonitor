﻿// <auto-generated />
using System;
using KitMonitor.Server.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KitMonitor.Server.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230518101042_ChangeCompanyTable")]
    partial class ChangeCompanyTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KitMonitor.Server.Models.Database.Entities.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("KitMonitor.Server.Models.Database.Entities.Indicator", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("IdMonitorSystem")
                        .HasColumnType("bigint");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMonitorSystem");

                    b.ToTable("Indicators");
                });

            modelBuilder.Entity("KitMonitor.Server.Models.Database.Entities.IndicatorLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("IndicatorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(15,4)");

                    b.HasKey("Id");

                    b.HasIndex("IndicatorId");

                    b.ToTable("IndicatorLogs");
                });

            modelBuilder.Entity("KitMonitor.Server.Models.Database.Entities.MonitorSystem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("MonitorSystems");
                });

            modelBuilder.Entity("KitMonitor.Server.Models.Database.Entities.Indicator", b =>
                {
                    b.HasOne("KitMonitor.Server.Models.Database.Entities.MonitorSystem", "MonitorSystem")
                        .WithMany()
                        .HasForeignKey("IdMonitorSystem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MonitorSystem");
                });

            modelBuilder.Entity("KitMonitor.Server.Models.Database.Entities.IndicatorLog", b =>
                {
                    b.HasOne("KitMonitor.Server.Models.Database.Entities.Indicator", "Indicator")
                        .WithMany("Log")
                        .HasForeignKey("IndicatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Indicator");
                });

            modelBuilder.Entity("KitMonitor.Server.Models.Database.Entities.MonitorSystem", b =>
                {
                    b.HasOne("KitMonitor.Server.Models.Database.Entities.Company", "Company")
                        .WithMany("MonitorSystems")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("KitMonitor.Server.Models.Database.Entities.Company", b =>
                {
                    b.Navigation("MonitorSystems");
                });

            modelBuilder.Entity("KitMonitor.Server.Models.Database.Entities.Indicator", b =>
                {
                    b.Navigation("Log");
                });
#pragma warning restore 612, 618
        }
    }
}
