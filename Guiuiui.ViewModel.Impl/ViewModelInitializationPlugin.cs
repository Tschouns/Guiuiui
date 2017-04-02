//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl
{
    using Guiuiui.Base.InversionOfControl;
    using Guiuiui.Base.StartUp;
    using ControlAdapter;

    [ProjectInitializationPlugin]
    public class ViewModelInitializationPlugin : IProjectInitializationPlugin
    {
        public void PerformIocContainerRegistrations()
        {
            Ioc.Container.RegisterSingleton<IControlAdapterFactory, ControlAdapterFactory>();
            Ioc.Container.RegisterSingleton<IViewModelFactory, ViewModelFactory>();
        }
        
        public void PerformAdditionalSetup()
        {
        }
    }
}
