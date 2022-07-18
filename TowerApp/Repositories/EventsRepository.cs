using TowerApp.Models;
using Dapper;

namespace TowerApp.Repositories
{
    public class EventsRepository
    {
        private readonly IDbConnection _db;
        public EventsRepository(IDbConnection db)
        {
            _db = db;
        }

    }
}