﻿// <auto-generated />
using System;
using EFCore5NetCore3;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore5NetCore3.Migrations.BidirectionalAssociations
{
    [DbContext(typeof(BidirectionalAssociationTestContext))]
    partial class BidirectionalAssociationTestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("Detail3Master", b =>
                {
                    b.Property<long>("CId")
                        .HasColumnType("bigint");

                    b.Property<long>("ToManyDetail3Id")
                        .HasColumnType("bigint");

                    b.HasKey("CId", "ToManyDetail3Id");

                    b.HasIndex("ToManyDetail3Id");

                    b.ToTable("ToManyDetail3_x_ToManyDetail3");
                });

            modelBuilder.Entity("EFCore5NetCore3.Detail1", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("A_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("B_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("C_Id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("A_Id")
                        .IsUnique();

                    b.HasIndex("B_Id")
                        .IsUnique();

                    b.HasIndex("C_Id");

                    b.ToTable("Detail1");
                });

            modelBuilder.Entity("EFCore5NetCore3.Detail2", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("B_Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("C_Id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("B_Id")
                        .IsUnique()
                        .HasFilter("[B_Id] IS NOT NULL");

                    b.HasIndex("C_Id");

                    b.ToTable("Detail2");
                });

            modelBuilder.Entity("EFCore5NetCore3.Detail3", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.HasKey("Id");

                    b.ToTable("Detail3");
                });

            modelBuilder.Entity("EFCore5NetCore3.Master", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("ToOneDetail2_Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("ToOneDetail3_Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("ToZeroOrOneDetail3_Id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ToOneDetail2_Id")
                        .IsUnique()
                        .HasFilter("[ToOneDetail2_Id] IS NOT NULL");

                    b.HasIndex("ToOneDetail3_Id");

                    b.HasIndex("ToZeroOrOneDetail3_Id");

                    b.ToTable("Masters");
                });

            modelBuilder.Entity("Detail3Master", b =>
                {
                    b.HasOne("EFCore5NetCore3.Master", null)
                        .WithMany()
                        .HasForeignKey("CId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore5NetCore3.Detail3", null)
                        .WithMany()
                        .HasForeignKey("ToManyDetail3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore5NetCore3.Detail1", b =>
                {
                    b.HasOne("EFCore5NetCore3.Master", "A")
                        .WithOne("ToOneDetail1")
                        .HasForeignKey("EFCore5NetCore3.Detail1", "A_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore5NetCore3.Master", "B")
                        .WithOne("ToZeroOrOneDetail1")
                        .HasForeignKey("EFCore5NetCore3.Detail1", "B_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore5NetCore3.Master", "C")
                        .WithMany("ToManyDetail1")
                        .HasForeignKey("C_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("A");

                    b.Navigation("B");

                    b.Navigation("C");
                });

            modelBuilder.Entity("EFCore5NetCore3.Detail2", b =>
                {
                    b.HasOne("EFCore5NetCore3.Master", "B")
                        .WithOne("ToZeroOrOneDetail2")
                        .HasForeignKey("EFCore5NetCore3.Detail2", "B_Id");

                    b.HasOne("EFCore5NetCore3.Master", "C")
                        .WithMany("ToManyDetail2")
                        .HasForeignKey("C_Id");

                    b.Navigation("B");

                    b.Navigation("C");
                });

            modelBuilder.Entity("EFCore5NetCore3.Master", b =>
                {
                    b.HasOne("EFCore5NetCore3.Detail2", "ToOneDetail2")
                        .WithOne("A")
                        .HasForeignKey("EFCore5NetCore3.Master", "ToOneDetail2_Id");

                    b.HasOne("EFCore5NetCore3.Detail3", "ToOneDetail3")
                        .WithMany("A")
                        .HasForeignKey("ToOneDetail3_Id");

                    b.HasOne("EFCore5NetCore3.Detail3", "ToZeroOrOneDetail3")
                        .WithMany("B")
                        .HasForeignKey("ToZeroOrOneDetail3_Id");

                    b.Navigation("ToOneDetail2");

                    b.Navigation("ToOneDetail3");

                    b.Navigation("ToZeroOrOneDetail3");
                });

            modelBuilder.Entity("EFCore5NetCore3.Detail2", b =>
                {
                    b.Navigation("A");
                });

            modelBuilder.Entity("EFCore5NetCore3.Detail3", b =>
                {
                    b.Navigation("A");

                    b.Navigation("B");
                });

            modelBuilder.Entity("EFCore5NetCore3.Master", b =>
                {
                    b.Navigation("ToManyDetail1");

                    b.Navigation("ToManyDetail2");

                    b.Navigation("ToOneDetail1")
                        .IsRequired();

                    b.Navigation("ToZeroOrOneDetail1");

                    b.Navigation("ToZeroOrOneDetail2");
                });
#pragma warning restore 612, 618
        }
    }
}
