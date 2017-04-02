//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.TextConverter
{
    using Guiuiui.Tools.TextConverter;

    /// <summary>
    /// See <see cref="ITextConverter{TValue}"/>. Default converter which can be used as a
    /// fall-back for anything.
    /// </summary>
    public class GenericDefaultTextConverter<TValue> : ITextConverter<TValue>
    {
        /// <summary>
        /// See <see cref="ITextConverter{TValue}.GetText(TValue)"/>.
        /// </summary>
        public string GetText(TValue value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            return value.ToString();
        }
    }
}
