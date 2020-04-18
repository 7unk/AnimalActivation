using ReactiveUI;
using System.Reactive.Disposables;

namespace WpfApp.Animals
{
    /// <summary>
    /// Interaction logic for AnimalView.xaml
    /// </summary>
    public partial class AnimalView : ReactiveUserControl<AnimalViewModel>
    {
        public AnimalView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Name,
                        view => view.Name.Text)
                    .DisposeWith(disposables);
            });
        }
    }
}
