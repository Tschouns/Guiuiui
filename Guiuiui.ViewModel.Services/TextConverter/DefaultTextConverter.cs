//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services.TextConverter
{
    using Guiuiui.ViewModel.TextConverter;

    /// <summary>
    /// See <see cref="ITextConverter{TValue}"/>. Default converter which can be used as a
    /// fall-back for anything.
    /// </summary>
    public class DefaultTextConverter : ITextConverter<object>
    {
        /// <summary>
        /// See <see cref="ITextConverter{TValue}.GetText(TValue)"/>.
        /// </summary>
        public string GetText(object value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            return value.ToString();
        }
    }
}
