﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using amortization_schedule_calculator.Data;

#nullable disable

namespace amortization_schedule_calculator.Migrations
{
    [DbContext(typeof(AmortizationContext))]
    [Migration("20230403221301_IntialCreate")]
    partial class IntialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("amortization_schedule_calculator.Models.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("amortization_schedule_calculator.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("loanID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("loanID");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("amortization_schedule_calculator.Models.Payment", b =>
                {
                    b.HasOne("amortization_schedule_calculator.Models.Loan", "loan")
                        .WithMany("Payments")
                        .HasForeignKey("loanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("loan");
                });

            modelBuilder.Entity("amortization_schedule_calculator.Models.Loan", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
