using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Counter.Models
{
	public class Game
	{
		public IEnumerable<Player> Players { get; set; }
		public DateTime Date { get; set; }
	}
}
