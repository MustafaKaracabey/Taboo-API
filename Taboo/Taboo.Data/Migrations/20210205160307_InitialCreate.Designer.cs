﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Taboo.Data;

namespace Taboo.Data.Migrations
{
    [DbContext(typeof(EfDataContext))]
    [Migration("20210205160307_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Taboo.Core.Models.Tabu", b =>
                {
                    b.Property<int>("TabuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TabuName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WordId")
                        .HasColumnType("int");

                    b.HasKey("TabuId");

                    b.HasIndex("WordId");

                    b.ToTable("Tabus");
                });

            modelBuilder.Entity("Taboo.Core.Models.Word", b =>
                {
                    b.Property<int>("WordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("DifficultyLevel")
                        .HasColumnType("bit");

                    b.Property<string>("WordName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WordId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("Taboo.Core.Models.Tabu", b =>
                {
                    b.HasOne("Taboo.Core.Models.Word", "Word")
                        .WithMany("Tabus")
                        .HasForeignKey("WordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Word");
                });

            modelBuilder.Entity("Taboo.Core.Models.Word", b =>
                {
                    b.Navigation("Tabus");
                });
#pragma warning restore 612, 618
        }
    }
}
