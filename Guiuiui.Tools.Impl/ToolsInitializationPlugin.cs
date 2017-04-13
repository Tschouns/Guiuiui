//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl
{
    using Guiuiui.Base.StartUp;
    using Base.InversionOfControl;
    using Tools.Reflection;
    using Reflection;
    using Tools.Parser;
    using Parser;
    using Tools.TextConverter;
    using TextConverter;

    /// <summary>
    /// See <see cref="IProjectInitializationPlugin"/>.
    /// </summary>
    [ProjectInitializationPlugin]
    public class ToolsInitializationPlugin : IProjectInitializationPlugin
    {
        /// <summary>
        /// See <see cref="IProjectInitializationPlugin.PerformIocContainerRegistrations"/>.
        /// </summary>
        public void PerformIocContainerRegistrations()
        {
            Ioc.Container.RegisterSingleton<ITypeHelper, TypeHelper>();
            Ioc.Container.RegisterSingleton<ITextConverterRegistry, TextConverterRegistry>();
            Ioc.Container.RegisterSingleton<ITextConverterProvider, TextConverterRegistry>();
            Ioc.Container.RegisterSingleton<IParserProvider, ParserProvider>();

            // Parser
            Ioc.Container.RegisterSingleton<IParser<int>, IntParser>();
            Ioc.Container.RegisterSingleton<IParser<double>, DoubleParser>();
            Ioc.Container.RegisterSingleton<IParser<decimal>, DecimalParser>();
            Ioc.Container.RegisterSingleton<IParser<string>, StringDummyParser>();
        }

        /// <summary>
        /// See <see cref="IProjectInitializationPlugin.PerformAdditionalSetup"/>.
        /// </summary>
        public void PerformAdditionalSetup()
        {
        }
    }
}
