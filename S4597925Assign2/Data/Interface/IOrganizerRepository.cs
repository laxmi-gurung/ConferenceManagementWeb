using S4597925Assign2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4597925Assign2.Data.Repository
{
    // Interface for Organizer Repository
    public interface IOrganizerRepository
    {
        // Method that retrieves a specific organizer by Id
        Organizer GetOrganizer(int Id);
        IEnumerable<Organizer> GetAllOrganizer();

        Organizer Add(Organizer organizer);
        Organizer Update(Organizer changeOrganizer);
        Organizer Delete(int id);

    }
}
