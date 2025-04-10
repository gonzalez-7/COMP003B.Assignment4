using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
	public class Game
	{
		public int GameId { get; set; }

		[Required, StringLength(100)]
		public string Name { get; set; }

		[Required]
		public string Genre { get; set; }

		[Range(1, 10)]
		public int DifficultyLevel { get; set; }

		[Required]
		public string Publisher { get; set; }
	}
}
