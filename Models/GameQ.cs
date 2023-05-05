using System.ComponentModel.DataAnnotations;

namespace sbGameface.Models
{
    public class GameQ
    {
        [Key] public int Id { get; set; }
        [Required] public int GameId { get; set; }
        [Required] public string Q { get;set; }
        [Required] public string ReportCol { get;set; }
    }
}
