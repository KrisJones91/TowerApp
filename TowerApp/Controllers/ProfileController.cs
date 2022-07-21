using TowerApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TowerApp.Models;

namespace TowerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly ProfileService _profService;
        private readonly EventService _eventService;

        public ProfileController(ProfileService profService, EventService eventService)
        {
            _profService = profService;
            _eventService = eventService;
        }



        [HttpGet("{id}")]
        public ActionResult<Profile> Get(string id)
        {
            try
            {
                Profile profile = _profService.GetProfileById(id);
                return Ok(profile);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Get Users Events
        [HttpGet("{id}/events")]
        public ActionResult<IEnumerable<TowerEvent>> GetEventsByProfileId(string id)
        {
            try
            {
                IEnumerable<TowerEvent> events = _eventService.GetByProfileId(id);
                return Ok(events);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }






    }
}