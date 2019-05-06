﻿// <auto-generated />
using System;
using FLoan.System.Web.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FLoan.System.Web.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190506125646_LeftToPay")]
    partial class LeftToPay
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FLoan.System.Web.API.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DateTimeCreated");

                    b.Property<string>("Postcode");

                    b.Property<string>("Street");

                    b.Property<string>("Town");

                    b.HasKey("AddressId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("FLoan.System.Web.API.Models.Agreement", b =>
                {
                    b.Property<int>("AgreementId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AdminFeePayable");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DateTimeCreated");

                    b.Property<decimal>("InterestPayable");

                    b.Property<bool>("IsLoanActivated");

                    b.Property<decimal>("LeftToPay");

                    b.Property<decimal>("LoanAdvance");

                    b.Property<decimal>("LoanAmount");

                    b.Property<decimal>("LoanBalance");

                    b.Property<DateTime>("LoanStartDate");

                    b.Property<int>("LoanTerm");

                    b.Property<decimal>("MonthlyRepayment");

                    b.Property<DateTime>("NextPaymentDate");

                    b.Property<int>("PinNumber");

                    b.Property<int>("Status");

                    b.Property<decimal>("TotalRepayable");

                    b.HasKey("AgreementId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Agreements");
                });

            modelBuilder.Entity("FLoan.System.Web.API.Models.Bank", b =>
                {
                    b.Property<int>("BankId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountHolderName");

                    b.Property<string>("AccountNumber");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DateTimeCreated");

                    b.Property<string>("Sortcode");

                    b.HasKey("BankId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("FLoan.System.Web.API.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("DateTimeCreated");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Mobile");

                    b.Property<string>("Telephone");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FLoan.System.Web.API.Models.Income", b =>
                {
                    b.Property<int>("IncomeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CreditBills");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DateTimeCreated");

                    b.Property<bool>("GiveMeLoan");

                    b.Property<decimal>("HouseholdExpense");

                    b.Property<decimal>("MonthlyMortgageOrRent");

                    b.Property<decimal>("MonthlySalary");

                    b.Property<decimal>("OtherIncome");

                    b.HasKey("IncomeId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("FLoan.System.Web.API.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgreementId");

                    b.Property<decimal>("AmountPaid");

                    b.Property<decimal>("CurrentBalance");

                    b.Property<DateTime>("DateTimeCreated");

                    b.HasKey("TransactionId");

                    b.HasIndex("AgreementId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("FLoan.System.Web.API.Models.Address", b =>
                {
                    b.HasOne("FLoan.System.Web.API.Models.Customer", "Customer")
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FLoan.System.Web.API.Models.Agreement", b =>
                {
                    b.HasOne("FLoan.System.Web.API.Models.Customer", "Customer")
                        .WithMany("Agreements")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FLoan.System.Web.API.Models.Bank", b =>
                {
                    b.HasOne("FLoan.System.Web.API.Models.Customer", "Customer")
                        .WithMany("Banks")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FLoan.System.Web.API.Models.Income", b =>
                {
                    b.HasOne("FLoan.System.Web.API.Models.Customer", "Customer")
                        .WithMany("Incomes")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FLoan.System.Web.API.Models.Transaction", b =>
                {
                    b.HasOne("FLoan.System.Web.API.Models.Agreement", "Agreement")
                        .WithMany("Transactions")
                        .HasForeignKey("AgreementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
