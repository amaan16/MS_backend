﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieScore;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(MSContext))]
    [Migration("20241112022657_SeedMovies1")]
    partial class SeedMovies1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("MovieScore.Models.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<int>("Movie_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("User_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("User_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("MovieScore.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Actors")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Release")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Writers")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 947891,
                            Actors = "Florence Pugh, Saoirse Ronan",
                            Description = "An 18th birthday mushroom trip brings free-spirited Elliott face-to-face with her wisecracking 39-year-old self...",
                            Director = "Greta Gerwig",
                            Path = "/yUs4Sw9AyTg2sA1qWBkNpD2mGSj.jpg",
                            Rating = 6.5999999999999996,
                            Release = new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "trending",
                            Title = "My Old Ass",
                            Type = "movie",
                            Writers = "Greta Gerwig"
                        },
                        new
                        {
                            Id = 889737,
                            Actors = "Joaquin Phoenix, Lady Gaga",
                            Description = "While struggling with his dual identity, Arthur Fleck not only stumbles upon true love, but also finds the music that's always been inside him.",
                            Director = "Todd Phillips",
                            Path = "/if8QiqCI7WAGImKcJCfzp6VTyKA.jpg",
                            Rating = 5.6509999999999998,
                            Release = new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "trending",
                            Title = "Joker: Folie à Deux",
                            Type = "movie",
                            Writers = "Todd Phillips, Scott Silver"
                        },
                        new
                        {
                            Id = 592831,
                            Actors = "Adam Driver, Nathalie Emmanuel",
                            Description = "Genius artist Cesar Catilina seeks to leap the City of New Rome into a utopian, idealistic future...",
                            Director = "Francis Ford Coppola",
                            Path = "/8Sok3HNA3r1GHnK2lCytHyBz1A.jpg",
                            Rating = 5.5999999999999996,
                            Release = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "trending",
                            Title = "Megalopolis",
                            Type = "movie",
                            Writers = "Francis Ford Coppola"
                        },
                        new
                        {
                            Id = 222766,
                            Actors = "Edward Fox, Michael Lonsdale",
                            Description = "An unrivalled and highly elusive lone assassin, the Jackal, makes his living carrying out hits...",
                            Director = "Jean-Pierre Melville",
                            Path = "/tYLecM3WSEjlkKhkGiH5G68Dprm.jpg",
                            Rating = 7.9000000000000004,
                            Release = new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "trending",
                            Title = "The Day of the Jackal",
                            Type = "tv",
                            Writers = "Frederick Forsyth"
                        },
                        new
                        {
                            Id = 154084,
                            Actors = "Richard Madden, Priyanka Chopra",
                            Description = "When stuntman Bunny recruits struggling actress Honey for a side gig, they are hurled into a high-stakes world...",
                            Director = "Anthony Russo",
                            Path = "/lzZ9J2FOsaq1DCuD7k2f4ogbXdD.jpg",
                            Rating = 7.5,
                            Release = new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "trending",
                            Title = "Citadel Honey Bunny",
                            Type = "tv",
                            Writers = "Josh Appelbaum, Bryan Oh"
                        },
                        new
                        {
                            Id = 1184918,
                            Actors = "Voice of Roz, various animal voices",
                            Description = "After a shipwreck, an intelligent robot called Roz is stranded on an uninhabited island...",
                            Director = "Chris Sanders",
                            Path = "/wTnV3PCVW5O92JMrFvvrRcV39RU.jpg",
                            Rating = 8.5120000000000005,
                            Release = new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "trending",
                            Title = "The Wild Robot",
                            Type = "movie",
                            Writers = "Peter Brown"
                        },
                        new
                        {
                            Id = 94605,
                            Actors = "Alex Johnson, Emma Williams",
                            Description = "Amid the stark discord of twin cities Piltover and Zaun, two sisters fight on rival sides of a war between magic technologies and clashing convictions.",
                            Director = "John Doe",
                            Path = "/abf8tHznhSvl9BAElD2cQeRr7do.jpg",
                            Rating = 8.8000000000000007,
                            Release = new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "trending",
                            Title = "Arcane",
                            Type = "tv",
                            Writers = "Jane Smith"
                        },
                        new
                        {
                            Id = 933260,
                            Actors = "John Smith, Lucy Lee",
                            Description = "A fading celebrity decides to use a black market drug, a cell-replicating substance that temporarily creates a younger, better version of herself.",
                            Director = "Michael Brown",
                            Path = "/lqoMzCcZYEFK729d6qzt349fB4o.jpg",
                            Rating = 7.2949999999999999,
                            Release = new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "trending",
                            Title = "The Substance",
                            Type = "movie",
                            Writers = "Linda Green"
                        },
                        new
                        {
                            Id = 194764,
                            Actors = "David Harris, Rachel Adams",
                            Description = "With the city in peril following the seawall's collapse, Oswald \"Oz\" Cobb’s quest seeks to fill the power vacuum left by the death of Carmine Falcone and finally give his mother Francis the life he's always promised. But first, Oz must confront his enemies and his own demoralizing reputation as \"the Penguin.\"",
                            Director = "Alice Cooper",
                            Path = "/vOWcqC4oDQws1doDWLO7d3dh5qc.jpg",
                            Rating = 8.5,
                            Release = new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "trending",
                            Title = "The Penguin",
                            Type = "tv",
                            Writers = "Martin King"
                        },
                        new
                        {
                            Id = 845781,
                            Actors = "Tom Green, Olivia Brown",
                            Description = "After Santa Claus (codename: Red One) is kidnapped, the North Pole's Head of Security must team up with the world's most infamous bounty hunter in a globe-trotting, action-packed mission to save Christmas.",
                            Director = "Robert Black",
                            Path = "/cdqLnri3NEGcmfnqwk2TSIYtddg.jpg",
                            Rating = 6.5999999999999996,
                            Release = new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "trending",
                            Title = "Red One",
                            Type = "movie",
                            Writers = "Chris White"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
