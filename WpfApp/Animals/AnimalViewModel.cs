using ReactiveUI;

namespace WpfApp.Animals
{
    public abstract class AnimalViewModel : ReactiveObject
    {
        public abstract string Name { get; }
    }
}
