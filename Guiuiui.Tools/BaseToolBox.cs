//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools
{
    using Guiuiui.Base.InversionOfControl;
    using Guiuiui.Tools.TextConverter;
    using Parser;
    using System;

    /// <summary>
    /// Provides access to text converters and parsers.
    /// </summary>
    public static class BaseToolBox
    {
        private static readonly Lazy<ITextConverterRegistry> _lazyTextConverterRegistry = new Lazy<ITextConverterRegistry>(GetTextConverterRegistryInstance, true);
        private static readonly Lazy<ITextConverterProvider> _lazyTextConverterProvider = new Lazy<ITextConverterProvider>(GetTextConverterProviderInstance, true);
        private static readonly Lazy<IParserProvider> _lazyParserProvider = new Lazy<IParserProvider>(GetParserProviderInstance, true);

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
