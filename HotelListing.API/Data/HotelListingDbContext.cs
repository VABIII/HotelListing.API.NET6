using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        // The options obj parameter will be coming from the db context func in the program.cs file
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        // After creating the classes that setup your db tables, add them below your dbContext function
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }


    }
}






































