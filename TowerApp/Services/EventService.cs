using TowerApp.Repositories;
namespace TowerApp.Services
{
    public class EventService
    {
        private readonly EventsRepository _repo;
        public EventService(EventsRepository repo)
        {
            _repo = repo;
        }
    }
}