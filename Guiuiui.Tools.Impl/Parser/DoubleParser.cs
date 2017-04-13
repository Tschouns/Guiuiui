//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.Parser
{
    using Tools.Parser;

    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="double"/>.
    /// </summary>
    public class DoubleParser : IParser<double>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<double> TryParse(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return ParseResult<double>.CreateSuccessful(0);
            }

            double result;
            if (double.TryParse(value, out result))
            {
                return ParseResult<double>.CreateSuccessful(result);
            }

            return ParseResult<double>.CreateFailed();
        }
    }
}
