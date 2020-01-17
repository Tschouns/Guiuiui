//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.Parser.BuiltInTypes
{
    using Guiuiui.Tools.Parser;

    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="bool"/>.
    /// </summary>
    public class BoolParser : IParser<bool>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<bool> TryParse(string value)
        {
            bool result;
            if (bool.TryParse(value, out result))
            {
                return ParseResult<bool>.CreateSuccessful(result);
            }

            return ParseResult<bool>.CreateFailed();
        }
    }
}
