namespace ReactiveUI.Samples.Routing.ViewModels
{
    public interface ILeftViewModel : IRoutableViewModel
    {
        string Content { get; }
    }

    public class LeftViewModel : ReactiveObject, ILeftViewModel
    {
        public string UrlPathSegment
        {
            get { return "LeftViewModel"; }
        }
        public IScreen HostScreen { get; protected set; }

        public LeftViewModel(IScreen screen)
        {
            this.Log(false);
            HostScreen = screen;
            Content = "Left content";
        }

        ~LeftViewModel()
        {
            this.Log(true);
        }

        public string Content { get; private set; }
    }
}