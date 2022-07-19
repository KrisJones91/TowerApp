namespace TowerApp.Models
{
    public class TowerEvent
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int Tickets { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }

    }
}