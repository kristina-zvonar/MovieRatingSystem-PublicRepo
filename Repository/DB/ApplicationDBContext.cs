using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieRatingSystem.Shared.DB;
using MovieRatingSystem.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatingSystem.Repository.DB
{

    public partial class ApplicationDBContext : DbContext
    {
        private IConfiguration Configuration { get; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options, IConfiguration configuration) : base(options) => Configuration = configuration;

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Content> Contents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = Configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContentActor>()
                .ToTable("content_actor")
                .HasKey(el => new { el.ActorID, el.ContentID });

            modelBuilder.Entity<ContentActor>()
                .HasOne(el => el.Actor)
                .WithMany(el => el.ActorContent)
                .HasForeignKey(el => el.ActorID);

            modelBuilder.Entity<ContentActor>()
                .HasOne(el => el.Content)
                .WithMany(el => el.ContentActors)
                .HasForeignKey(el => el.ContentID);

            OnModelCreatingPartial(modelBuilder);
            SeedDatabase(modelBuilder);
        }

        private void SeedDatabase(ModelBuilder modelBuilder)
        {
            var storageAccount = Configuration["StorageAccount"];
            #region Movie Actor
            modelBuilder.Entity<Actor>().HasData
                (
                    new Actor { ID = 1, FirstName = "Tim", LastName = "Robbins" },
                    new Actor { ID = 2, FirstName = "Morgan", LastName = "Freeman" },
                    new Actor { ID = 3, FirstName = "Al", LastName = "Pacino" },
                    new Actor { ID = 4, FirstName = "Marlon", LastName = "Brando" },
                    new Actor { ID = 5, FirstName = "Robert", LastName = "De Niro" },
                    new Actor { ID = 6, FirstName = "Christian", LastName = "Bale"},
                    new Actor { ID = 7, FirstName = "Heath", LastName = "Ledger"},
                    new Actor { ID = 8, FirstName = "Henry", LastName = "Fonda"},
                    new Actor { ID = 9, FirstName = "Lee J", LastName = "Cobb"},
                    new Actor { ID = 10, FirstName = "Liam", LastName = "Neeson"},
                    new Actor { ID = 11, FirstName = "Ralph", LastName = "Fiennes"},                    
                    new Actor { ID = 12, FirstName = "John", LastName = "Travolta"},
                    new Actor { ID = 13, FirstName = "Uma", LastName = "Thurman"},
                    new Actor { ID = 14, FirstName = "Samuel L.", LastName = "Jackson"},
                    new Actor { ID = 15, FirstName = "Clint", LastName = "Eastwood"},
                    new Actor { ID = 16, FirstName = "Elli", LastName = "Wallach"},
                    new Actor { ID = 17, FirstName = "Brad", LastName = "Pitt"},
                    new Actor { ID = 18, FirstName = "Edward", LastName = "Norton"},
                    new Actor { ID = 19, FirstName = "Elijah", LastName = "Wood"},
                    new Actor { ID = 20, FirstName = "Viggo", LastName = "Mortensen"}
                );
            #endregion

            #region TV Actor
            modelBuilder.Entity<Actor>().HasData
                (
                    new Actor { ID = 21, FirstName = "Scott", LastName = "Griems" },
                    new Actor { ID = 22, FirstName = "Daniel", LastName = "Lewis" },
                    new Actor { ID = 23, FirstName = "Bryan", LastName = "Cranston" },
                    new Actor { ID = 24, FirstName = "Aaron", LastName = "Paul" },
                    new Actor { ID = 25, FirstName = "Jessie", LastName = "Buckley" },
                    new Actor { ID = 26, FirstName = "Jared", LastName = "Harris" },
                    new Actor { ID = 27, FirstName = "Dee Bradley", LastName = "Baker" },
                    new Actor { ID = 28, FirstName = "Zach", LastName = "Tyler" },
                    new Actor { ID = 29, FirstName = "Emilia", LastName = "Clarke" },
                    new Actor { ID = 30, FirstName = "Peter", LastName = "Dinklage" },
                    new Actor { ID = 31, FirstName = "James", LastName = "Gandolfini" },
                    new Actor { ID = 32, FirstName = "Lorraine", LastName = "Bracco" },
                    new Actor { ID = 33, FirstName = "Benedict", LastName = "Cumberbatch" },
                    new Actor { ID = 34, FirstName = "Martin", LastName = "Freeman" },
                    new Actor { ID = 35, FirstName = "Mamoru", LastName = "Miyano" },
                    new Actor { ID = 36, FirstName = "Brad", LastName = "Swaile" },
                    new Actor { ID = 37, FirstName = "Steve", LastName = "Carrel" },
                    new Actor { ID = 38, FirstName = "Jenna", LastName = "Fischer" },
                    new Actor { ID = 39, FirstName = "Jennifer", LastName = "Anniston" },
                    new Actor { ID = 40, FirstName = "Courtney", LastName = "Cox" },
                    new Actor { ID = 41, FirstName = "Daniel", LastName = "Lapaine" },
                    new Actor { ID = 42, FirstName = "Michaela", LastName = "Coel" }
                );
            #endregion

            #region Movies
            modelBuilder.Entity<Content>().HasData
                (
                    new Content 
                    { 
                        ID = 1, 
                        Title = "The Shawshank Redemption", 
                        ReleaseDate = DateTime.Parse("1994-01-01"),
                        Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                        CoverImage = $"{storageAccount}3-Shawshank.jpg?st=2021-06-10T18%3A13%3A59Z&se=2022-06-11T18%3A13%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=QA2ZsrlJPkkmyZ0Y7tZbP8Vqwkwyab7l08jV2AZ9740%3D",
                        Type = (int) ContentTypeEnum.MOVIE
                    },
                    new Content
                    {
                        ID = 2,
                        Title = "The Godfather",
                        ReleaseDate = DateTime.Parse("1972-01-01"),
                        Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                        CoverImage = $"{storageAccount}1-Godfather.jpg?st=2021-06-10T18%3A14%3A23Z&se=2022-06-11T18%3A14%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=WKCSEmd8lkauEaoBeBOxid3fCCDUdr652Kq86ru0NA4%3D",
                        Type = (int)ContentTypeEnum.MOVIE
                    },
                    new Content
                    {
                        ID = 3,
                        Title = "The Godfather - Part II",
                        ReleaseDate = DateTime.Parse("1974-01-01"),
                        Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                        CoverImage = $"{storageAccount}2-Godfather2.jpg?st=2021-06-10T18%3A05%3A35Z&se=2022-06-11T18%3A05%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=jP6oCPBct%2FnFERSjI8aT7eu9hP1enPJwonSjEbp3IFk%3D",
                        Type = (int)ContentTypeEnum.MOVIE
                    },
                    new Content
                    {
                        ID = 4,
                        Title = "The Dark Knight",
                        ReleaseDate = DateTime.Parse("2008-01-01"),
                        Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                        CoverImage = $"{storageAccount}4-TheDarkKnight.jpg?st=2021-06-10T18%3A17%3A08Z&se=2022-06-11T18%3A17%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=SMP9cXYA9HgH7RGTgUk%2B%2B7gdcEvOhaD2AbMNBISJffA%3D",
                        Type = (int)ContentTypeEnum.MOVIE
                    },
                    new Content
                    {
                        ID = 5,
                        Title = "12 Angry Men",
                        ReleaseDate = DateTime.Parse("1957-01-01"),
                        Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                        CoverImage = "https://storageacckristina2020.blob.core.windows.net/contentcoverimages/5-12AngryMan.jpg?st=2021-06-10T18%3A16%3A45Z&se=2022-06-11T18%3A16%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=iBKjnzxS6Nw935GTeoR1HfB64EIy1bdYyyz6bWsdlKY%3D",
                        Type = (int)ContentTypeEnum.MOVIE
                    },
                    new Content
                    {
                        ID = 6,
                        Title = "Schindler's List",
                        ReleaseDate = DateTime.Parse("1993-01-01"),
                        Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                        CoverImage = $"{storageAccount}6-SchindlersList.jpg?st=2021-06-10T18%3A17%3A38Z&se=2022-06-11T18%3A17%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=GjV5Br0fYxYeClCZEor2MwKwfT3GgCRwrLufZc2%2B%2BqU%3D",
                        Type = (int)ContentTypeEnum.MOVIE
                    },
                    new Content
                    {
                        ID = 7,
                        Title = "The Two Towers",
                        ReleaseDate = DateTime.Parse("2002-01-01"),
                        Description = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                        CoverImage = $"{storageAccount}7-TwoTowers.jpg?st=2021-06-10T18%3A18%3A16Z&se=2022-06-11T18%3A18%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=eETOCes0CoNRx21E8zt7PIZIPL5D%2FsWILS8P1%2BoHvJ8%3D",
                        Type = (int)ContentTypeEnum.MOVIE
                    },
                    new Content
                    {
                        ID = 8,
                        Title = "The Return of the King",
                        ReleaseDate = DateTime.Parse("2003-01-01"),
                        Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                        CoverImage = $"{storageAccount}8-ReturnOfTheKing.jpg?st=2021-06-10T18%3A18%3A36Z&se=2022-06-11T18%3A18%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=rQvbNbxVvm4UzE1cZOBFYNb4I2vpB%2BdluIvpHzWWy3c%3D",
                        Type = (int)ContentTypeEnum.MOVIE
                    },
                    new Content
                    {
                        ID = 9,
                        Title = "Pulp Fiction",
                        ReleaseDate = DateTime.Parse("1994-01-01"),
                        Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                        CoverImage = $"{storageAccount}9-PulpFiction.jpg?st=2021-06-10T18%3A18%3A57Z&se=2022-06-11T18%3A18%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=UvY%2FSSDAR9KMHOfXbkt3n971ZSDMtXgfkNARv1cLnq8%3D",
                        Type = (int)ContentTypeEnum.MOVIE
                    },
                    new Content
                    {
                        ID = 10,
                        Title = "Fight Club",
                        ReleaseDate = DateTime.Parse("1999-01-01"),
                        Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                        CoverImage = $"{storageAccount}10-FightClub.jpg?st=2021-06-10T18%3A19%3A18Z&se=2022-06-11T18%3A19%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=2nDZQ60zMs4AqTV5NW66KWHS6yNxlOqeFXsHFM9Wx5Y%3D",
                        Type = (int)ContentTypeEnum.MOVIE
                    },
                    new Content
                    {
                        ID = 11,
                        Title = "The Good, the Bad, and the Ugly",
                        ReleaseDate = DateTime.Parse("1966-01-01"),
                        Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                        CoverImage = $"{storageAccount}11-GoodBadUgly.jpg?st=2021-06-10T18%3A20%3A11Z&se=2022-06-11T18%3A20%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=cRc9qgTKn4%2FVfQqpVQeEBI6V9WEXfCePWj%2BT9CpQe50%3D",
                        Type = (int)ContentTypeEnum.MOVIE
                    },
                    new Content
                    {
                        ID = 12,
                        Title = "The Fellowship of the Ring",
                        ReleaseDate = DateTime.Parse("2002-01-01"),
                        Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                        CoverImage = $"{storageAccount}12-Fellowship.jpg?st=2021-06-10T18%3A20%3A28Z&se=2022-06-11T18%3A20%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=3AXMY0Ak2fApkDB%2FabkfdXEt8CYtMPhBcyU7tM9yOng%3D",
                        Type = (int)ContentTypeEnum.MOVIE
                    }
                );
            #endregion

            #region TV Shows
            modelBuilder.Entity<Content>().HasData
                (
                    new Content
                    {
                        ID = 13,
                        Title = "Band of Brothers",
                        ReleaseDate = DateTime.Parse("2001-01-01"),
                        Description = "The story of Easy Company of the U.S. Army 101st Airborne Division, and their mission in World War II Europe, from Operation Overlord, through V-J Day.",
                        CoverImage = $"{storageAccount}1-BandOfBrothers.jpg?st=2021-06-10T19%3A27%3A26Z&se=2022-06-11T19%3A27%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=og6lZCfRh1du8uq7NsjewU6ouNEmUnjWUwXoVT8RofM%3D",
                        Type = (int)ContentTypeEnum.TV_SHOW
                    },
                    new Content
                    {
                        ID = 14,
                        Title = "Breaking Bad",
                        ReleaseDate = DateTime.Parse("2008-01-01"),
                        Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                        CoverImage = $"{storageAccount}2-BreakingBad.jpg?st=2021-06-10T19%3A28%3A11Z&se=2022-06-11T19%3A28%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=YcidsXmOeSjJZGXrHRy9c27d89ZQqCYN6GZ7JfnI3TU%3D",
                        Type = (int)ContentTypeEnum.TV_SHOW
                    },
                    new Content
                    {
                        ID = 15,
                        Title = "Chernobyl",
                        ReleaseDate = DateTime.Parse("2019-01-01"),
                        Description = "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.",
                        CoverImage = $"{storageAccount}3-Chernobyl.jpg?st=2021-06-10T19%3A28%3A32Z&se=2022-06-11T19%3A28%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=6P9HSUbGxhQuhKhqTj0tkO8rjVoqNtpvpKbf58kywO8%3D",
                        Type = (int)ContentTypeEnum.TV_SHOW
                    },
                    new Content
                    {
                        ID = 16,
                        Title = "Avatar: The Last Airbender",
                        ReleaseDate = DateTime.Parse("2005-01-01"),
                        Description = "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.",
                        CoverImage = $"{storageAccount}4-Avatar.jpg?st=2021-06-10T19%3A29%3A16Z&se=2022-06-11T19%3A29%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=wq23ADWfpQbPPNLRb9AGJFo3FG8gVtQnA3MI5HMBwzE%3D",
                        Type = (int)ContentTypeEnum.TV_SHOW
                    },
                    new Content
                    {
                        ID = 17,
                        Title = "Game of Thrones",
                        ReleaseDate = DateTime.Parse("2011-01-01"),
                        Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                        CoverImage = $"{storageAccount}5-GameOfTHrones.jpg?st=2021-06-10T19%3A29%3A48Z&se=2022-06-11T19%3A29%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=JjNo00MbH%2BQF2mP4wvWsuLDCD7Mfqo3WnXh%2BFn8u3%2Bc%3D",
                        Type = (int)ContentTypeEnum.TV_SHOW
                    },
                    new Content
                    {
                        ID = 18,
                        Title = "The Sopranos",
                        ReleaseDate = DateTime.Parse("1999-01-01"),
                        Description = "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.",
                        CoverImage = $"{storageAccount}6-TheSopranos.jpg?st=2021-06-10T19%3A30%3A09Z&se=2022-06-11T19%3A30%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=n0c3WKDnX%2BpkD4nE%2Fdfc9uPRvaZYNMUi8G87rbFoDgw%3D",
                        Type = (int)ContentTypeEnum.TV_SHOW
                    },
                    new Content
                    {
                        ID = 19,
                        Title = "Sherlock",
                        ReleaseDate = DateTime.Parse("2010-01-01"),
                        Description = "A modern update finds the famous sleuth and his doctor partner solving crime in 21st century London.",
                        CoverImage = $"{storageAccount}7-Sherlock.jpg?st=2021-06-10T19%3A30%3A36Z&se=2022-06-11T19%3A30%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=AafQw7B83VJpOPbRISWL3jUDtBC%2F4xp37LmOixOjwZc%3D",
                        Type = (int)ContentTypeEnum.TV_SHOW
                    },
                    new Content
                    {
                        ID = 20,
                        Title = "Death Note",
                        ReleaseDate = DateTime.Parse("2006-01-01"),
                        Description = "An intelligent high school student goes on a secret crusade to eliminate criminals from the world after discovering a notebook capable of killing anyone whose name is written into it.",
                        CoverImage = $"{storageAccount}8-DeathNote.jpg?st=2021-06-10T19%3A30%3A59Z&se=2022-06-11T19%3A30%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=2IPgv92Rwg%2FDev1VwRSI8iqBo0duDgvL%2FILO71F6QSk%3D",
                        Type = (int)ContentTypeEnum.TV_SHOW
                    },
                    new Content
                    {
                        ID = 21,
                        Title = "The Office",
                        ReleaseDate = DateTime.Parse("2005-01-01"),
                        Description = "A mockumentary on a group of typical office workers, where the workday consists of ego clashes, inappropriate behavior, and tedium.",
                        CoverImage = $"{storageAccount}9-TheOffice.jpg?st=2021-06-10T19%3A31%3A40Z&se=2022-06-11T19%3A31%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=x4Dfrei7YPk1fSpQiyZywScD5Teeu0XkxQJYPRdH8x8%3D",
                        Type = (int)ContentTypeEnum.TV_SHOW
                    },
                    new Content
                    {
                        ID = 22,
                        Title = "Friends",
                        ReleaseDate = DateTime.Parse("1994-01-01"),
                        Description = "Follows the personal and professional lives of six twenty to thirty-something-year-old friends living in Manhattan.",
                        CoverImage = $"{storageAccount}10-Friends.jpg?st=2021-06-10T19%3A32%3A06Z&se=2022-06-11T19%3A32%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=70DjexZDZp90oJ1PgsZkVBHfmSjhFy3GuQ6h%2BL4MgOE%3D",
                        Type = (int)ContentTypeEnum.TV_SHOW
                    },
                    new Content
                    {
                        ID = 23,
                        Title = "Black Mirror",
                        ReleaseDate = DateTime.Parse("2011-01-01"),
                        Description = "An anthology series exploring a twisted, high-tech multiverse where humanity's greatest innovations and darkest instincts collide.",
                        CoverImage = $"{storageAccount}11-BlackMirror.jpg?st=2021-06-10T19%3A32%3A27Z&se=2022-06-11T19%3A32%3A00Z&sp=rl&sv=2018-03-28&sr=b&sig=Rs%2FDYCbXEEGxMFHem3UY8NZ66S2zOmpQ4QhGExZtJx4%3D",
                        Type = (int)ContentTypeEnum.TV_SHOW
                    }
                );
            #endregion

            #region Movie Actors
            modelBuilder.Entity<ContentActor>().HasData
                (
                    new ContentActor
                    {
                        ActorID = 1,
                        ContentID = 1
                    },
                    new ContentActor
                    {
                        ActorID = 2,
                        ContentID = 1
                    },
                    new ContentActor
                    {
                        ActorID = 3,
                        ContentID = 2
                    },
                    new ContentActor
                    {
                        ActorID = 4,
                        ContentID = 2
                    },
                    new ContentActor
                    {
                        ActorID = 4,
                        ContentID = 3
                    },
                    new ContentActor
                    {
                        ActorID = 5,
                        ContentID = 3
                    },
                    new ContentActor
                    {
                        ActorID = 6,
                        ContentID = 4
                    },
                    new ContentActor
                    {
                        ActorID = 7,
                        ContentID = 4
                    }, 
                    new ContentActor
                    {
                        ActorID = 8,
                        ContentID = 5
                    },
                    new ContentActor
                    {
                        ActorID = 9,
                        ContentID = 5
                    },
                    new ContentActor
                    {
                        ActorID = 10,
                        ContentID = 6
                    },
                    new ContentActor
                    {
                        ActorID = 11,
                        ContentID = 6
                    },
                    new ContentActor
                    {
                        ActorID = 19,
                        ContentID = 7
                    },
                    new ContentActor
                    {
                        ActorID = 20,
                        ContentID = 7
                    },
                    new ContentActor
                    {
                        ActorID = 19,
                        ContentID = 8
                    },
                    new ContentActor
                    {
                        ActorID = 20,
                        ContentID = 8
                    },
                    new ContentActor
                    {
                        ActorID = 12,
                        ContentID = 9
                    },
                    new ContentActor
                    {
                        ActorID = 13,
                        ContentID = 9
                    },
                    new ContentActor
                    {
                        ActorID = 14,
                        ContentID = 9
                    },
                    new ContentActor
                    {
                        ActorID = 17,
                        ContentID = 10
                    },
                    new ContentActor
                    {
                        ActorID = 18,
                        ContentID = 10
                    },
                    new ContentActor
                    {
                        ActorID = 15,
                        ContentID = 11
                    },
                    new ContentActor
                    {
                        ActorID = 16,
                        ContentID = 11
                    },
                    new ContentActor
                    {
                        ActorID = 19,
                        ContentID = 12
                    },
                    new ContentActor
                    {
                        ActorID = 20,
                        ContentID = 12
                    }
                );
            #endregion

            #region TV Actors
            modelBuilder.Entity<ContentActor>().HasData
                (
                    new ContentActor
                    {
                        ActorID = 21,
                        ContentID = 13
                    },
                    new ContentActor
                    {
                        ActorID = 22,
                        ContentID = 13
                    },
                    new ContentActor
                    {
                        ActorID = 23,
                        ContentID = 14
                    },
                    new ContentActor
                    {
                        ActorID = 24,
                        ContentID = 14
                    },
                    new ContentActor
                    {
                        ActorID = 25,
                        ContentID = 15
                    },
                    new ContentActor
                    {
                        ActorID = 26,
                        ContentID = 15
                    },
                    new ContentActor
                    {
                        ActorID = 27,
                        ContentID = 16
                    },
                    new ContentActor
                    {
                        ActorID = 28,
                        ContentID = 16
                    },
                    new ContentActor
                    {
                        ActorID = 29,
                        ContentID = 17
                    },
                    new ContentActor
                    {
                        ActorID = 30,
                        ContentID = 17
                    },
                    new ContentActor
                    {
                        ActorID = 31,
                        ContentID = 18
                    },
                    new ContentActor
                    {
                        ActorID = 32,
                        ContentID = 18
                    },
                    new ContentActor
                    {
                        ActorID = 33,
                        ContentID = 19
                    },
                    new ContentActor
                    {
                        ActorID = 34,
                        ContentID = 19
                    },
                    new ContentActor
                    {
                        ActorID = 35,
                        ContentID = 20
                    },
                    new ContentActor
                    {
                        ActorID = 36,
                        ContentID = 20
                    },
                    new ContentActor
                    {
                        ActorID = 37,
                        ContentID = 21
                    },
                    new ContentActor
                    {
                        ActorID = 38,
                        ContentID = 21
                    },
                    new ContentActor
                    {
                        ActorID = 39,
                        ContentID = 22
                    },
                    new ContentActor
                    {
                        ActorID = 40,
                        ContentID = 22
                    },
                    new ContentActor
                    {
                        ActorID = 41,
                        ContentID = 23
                    },
                    new ContentActor
                    {
                        ActorID = 42,
                        ContentID = 23
                    }
                );
            #endregion

            var randomRatings = new List<ContentRating>();
            var randomGen = new Random();
            for (int i = 1; i < 24; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    randomRatings.Add(new ContentRating
                    {
                        ID = i * 5 + j,
                        ContentID = i,
                        Star = randomGen.Next(1, 5),
                        User = "Random" + randomGen.Next(1, 10)
                    });
                }
            }

            modelBuilder.Entity<ContentRating>().HasData(randomRatings);

            modelBuilder.Entity<User>().HasData
                (
                    new User
                    {
                        ID = 1,
                        Username = "clientapp",
                        Password = "AQAAAAEAACcQAAAAEFaiGDinBLfYXnCmXi09NvroKsGR96Il6rfPQVAwGtDZyDmesY2vHoUuY6+zkoJ1gQ=="
                    }
                );
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }

}
