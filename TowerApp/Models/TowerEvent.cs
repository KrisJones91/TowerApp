namespace TowerApp.Models
{
    public class TowerEvent
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string EventImage { get; set; }

        public int Tickets { get; set; }
        public string EventType { get; set; }
        public string Location { get; set; }

    }
}