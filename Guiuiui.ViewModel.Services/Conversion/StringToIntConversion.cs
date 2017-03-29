//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services.Conversion
{
    using System;

    /// <summary>
    /// See <see cref="IConversion{TFrom,TTo}"/>. Converts from <see cref="string"/> to <see cref="int"/>.
    /// </summary>
    public class StringToIntConversion : IConversion<string, int>
    {
        /// <summary>
        /// See <see cref="IConversion{TFrom,TTo}.TryConvert"/>.
        /// </summary>
        public ConversionResult<int> TryConvert(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return ConversionResult<int>.CreateSuccessful(0);
            }

            int result;
            if (int.TryParse(value, out result))
            {
                return ConversionResult<int>.CreateSuccessful(result);
            }

            return ConversionResult<int>.CreateFailed();
        }
    }
}
