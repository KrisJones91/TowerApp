using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TowerApp.Models;
using TowerApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CodeWorks.Auth0Provider;

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
        [Authorize]
        public async Task<ActionResult<TowerEvent>> createEvent([FromBody] TowerEvent towerEvent)
        {
            try
            {
                Profile userInfo = await HttpContext.GetUserInfoAsync<Profile>();
                towerEvent.CreatorId = userInfo.Id;
                return Ok(_eventService.createEvent(towerEvent));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}