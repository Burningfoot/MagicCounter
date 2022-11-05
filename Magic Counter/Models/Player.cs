using Magic_Counter.Models.PlayerConditions;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Counter.Models
{
    public class Player : ReactiveObject
    {
        private ObservableCollection<PlayerCondition> playerConditions;
        private string name;

        /// <summary>
        /// The name of the player.
        /// </summary>
        public string Name
        {
            get => name;
            set => this.RaiseAndSetIfChanged(ref name, value);
        }

        /// <summary>
        /// A collection of conditions that a player has.
        /// </summary>
        public ObservableCollection<PlayerCondition> PlayerConditions
        {
            get => playerConditions;
            set => this.RaiseAndSetIfChanged(ref playerConditions, value);
        }

        public int LifePoints
        {
            get
            {
                return playerConditions.Where(w => w.GetType().Equals(typeof(LifePoint))).Count() - CommanderDmg;
            }
        }

        public int CommanderDmg
        {
            get
            {
                return playerConditions.Where(w => w.GetType().Equals(typeof(CommanderDamage))).Count();
            }
        }


        public Player()
        {
            PlayerConditions = new ObservableCollection<PlayerCondition>();
        }
    }
}
