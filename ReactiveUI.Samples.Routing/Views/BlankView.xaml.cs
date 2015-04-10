namespace ReactiveUI.Samples.Routing.Views
{
    using System.Windows;

    using ReactiveUI.Samples.Routing.ViewModels;

    public partial class BlankView : IViewFor<IBlankViewModel>
    {
        public BlankView()
        {
            this.Log(false);
            InitializeComponent();
        }

        ~BlankView()
        {
            this.Log(true);
        }

        object IViewFor.ViewModel
        {
            get
            {
                return ViewModel;
            }
            set
            {
                ViewModel = (IBlankViewModel)value;
                DataContext = ViewModel;
            }
        }

        public IBlankViewModel ViewModel { get; set; }

        private void BtNavToSwitcher_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel.NavigateToSwitcher();
        }
    }
}
