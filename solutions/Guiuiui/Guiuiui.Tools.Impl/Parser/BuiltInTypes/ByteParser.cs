//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.Parser.BuiltInTypes
{
    using Guiuiui.Tools.Parser;

    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="byte"/>.
    /// </summary>
    public class ByteParser : IParser<byte>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<byte> TryParse(string value)
        {
            byte result;
            if (byte.TryParse(value, out result))
            {
                return ParseResult<byte>.CreateSuccessful(result);
            }

            return ParseResult<byte>.CreateFailed();
        }
    }
}
