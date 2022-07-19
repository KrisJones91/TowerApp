using TowerApp.Repositories;
using System.Collections.Generic;
using TowerApp.Models;
namespace TowerApp.Services
{
    public class EventService
    {
        private readonly EventsRepository _repo;
        public EventService(EventsRepository repo)
        {
            _repo = repo;
        }
        public IEnumerable<TowerEvent> getAllEvents()
        {
            return _repo.getAllEvents();
        }
    }
}