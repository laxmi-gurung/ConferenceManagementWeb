using System;
using S4597925Assign2.Data.Interface;
using S4597925Assign2.Data.Model;
using S4597925Assign2.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace S4597925Assign2.Controllers
{
    // Controller class for the conference model 
    public class ConferenceController : Controller
    {
        private readonly IConferenceRepository _conferenceRepository;

        public ConferenceController(IConferenceRepository conferenceRepository)
        {
            _conferenceRepository = conferenceRepository;
        }

        // Displays Conference Details
        public ViewResult Index()
        {
            var model = _conferenceRepository.GetAllConference();
            return View(model);
        }
    }
}


