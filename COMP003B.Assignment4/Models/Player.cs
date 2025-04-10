using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
	public class Player
	{
		public int PlayerId { get; set; }

		[Required, StringLength(100)]
		public string Name { get; set; }

		[Range(1, 100)]
		public int Age { get; set; }

		[Required]
		public string FavoriteGame { get; set; }

		public int? GameId { get; set; }
		public Game? Game { get; set; }
	}
}