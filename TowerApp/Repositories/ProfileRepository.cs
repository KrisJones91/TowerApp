

using System.Data;
using Dapper;
using TowerApp.Models;

namespace TowerApp.Repositories
{
    public class ProfileRepository
    {

        private readonly IDbConnection _db;

        public ProfileRepository(IDbConnection db)
        {
            _db = db;
        }

        internal Profile GetById(string id)
        {
            string sql = "SELECT * FROM profiles WHERE id = @id";
            return _db.QueryFirstOrDefault<Profile>(sql, new { id });
        }
        internal Profile Create(Profile newProfile)
        {
            string sql = @"
                INSERT INTO profiles
                    (name, picture, email, id, watchlist)
                VALUES
                    (@Name, @Picture, @Email, @Id, @Watchlist)";
            _db.Execute(sql, newProfile);
            return newProfile;
        }
    }
}