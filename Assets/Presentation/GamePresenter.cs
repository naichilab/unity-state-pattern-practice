﻿using Domain;
using VContainer.Unity;

namespace Presentation
{
    public class GamePresenter : IStartable
    {
        readonly HelloWorldService _helloWorldService;
        readonly HelloScreen _helloScreen;

        public GamePresenter(HelloWorldService helloWorldService,
            HelloScreen helloScreen)
        {
            _helloWorldService = helloWorldService;
            _helloScreen = helloScreen;
        }

        public void Start()
        {
            _helloScreen.HelloButton.onClick.AddListener(() => _helloWorldService.Hello());
        }
    }
}