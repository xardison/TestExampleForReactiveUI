using ReactiveUI.Samples.Routing.ViewModels;

namespace ReactiveUI.Samples.Routing.Views
{
    public partial class RightView : IViewFor<IRightViewModel>
    {
        public RightView()
        {
            this.Log(false);
            InitializeComponent();
        }

        ~RightView()
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
                ViewModel = (IRightViewModel)value;
                DataContext = ViewModel;
                Binding();
            }
        }

        public IRightViewModel ViewModel { get; set; }

        private void Binding()
        {
            this.WhenActivated(
                d =>
                { d(this.Bind(ViewModel, model => model.Content, v => v.TbContent.Text)); });
        }
    }
}
