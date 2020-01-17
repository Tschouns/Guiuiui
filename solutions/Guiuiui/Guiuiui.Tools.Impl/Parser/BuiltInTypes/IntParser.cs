//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.Parser.BuiltInTypes
{
    using Guiuiui.Tools.Parser;

    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="int"/>.
    /// </summary>
    public class IntParser : IParser<int>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<int> TryParse(string value)
        {
            int result;
            if (int.TryParse(value, out result))
            {
                return ParseResult<int>.CreateSuccessful(result);
            }

            return ParseResult<int>.CreateFailed();
        }
    }
}
