using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
    public class ParksApiContext : DbContext
    {
        public DbSet<Park> Parks { get; set; }

        public ParksApiContext(DbContextOptions<ParksApiContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park { ParkId = 1, Name = "Yellowstone National Park", State = "Wyoming", Type = "National", Description = "First national park in the world, known for its geothermal features and wildlife." },
                    new Park { ParkId = 2, Name = "Yosemite National Park", State = "California", Type = "National", Description = "Famous for its giant sequoias, waterfalls, and granite cliffs." },
                    new Park { ParkId = 3, Name = "Grand Canyon National Park", State = "Arizona", Type = "National", Description = "Iconic for its immense canyon and Colorado River views." },
                    new Park { ParkId = 4, Name = "Great Smoky Mountains National Park", State = "Tennessee", Type = "National", Description = "Known for its mist-covered mountains, diverse flora, and historical buildings." },
                    new Park { ParkId = 5, Name = "Zion National Park", State = "Utah", Type = "National", Description = "Famous for its red rock formations, canyons, and diverse plant and animal life." },

                    new Park { ParkId = 6, Name = "Custer State Park", State = "South Dakota", Type = "State", Description = "Known for its wildlife, including a herd of bison, and scenic drives." },
                    new Park { ParkId = 7, Name = "Harriman State Park", State = "New York", Type = "State", Description = "Largest state park in New York, offering hiking, boating, and camping." },
                    new Park { ParkId = 8, Name = "Devil's Lake State Park", State = "Wisconsin", Type = "State", Description = "Famous for its quartzite bluffs, lake views, and recreational activities." },
                    new Park { ParkId = 9, Name = "Fall Creek Falls State Park", State = "Tennessee", Type = "State", Description = "Known for its waterfalls, gorges, and diverse ecosystems." },
                    new Park { ParkId = 10, Name = "Cape Henlopen State Park", State = "Delaware", Type = "State", Description = "Offers beaches, fishing, and historical sites on the Delaware coast." }
                );
        }
    }
}