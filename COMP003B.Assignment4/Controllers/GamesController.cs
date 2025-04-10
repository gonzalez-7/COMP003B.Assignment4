using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Data;
using COMP003B.Assignment4.Models;

namespace COMP003B.Assignment4.Controllers
{
	[Route("games")]
	public class GamesController : Controller
	{
		private readonly ApplicationDbContext _context;

		public GamesController(ApplicationDbContext context) => _context = context;

		[HttpGet("list")]
		public IActionResult List() => View(_context.Games.ToList());

		[HttpGet("create")]
		public IActionResult Create() => View();

		[HttpPost("create")]
		public IActionResult Create(Game game)
		{
			if (ModelState.IsValid)
			{
				_context.Games.Add(game);
				_context.SaveChanges();
				return RedirectToAction("Details", new { id = game.GameId });
			}
			return View(game);
		}

		[HttpGet("details/{id:int}")]
		public IActionResult Details(int id)
		{
			var game = _context.Games.Find(id);
			return game == null ? NotFound() : View(game);
		}
	}
}