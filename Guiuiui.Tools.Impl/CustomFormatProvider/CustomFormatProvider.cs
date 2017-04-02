//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.CustomFormatProvider
{
    using Base.RuntimeChecks;
    using System;
    using Tools.Parser;
    using Tools.TextConverter;

    // TODO: finish.....
    public class CustomFormatProvider<TFormatType> : IFormatProvider
    {
        private readonly IFormatProvider _fallBackFormatProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormatProvider{TFormatType}"/> class.
        /// </summary>
        public CustomFormatProvider(IParser<TFormatType> parser, ITextConverter<TFormatType> textConverter, IFormatProvider fallBackFormatProvider)
        {
            ArgumentChecks.AssertNotNull(parser, nameof(parser));
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));
            ArgumentChecks.AssertNotNull(fallBackFormatProvider, nameof(fallBackFormatProvider));

            this._fallBackFormatProvider = fallBackFormatProvider;
        }

        public object GetFormat(Type formatType)
        {
            // TODO: finish.... 
            return this._fallBackFormatProvider.GetFormat(formatType);
        }
    }
}
