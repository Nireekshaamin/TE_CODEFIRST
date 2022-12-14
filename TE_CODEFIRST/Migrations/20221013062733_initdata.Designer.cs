// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TE_CODEFIRST.Data;

#nullable disable

namespace TE_CODEFIRST.Migrations
{
    [DbContext(typeof(TE_CODEFIRSTContext))]
    [Migration("20221013062733_initdata")]
    partial class initdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TE_CODEFIRST.Models.Trainee", b =>
                {
                    b.Property<int>("Tid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Tid"), 1L, 1);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("TAge")
                        .HasColumnType("int");

                    b.Property<string>("Tname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Tid");

                    b.ToTable("Trainee");
                });
#pragma warning restore 612, 618
        }
    }
}
