//-----------------------------------------------------------------------
// <copyright file="BiteMe.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.AddRemove.Buttons.ButtonController
{
    using Guiuiui.AddRemove.ButtonController;

    /// <summary>
    /// Dummy implementation of <see cref="IButtonController"/>. Does nothing.
    /// </summary>
    public class DummyButtonController : IButtonController
    {
        /// <summary>
        /// See <see cref="IButtonController.Enabled"/>.
        /// </summary>
        public bool Enabled { get; set; }
    }
}
