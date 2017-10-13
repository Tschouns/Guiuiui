//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Facade
{
    using System.Collections.Generic;
    using Guiuiui.Base.InversionOfControl;
    using Guiuiui.Base.StartUp;
    using Guiuiui.ListView.Impl;
    using Guiuiui.Tools.Impl;
    using Guiuiui.ViewModel.Impl;

    /// <summary>
    /// Initializes all the components accessible through this facade.
    /// </summary>
    public static class GuiuiuiInitializer
    {
        public static void Initialize()
        {
            var projectInitializers = new List<IProjectInitializer>();

            projectInitializers.Add(new ToolsProjectInitializer());
            projectInitializers.Add(new ViewModelProjectInitializer());
            projectInitializers.Add(new ListViewProjectInitializer());

            foreach (var projectInitializer in projectInitializers)
            {
                projectInitializer.PerformIocContainerRegistrations(Ioc.Container);
            }
        }
    }
}
