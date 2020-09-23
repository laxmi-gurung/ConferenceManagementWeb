using Microsoft.EntityFrameworkCore;
using S4597925Assign2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4597925Assign2.Data
{
    public class ConferenceDbContext : DbContext
    {
        public ConferenceDbContext(DbContextOptions<ConferenceDbContext> options)
            : base(options)
        {

        }

        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Conference> Conferences { get; set; }
    }
}
