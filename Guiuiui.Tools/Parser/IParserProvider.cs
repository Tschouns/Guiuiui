//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Parser
{
    /// <summary>
    /// Provides a method to retrieve a parser for a specific type.
    /// </summary>
    public interface IParserProvider
    {
        /// <summary>
        /// Gets a parser for <typeparamref name="TResult"/>.
        /// </summary>
        /// <typeparam name="TResult">
        /// Output type of the parser
        /// </typeparam>
        IParser<TResult> GetParser<TResult>();
    }
}
