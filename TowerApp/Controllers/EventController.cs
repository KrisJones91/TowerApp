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

        [HttpGet("{id}")]

        public ActionResult<TowerEvent> getEventById(int id)
        {
            try
            {
                return Ok(_eventService.getEventById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<TowerEvent> createEvent([FromBody] TowerEvent towerEvent)
        {
            try
            {
                return Ok(_eventService.createEvent(towerEvent));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}