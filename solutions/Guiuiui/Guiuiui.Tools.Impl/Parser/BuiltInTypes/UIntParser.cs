//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.Parser.BuiltInTypes
{
    using Guiuiui.Tools.Parser;

    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="uint"/>.
    /// </summary>
    public class UIntParser : IParser<uint>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<uint> TryParse(string value)
        {
            uint result;
            if (uint.TryParse(value, out result))
            {
                return ParseResult<uint>.CreateSuccessful(result);
            }

            return ParseResult<uint>.CreateFailed();
        }
    }
}
