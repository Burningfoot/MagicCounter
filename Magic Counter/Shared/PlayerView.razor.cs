using Magic_Counter.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Counter.Shared
{
	partial class PlayerView
	{

		private Player player;

		[Parameter]
		public Player Player
		{
			get => player;
			set
			{
				if (value == player) return;
				player = value;
				PlayerChanged.InvokeAsync(value);
			}
		}

		[Parameter]
        public EventCallback<Player> PlayerChanged { get; set; }

        protected override void OnParametersSet()
		{
			ViewModel.Player = Player;
			base.OnParametersSet();
		}
	}
}
