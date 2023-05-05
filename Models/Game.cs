using System.ComponentModel.DataAnnotations;

namespace sbGameface.Models
{
    public class Game
    {
        [Key] public int Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Description { get;set; }
        [Required] public int TeamSize { get; set; }
        public List<GameQ>? Qs { get; set; }
        public List<GameStat>? Stats { get; set; }
    }
}
