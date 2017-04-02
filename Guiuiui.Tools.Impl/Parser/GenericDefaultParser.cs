//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.Parser
{
    using System;
    using Guiuiui.Tools.Parser;

    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Default parser which can be used as a
    /// fall-back for anything, but the parsing always fails.
    /// </summary>
    /// <typeparam name="TResult">
    /// See <see cref="IParser{TResult}"/>.
    /// </typeparam>
    public class GenericDefaultParser<TResult> : IParser<TResult>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<TResult> TryParse(string value)
        {
            return ParseResult<TResult>.CreateFailed();
        }
    }
}
