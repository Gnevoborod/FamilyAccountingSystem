﻿// <auto-generated />
using System;
using FamilyAccountingSystem.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FamilyAccountingSystem.Migrations
{
    [DbContext(typeof(FamilyContext))]
    partial class FamilyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FamilyAccountingSystem.Database.Entities.AttributeEntity", b =>
                {
                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("value");

                    b.ToTable("attribute");
                });

            modelBuilder.Entity("FamilyAccountingSystem.Database.Entities.FamilyEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("family_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("family");
                });

            modelBuilder.Entity("FamilyAccountingSystem.Database.Entities.FamilyMemberEntity", b =>
                {
                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("description");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("end_date");

                    b.Property<long>("FamilyId")
                        .HasColumnType("bigint")
                        .HasColumnName("family_id");

                    b.Property<int>("FamilyRoleId")
                        .HasColumnType("integer")
                        .HasColumnName("family_role_id");

                    b.Property<long>("MemberId")
                        .HasColumnType("bigint")
                        .HasColumnName("member_id");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start_date");

                    b.HasIndex("FamilyId");

                    b.HasIndex("FamilyRoleId");

                    b.HasIndex("MemberId");

                    b.ToTable("family_member");
                });

            modelBuilder.Entity("FamilyAccountingSystem.Database.Entities.FamilyMemberPropertyEntity", b =>
                {
                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("description");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("end_date");

                    b.Property<long>("FamilyId")
                        .HasColumnType("bigint")
                        .HasColumnName("famiy_member_property_id");

                    b.Property<long>("MemberId")
                        .HasColumnType("bigint")
                        .HasColumnName("member_id");

                    b.Property<long>("PropertyId")
                        .HasColumnType("bigint")
                        .HasColumnName("property_id");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start_date");

                    b.HasIndex("FamilyId");

                    b.HasIndex("MemberId");

                    b.HasIndex("PropertyId");

                    b.ToTable("famiy_member_property");
                });

            modelBuilder.Entity("FamilyAccountingSystem.Database.Entities.FamilyRoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("family_role_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("family_role");
                });

            modelBuilder.Entity("FamilyAccountingSystem.Database.Entities.MemberEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("member_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateOnly?>("BirthDay")
                        .HasColumnType("date")
                        .HasColumnName("birthday");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("description");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("email");

                    b.Property<bool?>("Gender")
                        .HasColumnType("boolean")
                        .HasColumnName("gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("patronymic");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("phone");

                    b.Property<string>("Surname")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("surname");

                    b.HasKey("Id");

                    b.ToTable("member");
                });

            modelBuilder.Entity("FamilyAccountingSystem.Database.Entities.PropertyEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("property_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("property");
                });

            modelBuilder.Entity("FamilyAccountingSystem.Database.Entities.FamilyMemberEntity", b =>
                {
                    b.HasOne("FamilyAccountingSystem.Database.Entities.FamilyEntity", "Family")
                        .WithMany()
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyAccountingSystem.Database.Entities.FamilyRoleEntity", "FamilyRole")
                        .WithMany()
                        .HasForeignKey("FamilyRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyAccountingSystem.Database.Entities.MemberEntity", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Family");

                    b.Navigation("FamilyRole");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("FamilyAccountingSystem.Database.Entities.FamilyMemberPropertyEntity", b =>
                {
                    b.HasOne("FamilyAccountingSystem.Database.Entities.FamilyEntity", "Family")
                        .WithMany()
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyAccountingSystem.Database.Entities.MemberEntity", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyAccountingSystem.Database.Entities.PropertyEntity", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Family");

                    b.Navigation("Member");

                    b.Navigation("Property");
                });
#pragma warning restore 612, 618
        }
    }
}
