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
    [Migration("20241112041617_SeedMovies4")]
    partial class SeedMovies4
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
                            Id = 1,
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
                            Id = 2,
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
                            Id = 3,
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
                            Id = 4,
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
                            Id = 5,
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
                            Id = 6,
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
                            Id = 7,
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
                            Id = 8,
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
                            Id = 9,
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
                            Id = 10,
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
                        },
                        new
                        {
                            Id = 11,
                            Actors = "Tom Hardy, Michelle Williams",
                            Description = "Eddie and Venom are on the run. Hunted by both of their worlds and with the net closing in, the duo are forced into a devastating decision that will bring the curtains down on Venom and Eddie's last dance.",
                            Director = "Tim Scott",
                            Path = "/aosm8NMQ3UyoBVpSxyimorCQykC.jpg",
                            Rating = 6.5,
                            Release = new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "action",
                            Title = "Venom: The Last Dance",
                            Type = "movie",
                            Writers = "David White"
                        },
                        new
                        {
                            Id = 12,
                            Actors = "Raúl Jiménez, Ana María Rivas",
                            Description = "When a kind of rabies that transforms people into aggressive creatures spreads across the planet, Manel isolates himself at home with his cat, relying on his wits to survive; but soon they must go out in search of food, by land and by sea, dodging many dangers.",
                            Director = "Carlos Muñoz",
                            Path = "/wIGJnIFQlESkC2rLpfA8EDHqk4g.jpg",
                            Rating = 6.9000000000000004,
                            Release = new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "action",
                            Title = "Apocalypse Z: The Beginning of the End",
                            Type = "movie",
                            Writers = "Luis Hernández"
                        },
                        new
                        {
                            Id = 13,
                            Actors = "Ryan Reynolds, Hugh Jackman",
                            Description = "A listless Wade Wilson toils away in civilian life with his days as the morally flexible mercenary, Deadpool, behind him. But when his homeworld faces an existential threat, Wade must reluctantly suit-up again with an even more reluctant Wolverine.",
                            Director = "David Leitch",
                            Path = "/8cdWjvZQUExUUTzyp4t6EDMubfO.jpg",
                            Rating = 7.7000000000000002,
                            Release = new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "action",
                            Title = "Deadpool & Wolverine",
                            Type = "movie",
                            Writers = "Rhett Reese, Paul Wernick"
                        },
                        new
                        {
                            Id = 14,
                            Actors = "Ethan Hawke, Jack Dylan Grazer",
                            Description = "In the near future, on a decimated Earth, Paul and his twin sons face terror at night when ferocious creatures awaken. When Paul is nearly killed, the boys come up with a plan for survival, using everything their father taught them to keep him alive.",
                            Director = "Mark Johnson",
                            Path = "/spWV1eRzlDxvai8LbxwAWR0Vst4.jpg",
                            Rating = 6.0,
                            Release = new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "action",
                            Title = "Arcadian",
                            Type = "movie",
                            Writers = "Chris Davis"
                        },
                        new
                        {
                            Id = 16,
                            Actors = "Dwayne Johnson, Chris Evans",
                            Description = "After Santa Claus (codename: Red One) is kidnapped, the North Pole's Head of Security must team up with the world's most infamous bounty hunter in a globe-trotting, action-packed mission to save Christmas.",
                            Director = "Jake Kasdan",
                            Path = "/cdqLnri3NEGcmfnqwk2TSIYtddg1.jpg",
                            Rating = 6.9000000000000004,
                            Release = new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "action",
                            Title = "Red One",
                            Type = "movie",
                            Writers = "Chris Morgan"
                        },
                        new
                        {
                            Id = 17,
                            Actors = "Jim Caviezel, Guy Pearce",
                            Description = "Edmond Dantes becomes the target of a sinister plot and is arrested on his wedding day for a crime he did not commit. After 14 years in the island prison of Château d’If, he manages a daring escape. Now rich beyond his dreams, he assumes the identity of the Count of Monte-Cristo and exacts his revenge on the three men who betrayed him.",
                            Director = "Kevin Reynolds",
                            Path = "/zw4kV7npGtaqvUxvJE9IdqdFsNc.jpg",
                            Rating = 8.3000000000000007,
                            Release = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "action",
                            Title = "The Count of Monte-Cristo",
                            Type = "movie",
                            Writers = "Alexandre Dumas"
                        },
                        new
                        {
                            Id = 18,
                            Actors = "Tom Hardy, Michelle Williams",
                            Description = "Investigative journalist Eddie Brock attempts a comeback following a scandal, but accidentally becomes the host of Venom, a violent, super powerful alien symbiote. Soon, he must rely on his newfound powers to protect the world from a shadowy organization looking for a symbiote of their own.",
                            Director = "Ruben Fleischer",
                            Path = "/2uNW4WbgBXL25BAbXGLnLqX71Sw.jpg",
                            Rating = 6.7999999999999998,
                            Release = new DateTime(2018, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "action",
                            Title = "Venom",
                            Type = "movie",
                            Writers = "Jeff Pinkner, Scott Rosenberg"
                        },
                        new
                        {
                            Id = 19,
                            Actors = "Tom Hardy, Woody Harrelson",
                            Description = "After finding a host body in investigative reporter Eddie Brock, the alien symbiote must face a new enemy, Carnage, the alter ego of serial killer Cletus Kasady.",
                            Director = "Andy Serkis",
                            Path = "/1MJNcPZy46hIy2CmSqOeru0yr5C.jpg",
                            Rating = 6.7999999999999998,
                            Release = new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "action",
                            Title = "Venom: Let There Be Carnage",
                            Type = "movie",
                            Writers = "Kelly Marcel"
                        },
                        new
                        {
                            Id = 20,
                            Actors = "Steve Carell, Taraji P. Henson",
                            Description = "Gru and Lucy and their girls—Margo, Edith and Agnes—welcome a new member to the Gru family, Gru Jr., who is intent on tormenting his dad. Gru also faces a new nemesis in Maxime Le Mal and his femme fatale girlfriend Valentina, forcing the family to go on the run.",
                            Director = "Kyle Balda",
                            Path = "/wWba3TaojhK7NdycRhoQpsG0FaH.jpg",
                            Rating = 7.0999999999999996,
                            Release = new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "action",
                            Title = "Despicable Me 4",
                            Type = "movie",
                            Writers = "Matthew Fogel"
                        },
                        new
                        {
                            Id = 21,
                            Actors = "Nicolas Duvauchelle, Mélanie Thierry",
                            Description = "A couple celebrates their son’s birthday in the middle of the ocean on their boat. A violent storm hits and it brings up hungry creatures from the depths and they fight for their survival.",
                            Director = "Éric Rochant",
                            Path = "/7fR3KxswtY8OHHZuOUB9td58CRX.jpg",
                            Rating = 5.0,
                            Release = new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "action",
                            Title = "Survive",
                            Type = "movie",
                            Writers = "Éric Rochant"
                        },
                        new
                        {
                            Id = 22,
                            Actors = "Sophie Turner, Matthew Goode",
                            Description = "A burned-out professional sniper finds himself trapped in an all-glass penthouse by a lethal competitor and must find a way to survive and escape with little to no cover between him and the killer.",
                            Director = "Tom Paton",
                            Path = "/xNLiMNyFzKTL9PVIEulG55Hei8j.jpg",
                            Rating = 6.5999999999999996,
                            Release = new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "action",
                            Title = "Take Cover",
                            Type = "movie",
                            Writers = "Tom Paton"
                        },
                        new
                        {
                            Id = 23,
                            Actors = "Jessica Chastain, John Boyega",
                            Description = "Top level CIA agent Avery Graves is blackmailed by terrorists into betraying her own country to save her kidnapped husband. Cut off from her team, she turns to her underworld contacts to survive and help locate the coveted intelligence that the kidnappers want.",
                            Director = "Mark Williams",
                            Path = "/hhiR6uUbTYYvKoACkdAIQPS5c6f.jpg",
                            Rating = 6.2999999999999998,
                            Release = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "action",
                            Title = "Canary Black",
                            Type = "movie",
                            Writers = "Mark Williams"
                        },
                        new
                        {
                            Id = 24,
                            Actors = "Not Available",
                            Description = "Amid the stark discord of twin cities Piltover and Zaun, two sisters fight on rival sides of a war between magic technologies and clashing convictions.",
                            Director = "Not Available",
                            Path = "/q8eejQcg1bAqImEV8jh8RtBD4uH.jpg",
                            Rating = 8.8000000000000007,
                            Release = new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "banner",
                            Title = "Arcane",
                            Type = "tv",
                            Writers = "Not Available"
                        },
                        new
                        {
                            Id = 25,
                            Actors = "Not Available",
                            Description = "After Santa Claus (codename: Red One) is kidnapped, the North Pole's Head of Security must team up with the world's most infamous bounty hunter in a globe-trotting, action-packed mission to save Christmas.",
                            Director = "Not Available",
                            Path = "/rOmUuQEZfPXglwFs5ELLLUDKodL.jpg",
                            Rating = 6.5999999999999996,
                            Release = new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "banner",
                            Title = "Red One",
                            Type = "movie",
                            Writers = "Not Available"
                        },
                        new
                        {
                            Id = 26,
                            Actors = "Not Available",
                            Description = "With the city in peril following the seawall's collapse, Oswald \"Oz\" Cobb’s quest seeks to fill the power vacuum left by the death of Carmine Falcone and finally give his mother Francis the life he's always promised. But first, Oz must confront his enemies and his own demoralizing reputation as \"the Penguin.\"",
                            Director = "Not Available",
                            Path = "/qq36sU5xH581RiNEkookMQ9D7yp.jpg",
                            Rating = 8.5,
                            Release = new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "banner",
                            Title = "The Penguin",
                            Type = "tv",
                            Writers = "Not Available"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
