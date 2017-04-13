//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.Parser.BuiltInTypes
{
    using Guiuiui.Tools.Parser;

    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="float"/>.
    /// </summary>
    public class FloatParser : IParser<float>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<float> TryParse(string value)
        {
            float result;
            if (float.TryParse(value, out result))
            {
                return ParseResult<float>.CreateSuccessful(result);
            }

            return ParseResult<float>.CreateFailed();
        }
    }
}
