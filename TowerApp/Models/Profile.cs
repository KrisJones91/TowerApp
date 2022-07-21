namespace TowerApp.Models
{
    public class Profile : Account
    {
        public string CreatorId { get; set; }
        public string Watchlist { get; set; }
    }
}