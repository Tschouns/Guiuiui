

namespace Guiuiui.ViewModel.Services
{
    using System;
    using Guiuiui.Base.InversionOfControl;
    using Guiuiui.Base.StartUp;

    [ProjectInitializationPlugin]
    public class ViewModelInitializationPlugin : IProjectInitializationPlugin
    {
        public void PerformIocContainerRegistrations()
        {
            Ioc.Container.RegisterSingleton<IViewModelFactory, ViewModelFactory>();
        }
    }
}
