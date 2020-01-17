//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Tools.Impl
{
    using Guiuiui.Base.InversionOfControl;
    using Guiuiui.Base.RuntimeChecks;
    using Guiuiui.Base.StartUp;
    using Guiuiui.Tools.Impl.Parser;
    using Guiuiui.Tools.Impl.Parser.BuiltInTypes;
    using Guiuiui.Tools.Impl.Reflection;
    using Guiuiui.Tools.Impl.TextConverter;
    using Guiuiui.Tools.Parser;
    using Guiuiui.Tools.Reflection;
    using Guiuiui.Tools.TextConverter;

    /// <summary>
    /// See <see cref="IProjectInitializer"/>.
    /// </summary>
    public class ToolsProjectInitializer : IProjectInitializer
    {
        /// <summary>
        /// See <see cref="IProjectInitializer"/>.
        /// </summary>
        public void PerformIocContainerRegistrations(IIocContainer aIocContainer)
        {
            ArgumentChecks.AssertNotNull(aIocContainer, nameof(aIocContainer));

            aIocContainer.RegisterSingleton<ITypeHelper, TypeHelper>();
            aIocContainer.RegisterSingleton<ITextConverterRegistry, TextConverterRegistry>();
            aIocContainer.RegisterSingleton<ITextConverterProvider, TextConverterRegistry>();
            aIocContainer.RegisterSingleton<IParserProvider, ParserProvider>();

            // Parser
            aIocContainer.RegisterSingleton<IParser<bool>, BoolParser>();
            aIocContainer.RegisterSingleton<IParser<byte>, ByteParser>();
            aIocContainer.RegisterSingleton<IParser<char>, CharParser>();
            aIocContainer.RegisterSingleton<IParser<decimal>, DecimalParser>();
            aIocContainer.RegisterSingleton<IParser<double>, DoubleParser>();
            aIocContainer.RegisterSingleton<IParser<float>, FloatParser>();
            aIocContainer.RegisterSingleton<IParser<int>, IntParser>();
            aIocContainer.RegisterSingleton<IParser<long>, LongParser>();
            aIocContainer.RegisterSingleton<IParser<sbyte>, SByteParser>();
            aIocContainer.RegisterSingleton<IParser<short>, ShortParser>();
            aIocContainer.RegisterSingleton<IParser<string>, StringDummyParser>();
            aIocContainer.RegisterSingleton<IParser<uint>, UIntParser>();
            aIocContainer.RegisterSingleton<IParser<ulong>, ULongParser>();
            aIocContainer.RegisterSingleton<IParser<ushort>, UShortParser>();
        }
    }
}
