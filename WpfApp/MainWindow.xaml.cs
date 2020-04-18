using System.Reactive.Disposables;
using ReactiveUI;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<AppViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new AppViewModel();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Animal,
                        view => view.Animal.ViewModel)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                        viewModel => viewModel.SwitchCommand,
                        view => view.Switch)
                    .DisposeWith(disposables);
            });
        }
    }
}
