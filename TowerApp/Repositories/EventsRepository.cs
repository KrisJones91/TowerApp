using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public TowerEvent getEventById(int id)
        {
            string sql = "SELECT * FROM towerEvents WHERE id = @id";
            return _db.Query<TowerEvent>(sql, new { id }).FirstOrDefault();
        }
        public TowerEvent createEvent(TowerEvent towerEvent)
        {
            string sql = @"
            INSERT INTO towerEvents
            (title, description, imageURL, tickets, type, location, price, status)
            VALUES
            (@Title, @Description, @ImageURL, @Tickets, @Type, @Location, @Price, @Status);
            SELECT LAST_INSERT_ID();
            ";
            towerEvent.Id = _db.ExecuteScalar<int>(sql, towerEvent);
            return towerEvent;
        }
    }
}