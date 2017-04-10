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

    /// <summary>
    /// See <see cref="IProjectInitializationPlugin"/>.
    /// </summary>
    [ProjectInitializationPlugin]
    public class ViewModelInitializationPlugin : IProjectInitializationPlugin
    {
        /// <summary>
        /// See <see cref="IProjectInitializationPlugin.PerformIocContainerRegistrations"/>.
        /// </summary>
        public void PerformIocContainerRegistrations()
        {
            Ioc.Container.RegisterSingleton<IControlAdapterFactory, ControlAdapterFactory>();
            Ioc.Container.RegisterSingleton<IViewModelFactory, ViewModelFactory>();
        }

        /// <summary>
        /// See <see cref="IProjectInitializationPlugin.PerformAdditionalSetup"/>.
        /// </summary>
        public void PerformAdditionalSetup()
        {
        }
    }
}
