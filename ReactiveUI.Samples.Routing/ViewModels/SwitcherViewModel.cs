namespace ReactiveUI.Samples.Routing.ViewModels
{
    public interface ISwitcherViewModel : IRoutableViewModel
    {
        LeftViewModel LeftViewModel { get; }
        RightViewModel RightViewModel { get; }
        void NavigateToBlank();
    }

    public class SwitcherViewModel : ReactiveObject, ISwitcherViewModel
    {
        public SwitcherViewModel(IScreen screen)
        {
            this.Log(false);

            HostScreen = screen;

            LeftViewModel = new LeftViewModel(screen);
            RightViewModel = new RightViewModel(screen);
        }

        ~SwitcherViewModel()
        {
            this.Log(true);
        }

        public string UrlPathSegment
        {
            get { return "SwitcherViewModel"; }
        }
        public IScreen HostScreen { get; protected set; }

        public LeftViewModel LeftViewModel { get; private set; }
        public RightViewModel RightViewModel { get; private set; }
        public void NavigateToBlank()
        {
            HostScreen.Router.NavigateBack.Execute(null);
            //HostScreen.Router.Navigate.Execute(new BlankViewModel(HostScreen));
        }
    }
}