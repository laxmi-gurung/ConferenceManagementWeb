using S4597925Assign2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4597925Assign2.Data.Interface
{
    // Interface for Conference Repository 
    public interface IConferenceRepository
    {
        // Method that retrieves a specific organizer by Id
        Conference GetConference(int Id);
        IEnumerable<Conference> GetAllConference();
        Conference Add(Conference conference);
        Conference Update(Conference changeConference);
        Conference Delete(int id);
    }
}
