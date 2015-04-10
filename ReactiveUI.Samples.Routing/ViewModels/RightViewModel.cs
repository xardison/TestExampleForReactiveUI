namespace ReactiveUI.Samples.Routing.ViewModels
{
    public interface IRightViewModel : IRoutableViewModel
    {
        string Content { get; }
    }

    public class RightViewModel : ReactiveObject, IRightViewModel
    {
        public string UrlPathSegment
        {
            get { return "RightViewModel"; }
        }
        public IScreen HostScreen { get; protected set; }

        public RightViewModel(IScreen screen)
        {
            this.Log(false);
            HostScreen = screen;
            Content = "Right content";
        }

        ~RightViewModel()
        {
            this.Log(true);
        }

        public string Content { get; private set; }
    }
}