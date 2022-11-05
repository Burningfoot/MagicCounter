using Magic_Counter.Models.PlayerConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Counter.Models
{
	public class Player
	{
		/// <summary>
		/// The name of the player.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// A collection of conditions that a player has.
		/// </summary>
		public IEnumerable<PlayerCondition> PlayerConditions { get; set; }
	}
}
