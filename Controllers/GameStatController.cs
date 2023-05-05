using Microsoft.AspNetCore.Mvc;
using System.Linq;
using sbGameface.Data;
using sbGameface.Models;

namespace sbGameface.Controllers
{
    public class GameStatController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GameStatController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public JsonResult GetGameStatList(int? GameId)
        {
            IQueryable GameStatList;
            if (GameId != null)
            {
                GameStatList = _context.GameStat
                  .Where(x => x.GameId == GameId)
                  .Select(x => new
                  {
                      Id = x.Id,
                      GameId = x.GameId,
                      StatName = x.StatName,
                      StatDesc = x.StatDesc,
                  });
            }
            else
            {
                GameStatList = _context.GameStat
                  .Select(x => new
                  {
                      Id = x.Id,
                      GameId = x.GameId,
                      StatName = x.StatName,
                      StatDesc = x.StatDesc,
                  });
            }
            return Json(GameStatList);
        }
    }
}
