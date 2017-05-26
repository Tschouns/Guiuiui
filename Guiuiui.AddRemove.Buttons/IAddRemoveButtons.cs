//-----------------------------------------------------------------------
// <copyright file="BiteMe.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

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
        void Initialize(IAddRemove addRemoveController);
    }
}
