//-----------------------------------------------------------------------
// <copyright file="BiteMe.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.ButtonController
{
    using System;

    /// <summary>
    /// Controls and observes buttons, and calls an <see cref="IAddRemove"/> controller instance on click events.
    /// </summary>
    public interface IButtonController
    {
        /// <summary>
        /// Gets or sets a value indicating whether the button controller is enabled, i.e. whether it
        /// reacts to click events.
        /// </summary>
        bool Enabled { get; set; }
    }
}
