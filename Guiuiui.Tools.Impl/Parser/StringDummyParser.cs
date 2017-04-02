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
    /// See <see cref="IParser{TResult}"/>. "Converts" to a string... or really doesn't do anything.
    /// </summary>
    public class StringDummyParser : IParser<string>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>
        /// </summary>
        public ParseResult<string> TryParse(string value)
        {
            return ParseResult<string>.CreateSuccessful(value);
        }
    }
}
