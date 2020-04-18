namespace WpfApp.Animals
{
    public class DogViewModel : AnimalViewModel
    {
        public DogViewModel()
        {
            Name = "Dog";
        }

        public override string Name { get; }
    }
}
