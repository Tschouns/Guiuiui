//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.TextConverter
{
    /// <summary>
    /// Provides a method to register a text converter for a specific type.
    /// </summary>
    public interface ITextConverterRegistry
    {
        /// <summary>
        /// Registers a text converter for <typeparamref name="TValue"/>.
        /// </summary>
        /// <typeparam name="TValue">
        /// Type of the value which is converted
        /// </typeparam>
        void RegisterTextConverter<TValue>(ITextConverter<TValue> textConverter);
    }
}
