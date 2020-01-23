﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Testing;

namespace EFCore2NetFramework.Migrations
{
    [DbContext(typeof(AllFeatureModel))]
    [Migration("20200115122131_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Testing.AllPropertyTypesOptional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id1");

                    b.Property<byte[]>("BinaryAttr");

                    b.Property<bool?>("BooleanAttr");

                    b.Property<byte?>("ByteAttr");

                    b.Property<DateTime?>("DateTimeAttr");

                    b.Property<DateTimeOffset?>("DateTimeOffsetAttr");

                    b.Property<decimal?>("DecimalAttr");

                    b.Property<double?>("DoubleAttr");

                    b.Property<Guid?>("GuidAttr");

                    b.Property<short?>("Int16Attr");

                    b.Property<int?>("Int32Attr");

                    b.Property<long?>("Int64Attr");

                    b.Property<float?>("SingleAttr");

                    b.Property<string>("StringAttr");

                    b.Property<TimeSpan?>("TimeAttr");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id", "Id1");

                    b.ToTable("AllPropertyTypesOptionals");
                });

            modelBuilder.Entity("Testing.AllPropertyTypesRequired", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("BinaryAttr")
                        .IsRequired();

                    b.Property<bool>("BooleanAttr");

                    b.Property<byte>("ByteAttr");

                    b.Property<DateTime>("DateTimeAttr");

                    b.Property<DateTimeOffset>("DateTimeOffsetAttr");

                    b.Property<decimal>("DecimalAttr");

                    b.Property<double>("DoubleAttr");

                    b.Property<Guid>("GuidAttr");

                    b.Property<short>("Int16Attr");

                    b.Property<int>("Int32Attr");

                    b.Property<long>("Int64Attr");

                    b.Property<float>("SingleAttr");

                    b.Property<string>("StringAttr")
                        .IsRequired();

                    b.Property<TimeSpan>("TimeAttr");

                    b.HasKey("Id");

                    b.ToTable("AllPropertyTypesRequireds");
                });

            modelBuilder.Entity("Testing.BChild", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BParentOptional_1_Id");

                    b.Property<int?>("BParentOptional_2_Id");

                    b.Property<int>("BParentRequired_1_Id");

                    b.Property<int?>("BParentRequired_2_Id");

                    b.Property<int?>("BParentRequired_Id");

                    b.HasKey("Id");

                    b.HasIndex("BParentOptional_1_Id");

                    b.HasIndex("BParentOptional_2_Id")
                        .IsUnique()
                        .HasFilter("[BParentOptional_2_Id] IS NOT NULL");

                    b.HasIndex("BParentRequired_1_Id")
                        .IsUnique();

                    b.HasIndex("BParentRequired_2_Id");

                    b.HasIndex("BParentRequired_Id")
                        .IsUnique()
                        .HasFilter("[BParentRequired_Id] IS NOT NULL");

                    b.ToTable("BChilds");
                });

            modelBuilder.Entity("Testing.BParentCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BChildOptional_Id");

                    b.Property<int>("BChildRequired_Id");

                    b.HasKey("Id");

                    b.HasIndex("BChildOptional_Id");

                    b.HasIndex("BChildRequired_Id");

                    b.ToTable("BParentCollections");
                });

            modelBuilder.Entity("Testing.BParentOptional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BChildRequired_Id");

                    b.HasKey("Id");

                    b.HasIndex("BChildRequired_Id")
                        .IsUnique();

                    b.ToTable("BParentOptionals");
                });

            modelBuilder.Entity("Testing.BParentRequired", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("BParentRequireds");
                });

            modelBuilder.Entity("Testing.BaseClassWithRequiredProperties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Property0")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("BaseClassWithRequiredProperties");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseClassWithRequiredProperties");
                });

            modelBuilder.Entity("Testing.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Child_Children_Id");

                    b.Property<int?>("Parent_Id");

                    b.HasKey("Id");

                    b.HasIndex("Child_Children_Id");

                    b.HasIndex("Parent_Id");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("Testing.HiddenEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Property1");

                    b.HasKey("Id");

                    b.ToTable("HiddenEntities");

                    b.HasDiscriminator<string>("Discriminator").HasValue("HiddenEntity");
                });

            modelBuilder.Entity("Testing.Master", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Masters");
                });

            modelBuilder.Entity("Testing.ParserTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name");

                    b.Property<string>("name1");

                    b.Property<int?>("name11");

                    b.Property<int?>("name12");

                    b.Property<int?>("name13");

                    b.Property<int?>("name14");

                    b.Property<string>("name15");

                    b.Property<string>("name16");

                    b.Property<string>("name17");

                    b.Property<string>("name18");

                    b.Property<string>("name2");

                    b.Property<int?>("name3");

                    b.Property<int?>("name4");

                    b.Property<int?>("name5");

                    b.Property<int?>("name6");

                    b.Property<string>("name7");

                    b.Property<string>("name8");

                    b.Property<string>("name9");

                    b.HasKey("Id");

                    b.ToTable("ParserTests");
                });

            modelBuilder.Entity("Testing.RenamedColumn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Foo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("RenamedColumns");
                });

            modelBuilder.Entity("Testing.UChild", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UChild_UChildCollection_Id");

                    b.HasKey("Id");

                    b.HasIndex("UChild_UChildCollection_Id");

                    b.ToTable("UChilds");
                });

            modelBuilder.Entity("Testing.UParentCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UChildOptional_Id");

                    b.Property<int?>("UChildRequired_Id");

                    b.HasKey("Id");

                    b.HasIndex("UChildOptional_Id");

                    b.HasIndex("UChildRequired_Id");

                    b.ToTable("UParentCollections");
                });

            modelBuilder.Entity("Testing.UParentRequired", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UChild_UChildOptional_Id");

                    b.Property<int>("UChild_UChildRequired_Id");

                    b.HasKey("Id");

                    b.HasIndex("UChild_UChildOptional_Id")
                        .IsUnique();

                    b.HasIndex("UChild_UChildRequired_Id")
                        .IsUnique();

                    b.ToTable("UParentRequireds");
                });

            modelBuilder.Entity("Testing.AbstractBaseClass", b =>
                {
                    b.HasBaseType("Testing.BaseClassWithRequiredProperties");

                    b.HasDiscriminator().HasValue("AbstractBaseClass");
                });

            modelBuilder.Entity("Testing.BaseClass", b =>
                {
                    b.HasBaseType("Testing.BaseClassWithRequiredProperties");

                    b.HasDiscriminator().HasValue("BaseClass");
                });

            modelBuilder.Entity("Testing.UParentOptional", b =>
                {
                    b.HasBaseType("Testing.HiddenEntity");

                    b.Property<string>("PropertyInChild");

                    b.Property<int?>("UChildRequired_Id");

                    b.Property<int?>("UChild_UChildOptional_Id");

                    b.HasIndex("UChildRequired_Id")
                        .IsUnique()
                        .HasFilter("[UChildRequired_Id] IS NOT NULL");

                    b.HasIndex("UChild_UChildOptional_Id")
                        .IsUnique()
                        .HasFilter("[UChild_UChildOptional_Id] IS NOT NULL");

                    b.HasDiscriminator().HasValue("UParentOptional");
                });

            modelBuilder.Entity("Testing.ConcreteDerivedClass", b =>
                {
                    b.HasBaseType("Testing.AbstractBaseClass");

                    b.Property<string>("Property1");

                    b.Property<string>("PropertyInChild");

                    b.HasDiscriminator().HasValue("ConcreteDerivedClass");
                });

            modelBuilder.Entity("Testing.ConcreteDerivedClassWithRequiredProperties", b =>
                {
                    b.HasBaseType("Testing.AbstractBaseClass");

                    b.Property<string>("Property1")
                        .IsRequired()
                        .HasColumnName("ConcreteDerivedClassWithRequiredProperties_Property1");

                    b.HasDiscriminator().HasValue("ConcreteDerivedClassWithRequiredProperties");
                });

            modelBuilder.Entity("Testing.DerivedClass", b =>
                {
                    b.HasBaseType("Testing.BaseClass");

                    b.Property<string>("Property1")
                        .HasColumnName("DerivedClass_Property1");

                    b.Property<string>("PropertyInChild")
                        .HasColumnName("DerivedClass_PropertyInChild");

                    b.HasDiscriminator().HasValue("DerivedClass");
                });

            modelBuilder.Entity("Testing.AllPropertyTypesOptional", b =>
                {
                    b.OwnsOne("Testing.OwnedType", "OwnedType", b1 =>
                        {
                            b1.Property<int>("AllPropertyTypesOptionalId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("AllPropertyTypesOptionalId1");

                            b1.Property<float?>("SingleAttr");

                            b1.HasKey("AllPropertyTypesOptionalId", "AllPropertyTypesOptionalId1");

                            b1.ToTable("AllPropertyTypesOptionals","dbo");

                            b1.HasOne("Testing.AllPropertyTypesOptional")
                                .WithOne("OwnedType")
                                .HasForeignKey("Testing.OwnedType", "AllPropertyTypesOptionalId", "AllPropertyTypesOptionalId1")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("Testing.BChild", b =>
                {
                    b.HasOne("Testing.BParentOptional", "BParentOptional_1")
                        .WithMany("BChildCollection")
                        .HasForeignKey("BParentOptional_1_Id");

                    b.HasOne("Testing.BParentOptional", "BParentOptional_2")
                        .WithOne("BChildOptional")
                        .HasForeignKey("Testing.BChild", "BParentOptional_2_Id");

                    b.HasOne("Testing.BParentRequired", "BParentRequired_1")
                        .WithOne("BChildRequired")
                        .HasForeignKey("Testing.BChild", "BParentRequired_1_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Testing.BParentRequired", "BParentRequired_2")
                        .WithMany("BChildCollection")
                        .HasForeignKey("BParentRequired_2_Id");

                    b.HasOne("Testing.BParentRequired", "BParentRequired")
                        .WithOne("BChildOptional")
                        .HasForeignKey("Testing.BChild", "BParentRequired_Id");
                });

            modelBuilder.Entity("Testing.BParentCollection", b =>
                {
                    b.HasOne("Testing.BChild", "BChildOptional")
                        .WithMany("BParentCollection_2")
                        .HasForeignKey("BChildOptional_Id");

                    b.HasOne("Testing.BChild", "BChildRequired")
                        .WithMany("BParentCollection")
                        .HasForeignKey("BChildRequired_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Testing.BParentOptional", b =>
                {
                    b.HasOne("Testing.BChild", "BChildRequired")
                        .WithOne("BParentOptional")
                        .HasForeignKey("Testing.BParentOptional", "BChildRequired_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Testing.Child", b =>
                {
                    b.HasOne("Testing.Master")
                        .WithMany("Children")
                        .HasForeignKey("Child_Children_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Testing.Child", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("Parent_Id");
                });

            modelBuilder.Entity("Testing.UChild", b =>
                {
                    b.HasOne("Testing.UParentOptional")
                        .WithMany("UChildCollection")
                        .HasForeignKey("UChild_UChildCollection_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Testing.UParentRequired")
                        .WithMany("UChildCollection")
                        .HasForeignKey("UChild_UChildCollection_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Testing.UParentCollection", b =>
                {
                    b.HasOne("Testing.UChild", "UChildOptional")
                        .WithMany()
                        .HasForeignKey("UChildOptional_Id");

                    b.HasOne("Testing.UChild", "UChildRequired")
                        .WithMany()
                        .HasForeignKey("UChildRequired_Id");
                });

            modelBuilder.Entity("Testing.UParentRequired", b =>
                {
                    b.HasOne("Testing.UChild", "UChildOptional")
                        .WithOne()
                        .HasForeignKey("Testing.UParentRequired", "UChild_UChildOptional_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Testing.UChild", "UChildRequired")
                        .WithOne()
                        .HasForeignKey("Testing.UParentRequired", "UChild_UChildRequired_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Testing.UParentOptional", b =>
                {
                    b.HasOne("Testing.UChild", "UChildRequired")
                        .WithOne()
                        .HasForeignKey("Testing.UParentOptional", "UChildRequired_Id");

                    b.HasOne("Testing.UChild", "UChildOptional")
                        .WithOne()
                        .HasForeignKey("Testing.UParentOptional", "UChild_UChildOptional_Id");
                });
#pragma warning restore 612, 618
        }
    }
}