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
		private string name;
		[Parameter]
		public string Name
		{
			get => name;
			set 
			{
				if (value == name) return;
				name = value;
				NameChanged.InvokeAsync(value);
			}
		}

        [Parameter]
        public EventCallback<string> NameChanged { get; set; }

        protected override void OnParametersSet()
		{
			ViewModel.Name = Name;
			base.OnParametersSet();
		}
	}
}
