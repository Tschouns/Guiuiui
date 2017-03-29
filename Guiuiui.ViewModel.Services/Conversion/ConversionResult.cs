//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Services.Conversion
{
    /// <summary>
    /// Respresents the result of a conversion.
    /// </summary>
    /// <typeparam name="TResult">
    /// Type of the conversion result
    /// </typeparam>
    public class ConversionResult<TResult>
    {
        /// <summary>
        /// Private constructor for a "success" result.
        /// </summary>
        private ConversionResult(TResult result)
        {
            this.IsSuccessful = true;
            this.Result = result;
        }

        /// <summary>
        /// Private constructor for a "failure" result.
        /// </summary>
        private ConversionResult()
        {
            this.IsSuccessful = false;
        }

        /// <summary>
        /// Creates a result representing a successful conversion.
        /// </summary>
        public static ConversionResult<TResult> CreateSuccessful(TResult result)
        {
            return new ConversionResult<TResult>(result);
        }

        /// <summary>
        /// Creates a result representing a failed conversion.
        /// </summary>
        public static ConversionResult<TResult> CreateFailed()
        {
            return new ConversionResult<TResult>();
        }

        /// <summary>
        /// Gets a value indicating whether the conversion was successful.
        /// </summary>
        public bool IsSuccessful { get; }

        /// <summary>
        /// Gets the result (if successful).
        /// </summary>
        public TResult Result { get; }
    }
}
