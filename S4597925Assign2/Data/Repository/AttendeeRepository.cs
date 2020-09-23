using LibGit2Sharp;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Octokit;
using S4597925Assign2.Data.Model;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using S4597925Assign2.Data.Interface;

using System.Management.Automation;

namespace S4597925Assign2.Data.Repository
{
    public class AttendeeRepository : IAttendeeRepository
    {

        private List<Attendee> _attendeeList;

        public AttendeeRepository()
        {
            _attendeeList = new List<Attendee>()
            {
                new Attendee() { ID = 1, Name = "Clarence Tan", Email = "clareancetan@gmail.com", ConferenceCode = ConferenceTitles.Y2020, ConferenceName = "APTA 2020 26th Annual Conference"},
                new Attendee() { ID = 2, Name = "Timmy Felcon", Email = "timmyfelcon@gmail.com", ConferenceCode = ConferenceTitles.Y2020, ConferenceName = "APTA 2020 26th Annual Conference"},
                new Attendee() { ID = 3, Name = "Andrew Stone", Email = "andrewstone@gmail.com", ConferenceCode = ConferenceTitles.Y2020, ConferenceName = "APTA 2020 26th Annual Conference"}

            };
        }

        public Attendee Add(Attendee attendee)
        {
            attendee.ID = _attendeeList.Max(e => e.ID) + 1;
            _attendeeList.Add(attendee);
            return attendee;
        }

        public Attendee Delete(int id)
        {
            Attendee attendee = _attendeeList.FirstOrDefault(e => e.ID == id);
            if(attendee != null)
            {
                _attendeeList.Remove(attendee);
            }
            return attendee;
        }


        public IEnumerable<Attendee> GetAllAttendee()
        {
            return _attendeeList;
        }

        public Attendee GetAttendee(int id)
        {
            return _attendeeList.FirstOrDefault(e => e.ID == id);
        }


        public Attendee Update(Attendee changeAttendee)
        {
            Attendee attendee = _attendeeList.FirstOrDefault(e => e.ID == changeAttendee.ID);
            if (attendee != null)
            {
                attendee.Name = changeAttendee.Name;
                attendee.Email = changeAttendee.Email;
                attendee.ConferenceName = changeAttendee.ConferenceName;
            }
            return attendee;
        }
    }
}
