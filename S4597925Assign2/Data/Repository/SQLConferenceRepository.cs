using LibGit2Sharp;
using S4597925Assign2.Data.Interface;
using S4597925Assign2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4597925Assign2.Data.Repository
{
    public class SQLConferenceRepository : IConferenceRepository
    {
        private readonly ConferenceDbContext context;

        public SQLConferenceRepository(ConferenceDbContext context)
        {
            this.context = context;
        }

        public Conference Add(Conference conference)
        {
            // Adding conference object and returning it
            context.Conferences.Add(conference);
            context.SaveChanges();
            return conference;
        }

        public Conference Delete(int id)
        {
            // Finding a conference by its ID and stoing it in a variable
            Conference conference = context.Conferences.Find(id);
            // If the conference is the one I am looking for, it will be deleted
            if (conference != null)
            {
                context.Conferences.Remove(conference);
                context.SaveChanges();
            }
            return (conference);

        }

        public IEnumerable<Conference> GetAllConference()
        {
            // Returning all the conferences
            return context.Conferences;
        }

        public Conference GetConference(int id)
        {
            // Finding a speific conference by its ID and returning it
            return context.Conferences.Find(id);
        }

        public Conference Update(Conference changeConference)
        {
            // Modifying the conference
            var conference = context.Conferences.Attach(changeConference);
            conference.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return changeConference;
        }

    }
}
