//-----------------------------------------------------------------------
// <copyright file="BiteMe.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Base.StartUp
{
    using Guiuiui.Base.InversionOfControl;

    /// <summary>
    /// Provides a common interface for project initializer classed.
    /// </summary>
    public interface IProjectInitializer
    {
        /// <summary>
        /// Performs all the necessary IOC container registrations for the project.
        /// </summary>
        void PerformIocContainerRegistrations(IIocContainer aIocContainer);
    }
}
