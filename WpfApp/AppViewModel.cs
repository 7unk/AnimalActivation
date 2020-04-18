using ReactiveUI;
using System.Reactive;
using WpfApp.Animals;

namespace WpfApp
{
    public class AppViewModel : ReactiveObject
    {
        public AppViewModel()
        {
            Animal = new DogViewModel();
            SwitchCommand = ReactiveCommand.Create(Switch);
        }

        private void Switch()
        {
            if (Animal is DogViewModel)
            {
                Animal = new CatViewModel();
            }
            else
            {
                Animal = new DogViewModel();
            }
        }

        private AnimalViewModel _animal;
        public AnimalViewModel Animal
        {
            get => _animal;
            set => this.RaiseAndSetIfChanged(ref _animal, value);
        }

        public ReactiveCommand<Unit, Unit> SwitchCommand { get; }
    }
}
