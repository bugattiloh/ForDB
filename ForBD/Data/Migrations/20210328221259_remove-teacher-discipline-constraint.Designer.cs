﻿// <auto-generated />
using ForBD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ForBD.Data.Migrations
{
    [DbContext(typeof(MethodicalWorksContext))]
    [Migration("20210328221259_remove-teacher-discipline-constraint")]
    partial class removeteacherdisciplineconstraint
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ForBD.Accounting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InDepartment")
                        .HasColumnType("int");

                    b.Property<int>("InLibrary")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("TypographyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.ToTable("Accountings");
                });

            modelBuilder.Entity("ForBD.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Course")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("ForBD.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("ForBD.MaterialDiscipline", b =>
                {
                    b.Property<int>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.HasKey("DisciplineId", "MaterialId");

                    b.HasIndex("MaterialId");

                    b.ToTable("MaterialDisciplines");
                });

            modelBuilder.Entity("ForBD.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ToDepartment")
                        .HasColumnType("int");

                    b.Property<int>("ToLibrary")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("TypographyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypographyId");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("ForBD.Recommendation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.HasIndex("PlanId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Recommendations");
                });

            modelBuilder.Entity("ForBD.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ForBD.Typography", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountingId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Stage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountingId")
                        .IsUnique();

                    b.ToTable("Typographies");
                });

            modelBuilder.Entity("ForBD.Accounting", b =>
                {
                    b.HasOne("ForBD.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");
                });

            modelBuilder.Entity("ForBD.MaterialDiscipline", b =>
                {
                    b.HasOne("ForBD.Discipline", "Discipline")
                        .WithMany("MaterialDisciplines")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForBD.Material", "EducationMaterial")
                        .WithMany("MaterialDisciplines")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("EducationMaterial");
                });

            modelBuilder.Entity("ForBD.Plan", b =>
                {
                    b.HasOne("ForBD.Typography", "Typography")
                        .WithMany("Plans")
                        .HasForeignKey("TypographyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Typography");
                });

            modelBuilder.Entity("ForBD.Recommendation", b =>
                {
                    b.HasOne("ForBD.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForBD.Plan", "Plan")
                        .WithMany("Recommendations")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ForBD.Teacher", "Teacher")
                        .WithMany("Recommendations")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Plan");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ForBD.Typography", b =>
                {
                    b.HasOne("ForBD.Accounting", "Accounting")
                        .WithOne("Typography")
                        .HasForeignKey("ForBD.Typography", "AccountingId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Accounting");
                });

            modelBuilder.Entity("ForBD.Accounting", b =>
                {
                    b.Navigation("Typography");
                });

            modelBuilder.Entity("ForBD.Discipline", b =>
                {
                    b.Navigation("MaterialDisciplines");
                });

            modelBuilder.Entity("ForBD.Material", b =>
                {
                    b.Navigation("MaterialDisciplines");
                });

            modelBuilder.Entity("ForBD.Plan", b =>
                {
                    b.Navigation("Recommendations");
                });

            modelBuilder.Entity("ForBD.Teacher", b =>
                {
                    b.Navigation("Recommendations");
                });

            modelBuilder.Entity("ForBD.Typography", b =>
                {
                    b.Navigation("Plans");
                });
#pragma warning restore 612, 618
        }
    }
}
