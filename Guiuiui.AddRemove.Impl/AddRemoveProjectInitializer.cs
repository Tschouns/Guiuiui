﻿//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Impl
{
    using Base.InversionOfControl;
    using Guiuiui.Base.RuntimeChecks;
    using Guiuiui.Base.StartUp;

    /// <summary>
    /// See <see cref="IProjectInitializer"/>.
    /// </summary>
    public class AddRemoveProjectInitializer : IProjectInitializer
    {
        /// <summary>
        /// See <see cref="IProjectInitializer.PerformIocContainerRegistrations"/>.
        /// </summary>
        public void PerformIocContainerRegistrations(IIocContainer aIocContainer)
        {
            ArgumentChecks.AssertNotNull(aIocContainer, nameof(aIocContainer));

            aIocContainer.RegisterSingleton<IAddRemoveFactory, AddRemoveFactory>();
        }
    }
}
