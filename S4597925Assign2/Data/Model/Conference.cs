using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace S4597925Assign2.Data.Model
{
    public class Conference
    {
        // Declaring variabls for conference details
        public int Id { get; set; }
        public ConferenceTitles Code { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public string Date { get; set; }
        public string Location { get; set; }
        public int OrganizerID { get; set; }
        public string OrganizerName { get; set; }
    }
}
