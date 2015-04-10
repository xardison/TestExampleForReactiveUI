using ReactiveUI.Samples.Routing.ViewModels;

namespace ReactiveUI.Samples.Routing.Views
{
    public partial class LeftView : IViewFor<ILeftViewModel>
    {
        public LeftView()
        {
            this.Log(false);
            InitializeComponent();
        }

        ~LeftView()
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
                ViewModel = (ILeftViewModel)value;
                DataContext = ViewModel;
                Binding();
            }
        }

        public ILeftViewModel ViewModel { get; set; }

        private void Binding()
        {
            this.WhenActivated(
                d =>
                { d(this.Bind(ViewModel, model => model.Content, v => v.TbContent.Text)); });
        }
    }
}
