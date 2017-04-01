//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services
{
    using Guiuiui.Base.InversionOfControl;
    using Guiuiui.Base.StartUp;
    using Parser;
    using ViewModel.Parser;

    [ProjectInitializationPlugin]
    public class ViewModelInitializationPlugin : IProjectInitializationPlugin
    {
        public void PerformIocContainerRegistrations()
        {
            Ioc.Container.RegisterSingleton<IViewModelFactory, ViewModelFactory>();

            // Parser
            Ioc.Container.RegisterSingleton<IParser<int>, IntParser>();
            Ioc.Container.RegisterSingleton<IParser<string>, StringDummyParser>();
        }
    }
}
