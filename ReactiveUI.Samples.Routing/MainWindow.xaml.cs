using System;
using System.Windows;
using ReactiveUI.Samples.Routing.ViewModels;

namespace ReactiveUI.Samples.Routing
{
    using System.Collections.ObjectModel;

    public partial class MainWindow : Window
    {
        public AppBootstrapper AppBootstrapper { get; protected set; }

        public static ObservableCollection<string> ListMsgDestroy { get; set; }
        public static ObservableCollection<string> ListMsgCreate { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            AppBootstrapper = new AppBootstrapper();
            DataContext = AppBootstrapper;

            ListMsgDestroy = new ObservableCollection<string>();
            ListMsgCreate = new ObservableCollection<string>();

            LbLogDestroy.ItemsSource = ListMsgDestroy;
            LbLogCreate.ItemsSource = ListMsgCreate;
        }

        private void BtGc_OnClick(object sender, RoutedEventArgs e)
        {
            TBefore.Text = GC.GetTotalMemory(false).ToString("n0");
            GC.Collect();
            TAfter.Text = GC.GetTotalMemory(true).ToString("n0");
        }

        private void BtClear_OnClick(object sender, RoutedEventArgs e)
        {
            ListMsgDestroy.Clear();
            ListMsgCreate.Clear();
        }
    }
}
