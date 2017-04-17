using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SS_Case.Models;

namespace SSCase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170417064740_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SS_Case.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryID");

                    b.Property<string>("Name");

                    b.HasKey("ClientID");

                    b.HasIndex("CountryID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("SS_Case.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("SS_Case.Models.Client", b =>
                {
                    b.HasOne("SS_Case.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID");
                });
        }
    }
}
