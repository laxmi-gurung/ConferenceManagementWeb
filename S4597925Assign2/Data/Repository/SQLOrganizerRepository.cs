using S4597925Assign2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4597925Assign2.Data.Repository
{
    public class SQLOrganizerRespository : IOrganizerRepository
    {
        private readonly ConferenceDbContext context;

        public SQLOrganizerRespository(ConferenceDbContext context)
        {
            this.context = context;
        }

        public Organizer Add(Organizer organizer)
        {
            // Adding the organizer object and returning it
            context.Organizers.Add(organizer);
            context.SaveChanges();
            return organizer;
        }

        public Organizer Delete(int id)
        {
            // Finding an organizer by its ID and storing it in a variable 
            Organizer organizer = context.Organizers.Find(id);
            // If the organizer is the one I am looking for, it will be deleted
            if (organizer != null)
            {
                context.Organizers.Remove(organizer);
                context.SaveChanges();
            }
            return organizer;
        }

        public IEnumerable<Organizer> GetAllOrganizer()
        {
            // Returning all the organizers
            return context.Organizers;
        }


        public Organizer GetOrganizer(int id)
        {
            // Finding an organizer by its ID and returning it
            return context.Organizers.Find(id);
        }

        public Organizer Update(Organizer changeOrganizer)
        {
            // Modifying the organizer
            var organizer = context.Organizers.Attach(changeOrganizer);
            organizer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return changeOrganizer;

        }
    }
}
