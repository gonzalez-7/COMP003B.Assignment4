using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Data;
using COMP003B.Assignment4.Models;

namespace COMP003B.Assignment4.Controllers
{
	public class PlayersController : Controller
	{
		private readonly ApplicationDbContext _context;

		public PlayersController(ApplicationDbContext context) => _context = context;

		[HttpGet]
		public IActionResult Index() => View(_context.Players.ToList());

		[HttpGet]
		public IActionResult Create() => View();

		[HttpPost]
		public IActionResult Create(Player player)
		{
			if (ModelState.IsValid)
			{
				_context.Players.Add(player);
				_context.SaveChanges();
				return RedirectToAction("Confirmation");
			}
			return View(player);
		}

		[HttpGet]
		public IActionResult Confirmation() => View();
	}
}