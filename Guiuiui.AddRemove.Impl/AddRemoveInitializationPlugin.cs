//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Impl
{
    using Base.InversionOfControl;
    using Guiuiui.Base.StartUp;

    /// <summary>
    /// See <see cref="IProjectInitializationPlugin"/>.
    /// </summary>
    [ProjectInitializationPlugin]
    public class AddRemoveInitializationPlugin : IProjectInitializationPlugin
    {
        /// <summary>
        /// See <see cref="IProjectInitializationPlugin.PerformIocContainerRegistrations"/>.
        /// </summary>
        public void PerformIocContainerRegistrations()
        {
            Ioc.Container.RegisterSingleton<IAddRemoveFactory, AddRemoveFactory>();
        }

        /// <summary>
        /// See <see cref="IProjectInitializationPlugin.PerformAdditionalSetup"/>.
        /// </summary>
        public void PerformAdditionalSetup()
        {
        }
    }
}
