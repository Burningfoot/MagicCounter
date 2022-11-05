using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Counter.ViewModels
{
	public class PlayerViewModel : ReactiveObject
	{
		private string name;

		public string Name
		{
			get => name;
			set => this.RaiseAndSetIfChanged(ref name, value);
		}

	}
}
