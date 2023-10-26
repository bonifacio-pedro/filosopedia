﻿// <auto-generated />
using System;
using FilosoPediaWeb.Api.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FIlosoPediaWeb.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("FilosoPediaWeb.Api.Models.Author", b =>
                {
                    b.Property<long>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("TEXT");

                    b.Property<long>("GenderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.HasIndex("GenderId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("FilosoPediaWeb.Api.Models.Book", b =>
                {
                    b.Property<long>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("GenderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageBookUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Stars")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenderId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("FilosoPediaWeb.Api.Models.Comentary", b =>
                {
                    b.Property<long>("ComentaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ComentaryId");

                    b.HasIndex("BookId");

                    b.ToTable("Comentaries");
                });

            modelBuilder.Entity("FilosoPediaWeb.Api.Models.Gender", b =>
                {
                    b.Property<long>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("GenderId");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("FilosoPediaWeb.Api.Models.Author", b =>
                {
                    b.HasOne("FilosoPediaWeb.Api.Models.Gender", "Gender")
                        .WithMany("Authors")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("FilosoPediaWeb.Api.Models.Book", b =>
                {
                    b.HasOne("FilosoPediaWeb.Api.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilosoPediaWeb.Api.Models.Gender", "Gender")
                        .WithMany("Books")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("FilosoPediaWeb.Api.Models.Comentary", b =>
                {
                    b.HasOne("FilosoPediaWeb.Api.Models.Book", "Book")
                        .WithMany("Comentaries")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("FilosoPediaWeb.Api.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("FilosoPediaWeb.Api.Models.Book", b =>
                {
                    b.Navigation("Comentaries");
                });

            modelBuilder.Entity("FilosoPediaWeb.Api.Models.Gender", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
