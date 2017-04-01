//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services
{
    using Guiuiui.Base.InversionOfControl;
    using Guiuiui.Base.StartUp;
    using Guiuiui.ViewModel.Services.Conversion;
    using Parser;
    using ViewModel.Conversion;
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

            // Conversions
            Ioc.Container.RegisterSingleton<IConversion<string, int>, StringToIntConversion>();

            Ioc.Container.RegisterSingleton<IConversion<bool, bool>, DummyConversion<bool>>();
            Ioc.Container.RegisterSingleton<IConversion<int, int>, DummyConversion<int>>();
            Ioc.Container.RegisterSingleton<IConversion<double, double>, DummyConversion<double>>();
            Ioc.Container.RegisterSingleton<IConversion<decimal, decimal>, DummyConversion<decimal>>();
            Ioc.Container.RegisterSingleton<IConversion<string, string>, DummyConversion<string>>();
        }
    }
}
