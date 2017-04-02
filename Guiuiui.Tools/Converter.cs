//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using Guiuiui.Base.InversionOfControl;
using Guiuiui.Tools.TextConverter;
using System;

namespace Guiuiui.Tools
{
    /// <summary>
    /// Provides access to text converters.
    /// </summary>
    public static class Converter
    {
        private static readonly Lazy<ITextConverterRegistry> _lazyTextConverterRegistry = new Lazy<ITextConverterRegistry>(GetTextConverterRegistryInstance, true);
        private static readonly Lazy<ITextConverterProvider> _lazyTextConverterProvider = new Lazy<ITextConverterProvider>(GetTextConverterProviderInstance, true);

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
        public static ITextConverterProvider TextConverterProvider
        {
            get
            {
                return _lazyTextConverterProvider.Value;
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
    }
}
