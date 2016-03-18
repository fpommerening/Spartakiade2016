using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using FP.Spartakiade2016.ProcessChain.Data;

namespace Data.Migrations
{
    [DbContext(typeof(CustomerContext))]
    partial class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("FP.Spartakiade2016.ProcessChain.Data.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country");

                    b.Property<string>("Number")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("FP.Spartakiade2016.ProcessChain.Data.Models.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AddessId");

                    b.Property<Guid?>("AddressId")
                        .IsRequired();

                    b.Property<Guid>("Customerid");

                    b.Property<DateTime>("DocumentDate");

                    b.Property<string>("Number")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("FP.Spartakiade2016.ProcessChain.Data.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("BillingAddressId");

                    b.Property<DateTime>("Birthday");

                    b.Property<Guid>("DeliveryAddressId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Number")
                        .IsRequired();

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("FP.Spartakiade2016.ProcessChain.Data.Models.Position", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article")
                        .IsRequired();

                    b.Property<Guid>("BillId");

                    b.Property<string>("Comment");

                    b.Property<decimal>("GrossAmmount");

                    b.Property<decimal>("NetAmount");

                    b.Property<int>("Number");

                    b.Property<decimal>("TaxAmmount");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("FP.Spartakiade2016.ProcessChain.Data.Models.Reversal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DocumentDate");

                    b.Property<string>("Number")
                        .IsRequired();

                    b.Property<Guid>("ReferenceBillId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("FP.Spartakiade2016.ProcessChain.Data.Models.Bill", b =>
                {
                    b.HasOne("FP.Spartakiade2016.ProcessChain.Data.Models.Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("FP.Spartakiade2016.ProcessChain.Data.Models.Customer")
                        .WithMany()
                        .HasForeignKey("Customerid");
                });

            modelBuilder.Entity("FP.Spartakiade2016.ProcessChain.Data.Models.Customer", b =>
                {
                    b.HasOne("FP.Spartakiade2016.ProcessChain.Data.Models.Address")
                        .WithMany()
                        .HasForeignKey("BillingAddressId");

                    b.HasOne("FP.Spartakiade2016.ProcessChain.Data.Models.Address")
                        .WithMany()
                        .HasForeignKey("DeliveryAddressId");
                });

            modelBuilder.Entity("FP.Spartakiade2016.ProcessChain.Data.Models.Position", b =>
                {
                    b.HasOne("FP.Spartakiade2016.ProcessChain.Data.Models.Bill")
                        .WithMany()
                        .HasForeignKey("BillId");
                });

            modelBuilder.Entity("FP.Spartakiade2016.ProcessChain.Data.Models.Reversal", b =>
                {
                    b.HasOne("FP.Spartakiade2016.ProcessChain.Data.Models.Bill")
                        .WithMany()
                        .HasForeignKey("ReferenceBillId");
                });
        }
    }
}
