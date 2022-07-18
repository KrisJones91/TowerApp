using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TowerApp.Models;
using TowerApp.Services;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace TowerApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private readonly EventService _eventService;

        public EventController(EventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<TowerEvent>> GetAllEvents()
        {
            try
            {
                return Ok(_eventService.GetAllEvents());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}