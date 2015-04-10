namespace ReactiveUI.Samples.Routing.ViewModels
{
    public interface IBlankViewModel : IRoutableViewModel
    {
        void NavigateToSwitcher();
    }

    public class BlankViewModel : ReactiveObject, IBlankViewModel
    {
        public string UrlPathSegment
        {
            get { return "BlankViewModel"; }
        }
        public IScreen HostScreen { get; protected set; }
        public void NavigateToSwitcher()
        {
            HostScreen.Router.Navigate.Execute(new SwitcherViewModel(HostScreen));
        }

        public BlankViewModel(IScreen screen)
        {
            this.Log(false);
            HostScreen = screen;
        }

        ~BlankViewModel()
        {
            this.Log(true);
        }
    }
}