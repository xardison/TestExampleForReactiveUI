using ReactiveUI.Samples.Routing.Views;
using Splat;

namespace ReactiveUI.Samples.Routing.ViewModels
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public RoutingState Router { get; private set; }

        public AppBootstrapper(IMutableDependencyResolver dependencyResolver = null, RoutingState testRouter = null)
        {
            Router = testRouter ?? new RoutingState();
            dependencyResolver = dependencyResolver ?? Locator.CurrentMutable;

            RegisterParts(dependencyResolver);

            Router.Navigate.Execute(new BlankViewModel(this));
        }

        private void RegisterParts(IMutableDependencyResolver dependencyResolver)
        {
            dependencyResolver.RegisterConstant(this, typeof(IScreen));

            dependencyResolver.Register(() => new SwitcherView(), typeof(IViewFor<SwitcherViewModel>));
            dependencyResolver.Register(() => new LeftView(), typeof(IViewFor<LeftViewModel>));
            dependencyResolver.Register(() => new RightView(), typeof(IViewFor<RightViewModel>));
            dependencyResolver.Register(() => new BlankView(), typeof(IViewFor<BlankViewModel>));
        }
    }
}