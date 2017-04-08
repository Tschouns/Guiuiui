//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools
{
    using System;
    using Guiuiui.Base.InversionOfControl;
    using Guiuiui.ViewModel;

    /// <summary>
    /// Provides access to the view model factory, etc..
    /// </summary>
    public static class ViewModelToolBox
    {
        private static readonly Lazy<IViewModelFactory> _lazyViewModelFactory = new Lazy<IViewModelFactory>(GetViewModelFactoryInstance, true);

        /// <summary>
        /// Gets the <see cref="IViewModelFactory"/>.
        /// </summary>
        public static IViewModelFactory ViewModelFactory
        {
            get
            {
                return _lazyViewModelFactory.Value;
            }
        }

        private static IViewModelFactory GetViewModelFactoryInstance()
        {
            var instance = Ioc.Container.Resolve<IViewModelFactory>();
            return instance;
        }
    }
}
