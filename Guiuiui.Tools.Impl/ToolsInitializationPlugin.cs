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

    [ProjectInitializationPlugin]
    public class ToolsInitializationPlugin : IProjectInitializationPlugin
    {
        public void PerformIocContainerRegistrations()
        {
            Ioc.Container.RegisterSingleton<ITypeHelper, TypeHelper>();
        }
    }
}
