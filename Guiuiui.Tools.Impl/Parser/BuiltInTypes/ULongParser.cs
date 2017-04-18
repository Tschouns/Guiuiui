//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.Parser.BuiltInTypes
{
    using Guiuiui.Tools.Parser;

    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="ulong"/>.
    /// </summary>
    public class ULongParser : IParser<ulong>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<ulong> TryParse(string value)
        {
            ulong result;
            if (ulong.TryParse(value, out result))
            {
                return ParseResult<ulong>.CreateSuccessful(result);
            }

            return ParseResult<ulong>.CreateFailed();
        }
    }
}
