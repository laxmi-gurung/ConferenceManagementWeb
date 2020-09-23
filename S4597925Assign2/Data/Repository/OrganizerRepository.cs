using S4597925Assign2.Data.Model;
using S4597925Assign2.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4597925Assign2.Data.Interfaces
{
    // Organizer Repository 
    public class OrganizerRepository : IOrganizerRepository
    {
        private List<Organizer> _organizerList;

        public OrganizerRepository()
        {
            // Creating a details of each organizer
            _organizerList = new List<Organizer>()
            {
                new Organizer() { Id = 1, Name = "Chiang Mai University", ConferenceCode = ConferenceTitles.Y2020, ConferenceName = "APTA 2020 26th Annual Conference", Email = "mary1@gmail.com"},
                new Organizer() { Id = 2, Name = "Duy Tan University", ConferenceCode = ConferenceTitles.Y2019, ConferenceName = "APTA 2019 25th Annual Conference", Email = "john2@gmail.com"},
                new Organizer() { Id = 3, Name = "University of Philippines", ConferenceCode = ConferenceTitles.Y2018, ConferenceName = "APTA 2018 24th Annual Conference", Email = "sam3@gmail.com"},
                new Organizer() { Id = 4, Name = "Dong-A University", ConferenceCode = ConferenceTitles.Y2017, ConferenceName = "APTA 2017 23th Annual Conference", Email = "sam3@gmail.com"}
            };
        }

        public Organizer Organizer { get; internal set; }
        public string PageTitle { get; internal set; }

        public Organizer Add(Organizer organizer)
        {
            organizer.Id = _organizerList.Max(e => e.Id) + 1;
            _organizerList.Add(organizer);
            return organizer;
        }

        public Organizer Delete(int id)
        {
            Organizer organizer = _organizerList.FirstOrDefault(e => e.Id == id);
            if (organizer != null)
            {
                _organizerList.Remove(organizer);
            }
            return organizer;
        }

        public IEnumerable<Organizer> GetAllOrganizer()
        {
            return _organizerList;
        }

        public Organizer GetOrganizer(int Id)
        {
            return _organizerList.FirstOrDefault(e => e.Id == Id);
        }

        public Organizer Update(Organizer changeOrganizer)
        {
            Organizer organizer = _organizerList.FirstOrDefault(e => e.Id == changeOrganizer.Id);
            if (organizer != null)
            {
                organizer.Name = changeOrganizer.Name;
                organizer.Email = changeOrganizer.Email;
                organizer.ConferenceName = changeOrganizer.ConferenceName;
            }
            return organizer;
        }
    }
}
