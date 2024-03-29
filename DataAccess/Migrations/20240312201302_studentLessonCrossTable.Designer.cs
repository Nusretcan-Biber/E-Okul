﻿// <auto-generated />
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(MasterContext))]
    [Migration("20240312201302_studentLessonCrossTable")]
    partial class studentLessonCrossTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Model.Lesson", b =>
                {
                    b.Property<int>("lessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("lessonId"));

                    b.Property<string>("lessonName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("lessonId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("Data.Model.Note", b =>
                {
                    b.Property<int>("NotesId")
                        .HasColumnType("integer");

                    b.Property<int>("Average")
                        .HasColumnType("integer");

                    b.Property<int>("Final")
                        .HasColumnType("integer");

                    b.Property<int>("Midterm")
                        .HasColumnType("integer");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("NotesId");

                    b.HasIndex("StudentId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Data.Model.Student", b =>
                {
                    b.Property<int>("SudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SudentId"));

                    b.Property<int>("GradeAvarage")
                        .HasColumnType("integer");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("StudentSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("studentPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("SudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Data.Model.StudentLesson", b =>
                {
                    b.Property<int>("SId")
                        .HasColumnType("integer");

                    b.Property<int>("LId")
                        .HasColumnType("integer");

                    b.HasKey("SId", "LId");

                    b.HasIndex("LId");

                    b.ToTable("StudentLesson");
                });

            modelBuilder.Entity("Data.Model.Teacher", b =>
                {
                    b.Property<int>("teacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("teacherId"));

                    b.Property<string>("teacherEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("teacherName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("teacherPassword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("teacherSurname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("teacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Data.Model.Note", b =>
                {
                    b.HasOne("Data.Model.Lesson", "Lesson")
                        .WithOne("Notes")
                        .HasForeignKey("Data.Model.Note", "NotesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Model.Student", "Student")
                        .WithMany("Notes")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Data.Model.StudentLesson", b =>
                {
                    b.HasOne("Data.Model.Lesson", "Lesson")
                        .WithMany("Students")
                        .HasForeignKey("LId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Model.Student", "Student")
                        .WithMany("Lessons")
                        .HasForeignKey("SId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Data.Model.Lesson", b =>
                {
                    b.Navigation("Notes")
                        .IsRequired();

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Data.Model.Student", b =>
                {
                    b.Navigation("Lessons");

                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
