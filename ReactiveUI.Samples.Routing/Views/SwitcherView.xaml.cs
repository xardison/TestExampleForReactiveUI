using System.Windows;

using ReactiveUI.Samples.Routing.ViewModels;

namespace ReactiveUI.Samples.Routing.Views
{
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;

    public partial class SwitcherView : IViewFor<ISwitcherViewModel>
    {
        public SwitcherView()
        {
            this.Log(false);
            InitializeComponent();
        }

        ~SwitcherView()
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
                ViewModel = (ISwitcherViewModel)value;
                DataContext = ViewModel;
                Binding();
            }
        }

        public ISwitcherViewModel ViewModel { get; set; }

        private void Binding()
        {
            LeftHost.ViewModel = ViewModel.LeftViewModel;
            RightHost.ViewModel = ViewModel.RightViewModel;
        }

        private void CbShowHide(object sender, RoutedEventArgs e)
        {
            var tb = sender as CheckBox;
            var visibility = tb.IsChecked == true ? Visibility.Collapsed : Visibility.Visible;

            if (tb.Equals(CbLeft))
            {
                LeftHost.Visibility = visibility;
            }
            else
            {
                RightHost.Visibility = visibility;
            }
        }

        private void BtNavBlank_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.NavigateToBlank();
        }
    }
}
