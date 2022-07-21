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

        public TowerEvent getEventById(int id)
        {
            return _repo.getEventById(id);
        }

        public TowerEvent createEvent(TowerEvent towerEvent)
        {
            return _repo.createEvent(towerEvent);
        }

        internal IEnumerable<TowerEvent> GetByProfileId(string id)
        {
            return _repo.GetByOwnerId(id);
        }
    }
}