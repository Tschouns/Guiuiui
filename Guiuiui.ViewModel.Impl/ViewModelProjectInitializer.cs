//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl
{
    using Guiuiui.Base.InversionOfControl;
    using Guiuiui.Base.RuntimeChecks;
    using Guiuiui.Base.StartUp;
    using Guiuiui.ViewModel.Impl.ControlAdapter;

    /// <summary>
    /// See <see cref="IProjectInitializer"/>.
    /// </summary>
    public class ViewModelProjectInitializer : IProjectInitializer
    {
        /// <summary>
        /// See <see cref="IProjectInitializer"/>.
        /// </summary>
        public void PerformIocContainerRegistrations(IIocContainer aIocContainer)
        {
            ArgumentChecks.AssertNotNull(aIocContainer, nameof(aIocContainer));

            aIocContainer.RegisterSingleton<IControlAdapterFactory, ControlAdapterFactory>();
            aIocContainer.RegisterSingleton<IViewModelFactory, ViewModelFactory>();
        }
    }
}
