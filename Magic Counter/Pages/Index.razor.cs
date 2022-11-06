using Magic_Counter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Counter.Pages
{
    partial class Index
    {
        private List<Player> players;

        public List<Player> Players
        {
            get => players;
            set
            {
                if (players == value) return;
                players = value;
            }
        }

        public Index()
        {
            players = new List<Player>();
            players.Add(new Player() { Name = "Max"});
            players.Add(new Player() { Name = "Tim"});
            players.Add(new Player() { Name = "Ellen"});
            players.Add(new Player() { Name = "Ela"});
        }
    }
}
