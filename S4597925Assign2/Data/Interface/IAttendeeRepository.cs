using S4597925Assign2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4597925Assign2.Data.Interface
{
    public interface IAttendeeRepository
    {
       // IEnumerable<Attendee> GetAllWithConferences();
        Attendee GetAttendee(int id);
        IEnumerable<Attendee> GetAllAttendee();
        Attendee Add(Attendee attendee);
        Attendee Update(Attendee changeAttendee);
        Attendee Delete(int id);
    }
}
