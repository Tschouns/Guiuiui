//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services.Conversion
{
    /// <summary>
    /// Provides a method to convert from one type to another.
    /// </summary>
    /// <typeparam name="TFrom">
    /// Source type of the conversion
    /// </typeparam>
    /// <typeparam name="TTo">
    /// Target type of the conversion
    /// </typeparam>
    public interface IConversion<TFrom, TTo>
    {
        /// <summary>
        /// Tries to convert the specified value from <typeparamref name="TFrom"/> to <typeparamref name="TTo"/>.
        /// </summary>
        ConversionResult<TTo> TryConvert(TFrom value);
    }
}
