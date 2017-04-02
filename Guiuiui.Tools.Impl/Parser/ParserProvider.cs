//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl.Parser
{
    using Guiuiui.Tools.Parser;
    using Base.InversionOfControl;

    /// <summary>
    /// See <see cref="IParserProvider"/>.
    /// </summary>
    public class ParserProvider : IParserProvider
    {
        /// <summary>
        /// See <see cref="IParserProvider.GetParser{TResult}"/>.
        /// </summary>
        /// <typeparam name="TResult">
        /// See <see cref="IParserProvider.GetParser{TResult}"/>.
        /// </typeparam>
        public IParser<TResult> GetParser<TResult>()
        {
            var parser = Ioc.Container.Resolve<IParser<TResult>>();
            if (parser != null)
            {
                return parser;
            }

            return new GenericDefaultParser<TResult>();
        }
    }
}
