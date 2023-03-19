using Microsoft.EntityFrameworkCore;
using Review_Site.Models;
using System.Runtime;
using static System.Net.WebRequestMethods;

namespace Review_Site.Data
{
    public class ReviewSiteContext : DbContext
    {
        public DbSet<ReviewModel> Reviews{ get; set; }
        public DbSet<DestinationModel> Destinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ReviewSite42;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DestinationModel>().HasData(
                new DestinationModel()
                {
                    Id = 1,
                    Name = "Tour of Tokyo",
                    City = "Tokyo",
                    Country = "Japan",
                    Description = "Tokyo, Japan’s busy capital, mixes the ultramodern and the traditional, from neon-lit skyscrapers to historic temples. The opulent Meiji Shinto Shrine is known for its towering gate and surrounding woods. The Imperial Palace sits amid large public gardens. The city's many museums offer exhibits ranging from classical art (in the Tokyo National Museum) to a reconstructed kabuki theater (in the Edo-Tokyo Museum).",
                    ImageURL = "\\Images\\Tokyo1.jpg",
                    ImageList = "\\Images\\Tokyo11.jpg,\\Images\\Tokyo12.jpg,\\Images\\Tokyo13.jpg,\\Images\\Tokyo14.jpg,\\Images\\Tokyo15.jpg,\\Images\\Tokyo16.jpg,\\Images\\Tokyo17.jpg,\\Images\\Tokyo18.jpg",
                    Price = 8000,
                    TourDuration = 10
                },
                new DestinationModel()
                {
                    Id = 2,
                    Name = "Tour of Rome",
                    City = "Rome",
                    Country = "Italy",
                    Description= "Rome was called the “Eternal City” by the ancient Romans because they believed that no matter what happened in the rest of the world, the city of Rome would always remain standing. Exploring the city center by foot surrounded by glorious monuments and colossal remains takes you back in time to the “glory that was Rome”. If you want to see history come to life like never before visit Rome and witness it all aorund you.",
                    Price = 10000,
                    ImageURL = "\\Images\\Rome1.jpg",
                    ImageList = "\\Images\\Rome11.jpg,\\Images\\Rome12.jpg,\\Images\\Rome13.jpg,\\Images\\Rome14.jpg,\\Images\\Rome15.jpg,\\Images\\Rome16.jpg,\\Images\\Rome17.jpg,\\Images\\Rome18.jpg",
                    TourDuration = 7  
                },
                new DestinationModel()
                {
                    Id = 3,
                    Name = "Tour of Paris",
                    City = "Paris",
                    Country = "France",
                    Description = "Paris, France's capital, is a major European city and a global center for art, fashion, gastronomy and culture. Its 19th-century cityscape is crisscrossed by wide boulevards and the River Seine. Beyond such landmarks as the Eiffel Tower and the 12th-century, Gothic Notre-Dame cathedral, the city is known for its cafe culture and designer boutiques along the Rue du Faubourg Saint-Honoré. ",
                    ImageURL = "\\Images\\Paris1.jpg",
                    ImageList = "\\Images\\Paris11.jpg,\\Images\\Paris12.jpg,\\Images\\Paris13.jpg,\\Images\\Paris14.jpg,\\Images\\Paris15.jpg,\\Images\\Paris16.jpg,\\Images\\Paris17.jpg,\\Images\\Paris18.jpg",
                    Price = 7000,
                    TourDuration = 6
                },
                new DestinationModel()
                {
                    Id = 4,
                    Name = "Tour of Mars",
                    City = "Random Crater",
                    Country = "Unknown",
                    Description = "See what no man in history has seen. Be the first to discover the Red Planet. This is a once in a lifetime opportunity.  Travel along with the one and only Elon Musk himself on multibillion dollar spaceship x. Its dangerous, its thrilling, its ridiculous. You can be the first to set your foot and leave human mark on the red planet. Do you have what it takes? Mainly the money? Go and Find out! ",
                    ImageURL = "\\Images\\Mars1.jpg",
                    ImageList = "\\Images\\Mars11.jpg,\\Images\\Mars12.jpg,\\Images\\Mars13.jpg,\\Images\\Mars14.jpg,\\Images\\Mars15.jpg,\\Images\\Mars16.jpg,\\Images\\Mars17.jpg,\\Images\\Mars18.jpg,",
                    Price = 1000000,
                    TourDuration = 2156
                });;








