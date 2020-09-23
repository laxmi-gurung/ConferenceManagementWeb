using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace S4597925Assign2.Data.Model
{


    public class Attendee
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public ConferenceTitles ConferenceCode { get; set; }
        public string ConferenceName { get; set; }
        public Attendee attendee { get; set; }

    }
   
}
