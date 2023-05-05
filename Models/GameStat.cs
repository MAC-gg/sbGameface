using System.ComponentModel.DataAnnotations;

namespace sbGameface.Models
{
    public class GameStat
    {
        [Key] public int Id { get; set; }
        [Required] public int GameId { get; set; }
        [Required] public string StatName { get; set; }
        public string StatDesc { get; set; }
    }
}
