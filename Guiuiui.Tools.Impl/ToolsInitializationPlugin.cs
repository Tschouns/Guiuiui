//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl
{
    using Guiuiui.Base.StartUp;
    using Base.InversionOfControl;
    using Guiuiui.Tools.Impl.Parser.BuiltInTypes;
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
            Ioc.Container.RegisterSingleton<IParser<bool>, BoolParser>();
            Ioc.Container.RegisterSingleton<IParser<byte>, ByteParser>();
            Ioc.Container.RegisterSingleton<IParser<char>, CharParser>();
            Ioc.Container.RegisterSingleton<IParser<decimal>, DecimalParser>();
            Ioc.Container.RegisterSingleton<IParser<double>, DoubleParser>();
            Ioc.Container.RegisterSingleton<IParser<float>, FloatParser>();
            Ioc.Container.RegisterSingleton<IParser<int>, IntParser>();
            Ioc.Container.RegisterSingleton<IParser<long>, LongParser>();
            Ioc.Container.RegisterSingleton<IParser<sbyte>, SByteParser>();
            Ioc.Container.RegisterSingleton<IParser<short>, ShortParser>();
            Ioc.Container.RegisterSingleton<IParser<string>, StringDummyParser>();
            Ioc.Container.RegisterSingleton<IParser<uint>, UIntParser>();
            Ioc.Container.RegisterSingleton<IParser<ulong>, ULongParser>();
            Ioc.Container.RegisterSingleton<IParser<ushort>, UShortParser>();
        }

        /// <summary>
        /// See <see cref="IProjectInitializationPlugin.PerformAdditionalSetup"/>.
        /// </summary>
        public void PerformAdditionalSetup()
        {
        }
    }
}
