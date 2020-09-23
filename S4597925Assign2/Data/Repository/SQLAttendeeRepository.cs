using S4597925Assign2.Data.Interface;
using S4597925Assign2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4597925Assign2.Data.Repository
{
    public class SQLAttendeeRepository : IAttendeeRepository
    {
        private readonly ConferenceDbContext context;

        public SQLAttendeeRepository(ConferenceDbContext context)
        {
            this.context = context;
        }
        public Attendee Add(Attendee attendee)
        {
            // Adding the attendee object and returning it 
            context.Attendees.Add(attendee);
            context.SaveChanges();
            return attendee;
        }

        public Attendee Delete(int id)
        {
            // Finding an attendee by its ID and storing it in a variable 
            Attendee attendee = context.Attendees.Find(id);
            // If the attendee is the one I am looking for, it will be deleted
            if (attendee != null)
            {
                context.Attendees.Remove(attendee);
                context.SaveChanges();
            }
            return attendee;
        }

        public string Delete(Attendee attendee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Attendee> GetAllAttendee()
        {
            // Returning all the attendees
            return context.Attendees;
        }

        public Attendee GetAttendee(int id)
        {
            // Finding a specific attendee by its ID and returning it
            return context.Attendees.Find(id);
        }

        public Attendee Update(Attendee changeAttendee)
        {
            // Modifying the attendee
            var attendee = context.Attendees.Attach(changeAttendee);
            attendee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return changeAttendee;
        }
    }
}
