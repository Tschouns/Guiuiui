//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.DataBinding
{
    using System;

    /// <summary>
    /// Notifies when a value has changed.
    /// </summary>
    public interface INotifyOnValueChanged
    {
        /// <summary>
        /// Raised when a value has changed.
        /// </summary>
        event EventHandler ValueChanged;
    }
}
