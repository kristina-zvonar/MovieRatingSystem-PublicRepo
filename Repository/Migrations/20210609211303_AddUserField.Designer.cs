﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieRatingSystem.Repository.DB;

namespace MovieRatingSystem.Repository.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20210609211303_AddUserField")]
    partial class AddUserField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("MovieRatingSystem.Shared.DB.Actor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FirstName = "Tim",
                            LastName = "Robbins"
                        },
                        new
                        {
                            ID = 2,
                            FirstName = "Morgan",
                            LastName = "Freeman"
                        },
                        new
                        {
                            ID = 3,
                            FirstName = "Al",
                            LastName = "Pacino"
                        },
                        new
                        {
                            ID = 4,
                            FirstName = "Marlon",
                            LastName = "Brando"
                        },
                        new
                        {
                            ID = 5,
                            FirstName = "Robert",
                            LastName = "De Niro"
                        });
                });

            modelBuilder.Entity("MovieRatingSystem.Shared.DB.Content", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CoverImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CoverImage = "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png",
                            Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                            ReleaseDate = new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Shawshank Redemption",
                            Type = 1
                        },
                        new
                        {
                            ID = 2,
                            CoverImage = "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png",
                            Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                            ReleaseDate = new DateTime(1972, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Godfather",
                            Type = 1
                        },
                        new
                        {
                            ID = 3,
                            CoverImage = "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png",
                            Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                            ReleaseDate = new DateTime(1974, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Godfather - Part II",
                            Type = 1
                        });
                });

            modelBuilder.Entity("MovieRatingSystem.Shared.DB.ContentActor", b =>
                {
                    b.Property<int>("ActorID")
                        .HasColumnType("int");

                    b.Property<int>("ContentID")
                        .HasColumnType("int");

                    b.HasKey("ActorID", "ContentID");

                    b.HasIndex("ContentID");

                    b.ToTable("content_actor");

                    b.HasData(
                        new
                        {
                            ActorID = 1,
                            ContentID = 1
                        },
                        new
                        {
                            ActorID = 2,
                            ContentID = 1
                        },
                        new
                        {
                            ActorID = 3,
                            ContentID = 2
                        },
                        new
                        {
                            ActorID = 4,
                            ContentID = 2
                        },
                        new
                        {
                            ActorID = 4,
                            ContentID = 3
                        },
                        new
                        {
                            ActorID = 5,
                            ContentID = 3
                        });
                });

            modelBuilder.Entity("MovieRatingSystem.Shared.DB.ContentRating", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ContentID")
                        .HasColumnType("int");

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("ContentID");

                    b.ToTable("ContentRating");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ContentID = 1,
                            Star = 4
                        },
                        new
                        {
                            ID = 2,
                            ContentID = 1,
                            Star = 5
                        },
                        new
                        {
                            ID = 3,
                            ContentID = 2,
                            Star = 5
                        },
                        new
                        {
                            ID = 4,
                            ContentID = 3,
                            Star = 5
                        },
                        new
                        {
                            ID = 5,
                            ContentID = 3,
                            Star = 5
                        },
                        new
                        {
                            ID = 6,
                            ContentID = 3,
                            Star = 4
                        });
                });

            modelBuilder.Entity("MovieRatingSystem.Shared.DB.ContentActor", b =>
                {
                    b.HasOne("MovieRatingSystem.Shared.DB.Actor", "Actor")
                        .WithMany("ActorContent")
                        .HasForeignKey("ActorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRatingSystem.Shared.DB.Content", "Content")
                        .WithMany("ContentActors")
                        .HasForeignKey("ContentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Content");
                });

            modelBuilder.Entity("MovieRatingSystem.Shared.DB.ContentRating", b =>
                {
                    b.HasOne("MovieRatingSystem.Shared.DB.Content", "Content")
                        .WithMany("Ratings")
                        .HasForeignKey("ContentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");
                });

            modelBuilder.Entity("MovieRatingSystem.Shared.DB.Actor", b =>
                {
                    b.Navigation("ActorContent");
                });

            modelBuilder.Entity("MovieRatingSystem.Shared.DB.Content", b =>
                {
                    b.Navigation("ContentActors");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
