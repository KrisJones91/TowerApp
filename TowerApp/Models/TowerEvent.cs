using System.ComponentModel.DataAnnotations;
namespace TowerApp.Models
{
    public class TowerEvent
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        [Required]
        public int Tickets { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Status { get; set; }
        public string CreatorId { get; set; }

        public Profile Creator { get; set; }

    }
}