using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using S4597925Assign2.Data.Interface;
using S4597925Assign2.Data.Model;
using S4597925Assign2.Data.Repository;

namespace S4597925Assign2.Controllers
{
    // Controller page for the attendee model 
    public class AttendeeController : Controller
    {
        private readonly IAttendeeRepository _attendeeRepository;

        public AttendeeController(IAttendeeRepository attendeeRepository)
        {
            _attendeeRepository = attendeeRepository;
        }

        public ViewResult Index()
        {
            var model = _attendeeRepository.GetAllAttendee();
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Attendee attendees)
        {
            if(!ModelState.IsValid)
            {
                return View(attendees);
            }
            _attendeeRepository.Add(attendees);
            return RedirectToAction("Index");
        }


        /**
        public IActionResult Update(Attendee attendee)
        {
            if(!ModelState.IsValid)
            {
                return View(attendee);
            }
            _attendeeRepository.Update(Attendee);
            return RedirectToAction("Index");
        }
        **/
    }
}
