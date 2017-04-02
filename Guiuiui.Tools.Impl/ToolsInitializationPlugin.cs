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

    [ProjectInitializationPlugin]
    public class ToolsInitializationPlugin : IProjectInitializationPlugin
    {
        public void PerformIocContainerRegistrations()
        {
            Ioc.Container.RegisterSingleton<ITypeHelper, TypeHelper>();

            // Parser
            Ioc.Container.RegisterSingleton<IParser<int>, IntParser>();
            Ioc.Container.RegisterSingleton<IParser<string>, StringDummyParser>();
        }
    }
}
