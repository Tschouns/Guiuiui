//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services.Conversion
{
    using ViewModel.Conversion;

    /// <summary>
    /// See <see cref="IConversion{TFrom,TTo}"/>. "Converts" anything to itself... or really doesn't do anything.
    /// </summary>
    public class DummyConversion<T> : IConversion<T, T>
    {
        /// <summary>
        /// See <see cref="IConversion{TFrom, TTo}"/>.
        /// </summary>
        public ConversionResult<T> TryConvert(T value)
        {
            return ConversionResult<T>.CreateSuccessful(value);
        }
    }
}