            modelBuilder.Entity<ReviewModel>().HasData(
               new ReviewModel()
               {
                   Id = 1,
                   Content = "Awesome!! Love every minute. Definetly recomend it!!",
                   ReviewerName = "Kate Johnson",
                   ImageURL = "\\Images\\Kate.png",
                   Timestamp = DateTime.ParseExact("2002-10-05", "yyyy-MM-dd", null),
                   StarRating = "5",
                   DestinationsId = 1
               },
                new ReviewModel()
                {
                    Id = 2,
                    Content = "Best trip ever. I want to do it again!!! Friggin Awesome!!",
                    ReviewerName = "John Chelios",
                    ImageURL = "\\Images\\TokyoJohn.png",
                    Timestamp = DateTime.ParseExact("2005-04-04", "yyyy-MM-dd", null),
                    StarRating = "4",
                    DestinationsId = 1
                },
                 new ReviewModel()
                 {
                     Id = 3,
                     Content = "So glad i went. It was a trip of a lifetime. I want to do it again soon!!",
                     ReviewerName = "Karen Smith",
                     ImageURL = "\\Images\\TokyoKaren.png",
                     Timestamp = DateTime.ParseExact("2010-09-09", "yyyy-MM-dd", null),
                     StarRating = "5",
                     DestinationsId = 1
                 },
                  new ReviewModel()
                {
                    Id = 4,
                    Content = "Really enjoyed the sights and scenery. Glad I made the decision to go. Highly recomend it!",
                      ReviewerName = "Hannah Simms",
                    ImageURL = "\\Images\\TokyoHannah.png",
                    Timestamp = DateTime.ParseExact("2007-09-01", "yyyy-MM-dd", null),
                    StarRating = "4",
                    DestinationsId = 1
                },




                   new ReviewModel()
                   {
                       Id = 5,
                       Content = "Awesome!! Love every minute. Definetly recomend it!!",
                       ReviewerName = "James Olson",
                       ImageURL = "\\Images\\James.png",
                       Timestamp = DateTime.ParseExact("2002-10-05", "yyyy-MM-dd", null),
                       StarRating = "5",
                       DestinationsId = 2
                   },
                new ReviewModel()
                {
                    Id = 6,
                    Content = "Best trip ever. I want to do it again!!! Friggin Awesome!!",
                    ReviewerName = "Eric Lindros",
                    ImageURL = "\\Images\\RomeEric.png",
                    Timestamp = DateTime.ParseExact("2005-04-04", "yyyy-MM-dd", null),
                    StarRating = "4",
                    DestinationsId = 2
                },
                 new ReviewModel()
                 {
                     Id = 7,
                     Content = "So glad i went. It was a trip of a lifetime. I want to do it again soon!!",
                     ReviewerName = "Fred Mayer",
                     ImageURL = "\\Images\\RomeFred.png",
                     Timestamp = DateTime.ParseExact("2010-09-09", "yyyy-MM-dd", null),
                     StarRating = "5",
                     DestinationsId = 2
                 },
                  new ReviewModel()
                  {
                      Id = 8,
                      Content = "Really enjoyed the sights and scenery. Glad I made the decision to go. Highly recomend it!",
                      ReviewerName = "Erika Stevenson",
                      ImageURL = "\\Images\\RomeErika.png",
                      Timestamp = DateTime.ParseExact("2007-09-01", "yyyy-MM-dd", null),
                      StarRating = "4",
                      DestinationsId = 2
                  },




                    new ReviewModel()
                    {
                        Id = 9,
                        Content = "Awesome!! Love every minute. Definetly recomend it!!",
                        ReviewerName = "Gary James",
                        ImageURL = "\\Images\\ParisGary.jpg",
                        Timestamp = DateTime.ParseExact("2002-10-05", "yyyy-MM-dd", null),
                        StarRating = "5",
                        DestinationsId = 3
                    },
                new ReviewModel()
                {
                    Id = 10,
                    Content = "Best trip ever. I want to do it again!!! Friggin Awesome!!",
                    ReviewerName = "Angela Salisbury",
                    ImageURL = "\\Images\\ParisAngela.jpg",
                    Timestamp = DateTime.ParseExact("2005-04-04", "yyyy-MM-dd", null),
                    StarRating = "4",
                    DestinationsId = 3
                },
                 new ReviewModel()
                 {
                     Id = 11,
                     Content = "So glad i went. It was a trip of a lifetime. I want to do it again soon!!",
                     ReviewerName = "Lily Lewis",
                     ImageURL = "\\Images\\ParisLily.png",
                     Timestamp = DateTime.ParseExact("2010-09-09", "yyyy-MM-dd", null),
                     StarRating = "5",
                     DestinationsId = 3
                 },




                   new ReviewModel()
                   {
                       Id = 12,
                       Content = "Awesome!! Love every minute. Definetly recomend it!!",
                       ReviewerName = "Kurt Jackson",
                       ImageURL = "\\Images\\MarsKurt.png",
                       Timestamp = DateTime.ParseExact("2002-10-05", "yyyy-MM-dd", null),
                       StarRating = "5",
                       DestinationsId = 4
                   },
                new ReviewModel()
                {
                    Id = 13,
                    Content = "Best trip ever. I want to do it again!!! Friggin Awesome!!",
                    ReviewerName = "Jim Norton",
                    ImageURL = "\\Images\\MarsJim.png",
                    Timestamp = DateTime.ParseExact("2005-04-04", "yyyy-MM-dd", null),
                    StarRating = "4",
                    DestinationsId = 4
                },
                 new ReviewModel()
                 {
                     Id = 14,
                     Content = "So glad i went. It was a trip of a lifetime. I want to do it again soon!!",
                     ReviewerName = "Steven Curtis",
                     ImageURL = "\\Images\\MarsSpaceman.jpg",
                     Timestamp = DateTime.ParseExact("2010-09-09", "yyyy-MM-dd", null),
                     StarRating = "5",
                     DestinationsId = 4
                 },
                new ReviewModel()
                {
                    Id = 15,
                    Content = "It's decent",
                    ReviewerName = "Lawrence Jackson",
                    ImageURL = "\\Images\\MarsSpaceman 2.jpg",
                    Timestamp = DateTime.ParseExact("2002-09-01", "yyyy-MM-dd", null),
                    StarRating = "3",
                    DestinationsId = 4
                });
        }
    }
}
