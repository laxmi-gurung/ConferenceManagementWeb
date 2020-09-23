using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using S4597925Assign2.Data.Interfaces;
using S4597925Assign2.Data.Model;
using S4597925Assign2.Data.Repository;

namespace S4597925Assign2.Controllers
{
    // Controller class for organizer model
    public class OrganizerController : Controller
    {
        private readonly IOrganizerRepository _organizerRepository;

        public OrganizerController(IOrganizerRepository organizerRepository)
        {
            _organizerRepository = organizerRepository;
        }

        public ViewResult Index()
        {
            var model = _organizerRepository.GetAllOrganizer();
            return View(model);
        }

        // Customizing my own error message 
        // Error message alerts user when invalid organizer ID is entered in the URL
        public ViewResult Details(int? id)
        {
            // Customizing Error Message
            Organizer organizer = _organizerRepository.GetOrganizer(id.Value);
            if (organizer == null)
            {
                Response.StatusCode = 404;
                return View("OrganizerNotFound", id.Value);

            }
            OrganizerRepository organizerDetail = new OrganizerRepository()
            {
                Organizer = _organizerRepository.GetOrganizer(id ?? 1),
                PageTitle = "Organizer Detail"
            };

            return View(organizerDetail);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Organizer organizer)
        {
            if (ModelState.IsValid)
            {
                Organizer newOrganizer = _organizerRepository.Add(organizer);
                return RedirectToAction("details", new { id = newOrganizer.Id });
            }
            return View();
        }
    }
}
