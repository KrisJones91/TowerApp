using System;
using System.Collections.Generic;
using TowerApp.Models;
using TowerApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace TowerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly EventService _eventService;
        public EventController(EventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TowerEvent>> getAllEvents()
        {
            try
            {
                return Ok(_eventService.getAllEvents());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}