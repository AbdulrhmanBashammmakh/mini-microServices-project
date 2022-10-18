﻿// <auto-generated />
using Micro.PurchaseApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Micro.PurchaseApi.Migrations
{
    [DbContext(typeof(PurchaseDbContext))]
    [Migration("20221015213731_startaa")]
    partial class startaa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Micro.PurchaseApi.Models.AccDebitVendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccNum")
                        .HasColumnType("int");

                    b.Property<double>("CerditAmount")
                        .HasColumnType("float");

                    b.Property<double>("DebitAmount")
                        .HasColumnType("float");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("AccDebitVendors");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Gnb")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.Property<int>("cashOrDebitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.HasIndex("cashOrDebitId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.BillItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("Gnb")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("BillItems");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.CashOrDebit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CashOrDebits");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.DebitBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<int>("FinancialAccountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FinancialAccountId");

                    b.ToTable("DebitBills");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.PaymentsMade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("PaymentToAccountId")
                        .HasColumnType("int");

                    b.Property<string>("ReceiptReferance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("PaymentsMades");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.AccDebitVendor", b =>
                {
                    b.HasOne("Micro.PurchaseApi.Models.Vendor", "Vendor")
                        .WithMany("AccDebitVendors")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.Bill", b =>
                {
                    b.HasOne("Micro.PurchaseApi.Models.Vendor", "Vendor")
                        .WithMany("Bills")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Micro.PurchaseApi.Models.CashOrDebit", "cashOrDebit")
                        .WithMany("Bills")
                        .HasForeignKey("cashOrDebitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cashOrDebit");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.DebitBill", b =>
                {
                    b.HasOne("Micro.PurchaseApi.Models.AccDebitVendor", "FinancialAccount")
                        .WithMany("DebitBills")
                        .HasForeignKey("FinancialAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FinancialAccount");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.PaymentsMade", b =>
                {
                    b.HasOne("Micro.PurchaseApi.Models.Vendor", "Vendor")
                        .WithMany("PaymentsMades")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.AccDebitVendor", b =>
                {
                    b.Navigation("DebitBills");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.CashOrDebit", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Micro.PurchaseApi.Models.Vendor", b =>
                {
                    b.Navigation("AccDebitVendors");

                    b.Navigation("Bills");

                    b.Navigation("PaymentsMades");
                });
#pragma warning restore 612, 618
        }
    }
}