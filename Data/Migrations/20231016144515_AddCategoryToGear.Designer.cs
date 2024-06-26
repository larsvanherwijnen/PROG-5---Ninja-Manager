﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(NinjaContext))]
    [Migration("20231016144515_AddCategoryToGear")]
    partial class AddCategoryToGear
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Models.Gear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Agility")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Gear");
                });

            modelBuilder.Entity("Data.Models.Ninja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Gold")
                        .HasMaxLength(5)
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.ToTable("Ninjas");
                });

            modelBuilder.Entity("Data.Models.NinjaGear", b =>
                {
                    b.Property<int>("NinjaId")
                        .HasColumnType("int");

                    b.Property<int>("GearId")
                        .HasColumnType("int");

                    b.HasKey("NinjaId", "GearId");

                    b.HasIndex("GearId");

                    b.ToTable("NinjaGear");
                });

            modelBuilder.Entity("Data.Models.NinjaGear", b =>
                {
                    b.HasOne("Data.Models.Gear", "Gear")
                        .WithMany("Ninja")
                        .HasForeignKey("GearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.Ninja", "Ninja")
                        .WithMany("Gear")
                        .HasForeignKey("NinjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gear");

                    b.Navigation("Ninja");
                });

            modelBuilder.Entity("Data.Models.Gear", b =>
                {
                    b.Navigation("Ninja");
                });

            modelBuilder.Entity("Data.Models.Ninja", b =>
                {
                    b.Navigation("Gear");
                });
#pragma warning restore 612, 618
        }
    }
}
