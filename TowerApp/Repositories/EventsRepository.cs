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
        internal IEnumerable<TowerEvent> getAllEvents()
        {
            string sql = "SELECT * FROM towerEvents";
            return _db.Query<TowerEvent>(sql);
        }

        internal TowerEvent getEventById(int id)
        {
            string sql = "SELECT * FROM towerEvents WHERE id = @id";
            return _db.Query<TowerEvent>(sql, new { id }).FirstOrDefault();
        }

        internal IEnumerable<TowerEvent> GetByOwnerId(string id)
        {
            string sql = @"
            SELECT
            ev.*,
            pro.*
            FROM towerEvents ev
            JOIN profiles pro ON ev.creatorId = pro.id
            WHERE ev.creatorId = @id;
            ";
            return _db.Query<TowerEvent, Profile, TowerEvent>(sql, (towerEvent, profile) =>
            {
                towerEvent.Creator = profile;
                return towerEvent;
            }
                , new { id }, splitOn: "id");
        }
        // public TowerEvent createEvent(TowerEvent towerEvent)
        // {
        //     string sql = @"
        //     INSERT INTO towerEvents
        //     (title, description, imageURL, tickets, type, location, price, status, creatorId)
        //     VALUES
        //     (@Title, @Description, @ImageURL, @Tickets, @Type, @Location, @Price, @Status, @CreatorId);
        //     SELECT LAST_INSERT_ID();
        //     ";
        //     towerEvent.Id = _db.ExecuteScalar<int>(sql, towerEvent);
        //     return towerEvent;
        // }
        internal TowerEvent createEvent(TowerEvent towerEvent)
        {
            string sql = @"
            INSERT INTO towerEvents
            (title, description, imageURL, tickets, type, location, price, status, creatorId)
            VALUES
            (@Title, @Description, @ImageURL, @Tickets, @Type, @Location, @Price, @Status, @CreatorId);
            SELECT LAST_INSERT_ID();
            ";
            towerEvent.Id = _db.ExecuteScalar<int>(sql, towerEvent);
            return towerEvent;
        }
    }
}