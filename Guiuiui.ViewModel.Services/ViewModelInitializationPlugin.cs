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
    using ViewModel.Conversion;

    [ProjectInitializationPlugin]
    public class ViewModelInitializationPlugin : IProjectInitializationPlugin
    {
        public void PerformIocContainerRegistrations()
        {
            Ioc.Container.RegisterSingleton<IViewModelFactory, ViewModelFactory>();

            // Conversions
            Ioc.Container.RegisterSingleton<IConversion<string, int>, StringToIntConversion>();
        }
    }
}
