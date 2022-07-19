using System.Collections.Generic;
using System.Data;
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
        public IEnumerable<TowerEvent> getAllEvents()
        {
            string sql = "SELECT * FROM towerEvents";
            return _db.Query<TowerEvent>(sql);
        }
    }
}