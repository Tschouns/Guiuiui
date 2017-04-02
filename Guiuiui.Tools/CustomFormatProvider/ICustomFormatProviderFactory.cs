//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.CustomFormatProvider
{
    using Guiuiui.Tools.Parser;
    using Guiuiui.Tools.TextConverter;
    using System;

    /// <summary>
    /// Creates "custom format providers" which use <see cref="IParser{TResult}"/> and
    /// <see cref="ITextConverter{TValue}"/> instances.
    /// </summary>
    public interface ICustomFormatProviderFactory
    {
        /// <summary>
        /// Creates a "custom format provider" which uses the specified <see cref="IParser{TResult}"/> and
        /// <see cref="ITextConverter{TValue}"/>.
        /// </summary>
        /// <typeparam name="TFormatType">
        /// Type which is parsed or formated
        /// </typeparam>
        IFormatProvider CreateCustomFormatProvider<TFormatType>(IParser<TFormatType> parser, ITextConverter<TFormatType> textConverter);

        /// <summary>
        /// Creates a "custom format provider" which uses the specified <see cref="IParser{TResult}"/> and
        /// <see cref="ITextConverter{TValue}"/> or, as fall-back, the specified <see cref="IFormatProvider"/>.
        /// </summary>
        /// <typeparam name="TFormatType">
        /// Type which is parsed or formated
        /// </typeparam>
        IFormatProvider CreateCustomFormatProvider<TFormatType>(IParser<TFormatType> parser, ITextConverter<TFormatType> textConverter, IFormatProvider fallBackFormatProvider);
    }
}
