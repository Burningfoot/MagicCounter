using Magic_Counter.Models;
using Magic_Counter.Models.PlayerConditions;
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
            for (int i = 0; i < 4; i++)
            {
                var player = new Player();
                for (int j = 0; j < 40; j++)
                {
                    player.PlayerConditions.Add(new LifePoint());
                }
                players.Add(player);
            }
        }
    }
}
