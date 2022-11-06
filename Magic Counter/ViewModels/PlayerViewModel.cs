using Magic_Counter.Models;
using Magic_Counter.Models.PlayerConditions;
using Magic_Counter.Models.PlayerConditions.Mana;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Counter.ViewModels
{
    public class PlayerViewModel : ReactiveObject, IDisposable
    {
        readonly CompositeDisposable disposables;
        private string name;
        private Player player;

        public string Name
        {
            get => name;
            set => this.RaiseAndSetIfChanged(ref name, value);
        }

        public Player Player
        {
            get => player;
            set => this.RaiseAndSetIfChanged(ref player, value);
        }

        public ReactiveCommand<Unit, Unit> AddLifePoints { get; set; }
        public ReactiveCommand<Unit, Unit> AddMinusLife { get; set; }
        public ReactiveCommand<Unit, Unit> AddCommanderDmg { get; set; }
        public ReactiveCommand<Unit, Unit> AddColorlessMana { get; set; }

        public PlayerViewModel()
        {
            disposables = new CompositeDisposable();

            AddLifePoints = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Delay(0);
                Player.PlayerConditions.Add(new LifePoint());
            })
             .DisposeWith(disposables);

            disposables = new CompositeDisposable();

            AddMinusLife = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Delay(0);
                Player.PlayerConditions.Add(new MinusLifePoint());
            })
             .DisposeWith(disposables);

            AddCommanderDmg = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Delay(0);
                Player.PlayerConditions.Add(new CommanderDamage());
            })
             .DisposeWith(disposables);

            AddColorlessMana = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Delay(0);
                Player.PlayerConditions.Add(new Colorless());
            })
             .DisposeWith(disposables);
        }

        public void Dispose()
        {
            disposables.Dispose();
        }
    }
}
