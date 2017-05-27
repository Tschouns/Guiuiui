//-----------------------------------------------------------------------
// <copyright file="BiteMe.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using Guiuiui.AddRemove.ButtonController;

namespace Guiuiui.AddRemove.Buttons
{
    /// <summary>
    /// Provides a method to initialize the buttons, and associate them with an <see cref="IAddRemove"/> controller.
    /// </summary>
    public interface IAddRemoveButtons
    {
        /// <summary>
        /// Initializes the buttons, and associates them with an <see cref="IAddRemove"/> controller.
        /// </summary>
        IButtonController Initialize(IAddRemove addRemoveController);
    }
}
