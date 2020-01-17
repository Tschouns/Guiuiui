//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.TextConverter
{
    /// <summary>
    /// Provides a method to retrieve a text converter for a specific type.
    /// </summary>
    public interface ITextConverterProvider
    {
        /// <summary>
        /// Gets a text converter for <typeparamref name="TValue"/>.
        /// </summary>
        /// <typeparam name="TValue">
        /// Type of the value which is converted
        /// </typeparam>
        ITextConverter<TValue> GetTextConverter<TValue>();
    }
}
