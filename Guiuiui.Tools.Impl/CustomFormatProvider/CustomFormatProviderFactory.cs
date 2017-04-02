//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.CustomFormatProvider
{
    using System;
    using Guiuiui.Tools.CustomFormatProvider;
    using Tools.Parser;
    using Tools.TextConverter;
    using Base.RuntimeChecks;
    using System.Globalization;

    public class CustomFormatProviderFactory : ICustomFormatProviderFactory
    {
        public IFormatProvider CreateCustomFormatProvider<TFormatType>(IParser<TFormatType> parser, ITextConverter<TFormatType> textConverter)
        {
            ArgumentChecks.AssertNotNull(parser, nameof(parser));
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));

            return this.CreateCustomFormatProvider<TFormatType>(parser, textConverter, CultureInfo.CurrentCulture);
        }

        public IFormatProvider CreateCustomFormatProvider<TFormatType>(IParser<TFormatType> parser, ITextConverter<TFormatType> textConverter, IFormatProvider fallBackFormatProvider)
        {
            ArgumentChecks.AssertNotNull(parser, nameof(parser));
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));
            ArgumentChecks.AssertNotNull(fallBackFormatProvider, nameof(fallBackFormatProvider));

            return new CustomFormatProvider<TFormatType>(parser, textConverter, fallBackFormatProvider);
        }
    }
}
