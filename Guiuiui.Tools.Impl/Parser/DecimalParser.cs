//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.Parser
{
    using Tools.Parser;

    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="decimal"/>.
    /// </summary>
    public class DecimalParser : IParser<decimal>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<decimal> TryParse(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return ParseResult<decimal>.CreateSuccessful(0);
            }

            decimal result;
            if (decimal.TryParse(value, out result))
            {
                return ParseResult<decimal>.CreateSuccessful(result);
            }

            return ParseResult<decimal>.CreateFailed();
        }
    }
}
