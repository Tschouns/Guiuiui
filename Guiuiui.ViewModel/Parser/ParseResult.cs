//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Parser
{
    /// <summary>
    /// Respresents the result of a parsing operation.
    /// </summary>
    /// <typeparam name="TResult">
    /// Type of the parse result
    /// </typeparam>
    public class ParseResult<TResult>
    {
        /// <summary>
        /// Private constructor for a "success" result.
        /// </summary>
        private ParseResult(TResult result)
        {
            this.IsSuccessful = true;
            this.Result = result;
        }

        /// <summary>
        /// Private constructor for a "failure" result.
        /// </summary>
        private ParseResult()
        {
            this.IsSuccessful = false;
        }

        /// <summary>
        /// Creates a result representing a successful parsing operation.
        /// </summary>
        public static ParseResult<TResult> CreateSuccessful(TResult result)
        {
            return new ParseResult<TResult>(result);
        }

        /// <summary>
        /// Creates a result representing a failed parsing operation.
        /// </summary>
        public static ParseResult<TResult> CreateFailed()
        {
            return new ParseResult<TResult>();
        }

        /// <summary>
        /// Gets a value indicating whether the parsing opertation was successful.
        /// </summary>
        public bool IsSuccessful { get; }

        /// <summary>
        /// Gets the result (if successful).
        /// </summary>
        public TResult Result { get; }
    }
}
