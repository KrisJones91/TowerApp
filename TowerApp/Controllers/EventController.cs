using Microsoft.AspNetCore.Mvc;
using TowerApp.Services;
namespace TowerApp.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class EventController : ControllerBase
    {
        private readonly EventService _eventService;
        public EventController(EventService eventService)
        {
            _eventService = eventService;
        }
    }
}