namespace EventEase.Models
{
    public class EventModel{
        public int Id { get; set; }
        
        [Required, MinLength(3)]
        public string Title { get; set; } = "";

        [Required]
        public string Description { get; set; } = "";

        [Required]
        public DateTime Date { get; set; } = DateTime.Today;

        [Required]
        public string Location { get; set; } = "";
    }
}
