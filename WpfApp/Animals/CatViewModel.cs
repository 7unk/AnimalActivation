namespace WpfApp.Animals
{
    public class CatViewModel : AnimalViewModel
    {
        public CatViewModel()
        {
            Name = "Cat";
        }

        public override string Name { get; }
    }
}
