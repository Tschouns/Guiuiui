//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Facade
{
    using System;
    using AddRemove;
    using Base.InversionOfControl;
    using ListView;
    using Tools.Parser;
    using Tools.TextConverter;
    using ViewModel;

    /// <summary>
    /// Provides access to factories and the likes from different <see cref="Guiuiui"/> libraries.
    /// </summary>
    public static class GuiuiuiToolBox
    {
        private static readonly Lazy<IAddRemoveFactory> _lazyAddRemoveFactory = new Lazy<IAddRemoveFactory>(GetAddRemoveFactoryInstance, true);
        private static readonly Lazy<IListViewFactory> _lazyListViewFactory = new Lazy<IListViewFactory>(GetListViewFactoryInstance, true);
        private static readonly Lazy<IViewModelFactory> _lazyViewModelFactory = new Lazy<IViewModelFactory>(GetViewModelFactoryInstance, true);
        private static readonly Lazy<ITextConverterRegistry> _lazyTextConverterRegistry = new Lazy<ITextConverterRegistry>(GetTextConverterRegistryInstance, true);
        private static readonly Lazy<ITextConverterProvider> _lazyTextConverterProvider = new Lazy<ITextConverterProvider>(GetTextConverterProviderInstance, true);
        private static readonly Lazy<IParserProvider> _lazyParserProvider = new Lazy<IParserProvider>(GetParserProviderInstance, true);

        #region AddRemove

        /// <summary>
        /// Gets the <see cref="IAddRemoveFactory"/>.
        /// </summary>
        public static IAddRemoveFactory AddRemoveFactory
        {
            get
            {
                return _lazyAddRemoveFactory.Value;
            }
        }

        #endregion

        #region ListView

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

        #endregion

        #region ViewModel

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

        #endregion

        #region Tools

        /// <summary>
        /// Gets the <see cref="ITextConverterRegistry"/>.
        /// </summary>
        public static ITextConverterRegistry TextConverterRegistry
        {
            get
            {
                return _lazyTextConverterRegistry.Value;
            }
        }

        /// <summary>
        /// Gets the <see cref="ITextConverterProvider"/>.
        /// </summary>
        public static ITextConverterProvider TextConverters
        {
            get
            {
                return _lazyTextConverterProvider.Value;
            }
        }

        /// <summary>
        /// Gets the <see cref="ITextConverterProvider"/>.
        /// </summary>
        public static IParserProvider Parsers
        {
            get
            {
                return _lazyParserProvider.Value;
            }
        }

        #endregion

        private static IAddRemoveFactory GetAddRemoveFactoryInstance()
        {
            var instance = Ioc.Container.Resolve<IAddRemoveFactory>();
            return instance;
        }

        private static IListViewFactory GetListViewFactoryInstance()
        {
            var instance = Ioc.Container.Resolve<IListViewFactory>();
            return instance;
        }

        private static IViewModelFactory GetViewModelFactoryInstance()
        {
            var instance = Ioc.Container.Resolve<IViewModelFactory>();
            return instance;
        }

        private static ITextConverterRegistry GetTextConverterRegistryInstance()
        {
            var instance = Ioc.Container.Resolve<ITextConverterRegistry>();
            return instance;
        }

        private static ITextConverterProvider GetTextConverterProviderInstance()
        {
            var instance = Ioc.Container.Resolve<ITextConverterProvider>();
            return instance;
        }

        private static IParserProvider GetParserProviderInstance()
        {
            var instance = Ioc.Container.Resolve<IParserProvider>();
            return instance;
        }
    }
}
