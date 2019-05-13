using System;
using System.Reactive;
using ReactiveUI;
using ReactiveUITestApp1.Helpers;

namespace ReactiveUITestApp1.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        public ReactiveCommand<Unit,Unit> Command { get; set; }

        public MainViewModel()
        {
            Command = ReactiveCommand.Create(() => { });
        }
    }
}
