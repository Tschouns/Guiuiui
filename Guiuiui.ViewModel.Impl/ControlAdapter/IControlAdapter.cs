//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Guiuiui.ViewModel.Impl.ControlAdapter
{
    using System;

    /// <summary>
    /// Provides an abstract interface to interact with any control.
    /// </summary>
    /// <typeparam name="TValue">
    /// Type of the value represented by the control
    /// </typeparam>
    public interface IControlAdapter<TValue>
    {
        /// <summary>
        /// Raised whenever the value of the underlying control has changed.
        /// </summary>
        event EventHandler<ControlValueChangedEventArgs<TValue>> ControlValueChanged;

        /// <summary>
        /// Gets or sets the current value of the control.
        /// </summary>
        TValue Value { get; set; }
    }
}
