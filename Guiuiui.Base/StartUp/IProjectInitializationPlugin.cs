﻿//-----------------------------------------------------------------------
// <copyright file="BiteMe.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.Base.StartUp
{
    /// <summary>
    /// Provides an plug-in interface for initializing a project when starting up the app.
    /// </summary>
    public interface IProjectInitializationPlugin
    {
        /// <summary>
        /// Performs all the necessary IOC container registrations for the project. Is called first.
        /// </summary>
        void PerformIocContainerRegistrations();

        /// <summary>
        /// Performs any additional setup. Is called second.
        /// </summary>
        void PerformAdditionalSetup();
    }
}
