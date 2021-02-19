using Domain;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Presentation
{
    public class GameLifetimeScope : LifetimeScope
    {
        [SerializeField] HelloScreen HelloScreen;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<GamePresenter>(Lifetime.Singleton);
            builder.Register<HelloWorldService>(Lifetime.Singleton);
            builder.RegisterComponent(HelloScreen);
        }
    }
}