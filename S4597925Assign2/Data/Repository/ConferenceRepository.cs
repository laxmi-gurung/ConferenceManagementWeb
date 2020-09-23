using S4597925Assign2.Data.Interface;
using S4597925Assign2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4597925Assign2.Data.Repository
{
    // Conference Repository
    public class ConferenceRepository : IConferenceRepository
    {
        private List<Conference> _conferenceList;

        public ConferenceRepository()
        {
            // Creating a list of conference details
            _conferenceList = new List<Conference>()
            {
               new Conference() { Id = 1, Date = "01/07/2020", Title = "APTA 2020 26th Annual Conference", Location = "Chiang Mai, Thailand",OrganizerID = 1, OrganizerName = "Chiang Mai University"},
                new Conference() { Id = 2, Date = "01/07/2019", Title = "APTA 2019 25th Annual Conference", Location = "Danang, Vietnam",OrganizerID = 2, OrganizerName = "Duy Tan University"},
                new Conference() { Id = 3, Date = "03/07/2018", Title = "APTA 2018 24th Annual Conference", Location = "Cebu, Philippines", OrganizerID = 3, OrganizerName = "University of Philippines"},
                new Conference() { Id = 4, Date = "18/06/2017", Title = "APTA 2017 23th Annual Conference", Location = "Busan, South Korea", OrganizerID = 4,OrganizerName = "Dong-A University"}
            };
        }

        public Conference Add(Conference conference)
        {
            conference.Id = _conferenceList.Max(e => e.Id) + 1;
            _conferenceList.Add(conference);
            return conference;
        }

        public Conference Delete(int id)
        {
            Conference conference = _conferenceList.FirstOrDefault(e => e.Id == id);
            if(conference != null)
            {
                _conferenceList.Remove(conference);
            }
            return conference;
        }

        public IEnumerable<Conference> GetAllConference()
        {
            return _conferenceList;
        }

        public Conference GetConference(int Id)
        {
            return _conferenceList.FirstOrDefault(e => e.Id == Id);
        }

        public Conference Update(Conference changeConference)
        {
            Conference conference = _conferenceList.FirstOrDefault(e => e.Id == changeConference.Id);
            if (conference != null)
            {
                conference.Title = changeConference.Title;
                conference.Date = changeConference.Date;
                conference.Location = changeConference.Location;
                conference.OrganizerName = changeConference.OrganizerName;
            }
            return conference;
        }
    }
}
