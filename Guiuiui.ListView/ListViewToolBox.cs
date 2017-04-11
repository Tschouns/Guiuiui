//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ListView
{
    using Guiuiui.Base.InversionOfControl;
    using System;

    /// <summary>
    /// Provides access to the list view factory, etc..
    /// </summary>
    public static class ListViewToolBox
    {
        private static readonly Lazy<IListViewFactory> _lazyListViewFactory = new Lazy<IListViewFactory>(GetListViewFactoryInstance, true);

        /// <summary>
        /// Gets the <see cref="IListViewFactory"/>.
        /// </summary>
        public static IListViewFactory ListViewFactory
        {
            get
            {
                return _lazyListViewFactory.Value;
            }
        }

        private static IListViewFactory GetListViewFactoryInstance()
        {
            var instance = Ioc.Container.Resolve<IListViewFactory>();
            return instance;
        }
    }
}
